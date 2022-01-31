using AutoMapper;
using BackEndcsvfile.Commands;
using BackEndcsvfile.Dtos;
using BackEndcsvfile.Repository;
using BackEndcsvfile.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BackEndcsvfile.Handlers
{
    public class CreateCsvFileHandler : IRequestHandler<CreateCsvFileCommand, List<CsvfileResponse>>
    {
        private readonly ICsvFileRepository _csvFile;
        private readonly IMapper _mapper;

        public CreateCsvFileHandler(ICsvFileRepository csvFile, IMapper mapper)
        {
            _csvFile = csvFile;
            _mapper = mapper;
        }

        public async Task<List<CsvfileResponse>> Handle(CreateCsvFileCommand request, CancellationToken cancellationToken)
        {
            try
            {
                foreach (var item in request.students)
                {
                    CsvFileDto csvFile = new CsvFileDto();
                    csvFile.Id = Guid.NewGuid();
                    csvFile.CourseCode = item.CourseCode;
                    csvFile.FirstName = item.FirstName;
                    csvFile.Surname = item.Surname;
                    csvFile.CourseDescription = item.CourseDescription;
                    csvFile.Grade = item.Grade;
                    csvFile.StudentNumber = item.StudentNumber;

                    await _csvFile.Save(_mapper.Map<CsvFileDto>(csvFile));
                }

                var resp = await _csvFile.Save(_mapper.Map<CsvFileDto>(request));
                return _mapper.Map<List<CsvfileResponse>>(resp);
            }
            catch (Exception e)
            {
                Console.WriteLine($"The Csv couldn't be added: '{e}'");
            }
            return null;
        }
    }
}
