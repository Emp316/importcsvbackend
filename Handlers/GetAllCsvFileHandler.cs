using AutoMapper;
using BackEndcsvfile.Query;
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
    public class GetAllCsvFileHandler : IRequestHandler<GetAllCsvFilesQuery, List<CsvfileResponse>>
    {
        private readonly ICsvFileRepository _csvFile;
        private readonly IMapper _mapper;

        public GetAllCsvFileHandler(ICsvFileRepository csvFile, IMapper mapper)
        {
            _csvFile = csvFile;
            _mapper = mapper;
        }

        public async Task<List<CsvfileResponse>> Handle(GetAllCsvFilesQuery request, CancellationToken cancellationToken)
        {
            var lst = await _csvFile.GetAll();
            //lst.ForEach(x =>
            //{
            //    x.students.Where(c => c.IsActive);
            //});
            return _mapper.Map<List<CsvfileResponse>>(lst);
            //return _mapper.Map<List<CsvfileResponse>>(lst.Where(x => x.IsActive));
        }
    }
}
