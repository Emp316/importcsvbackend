using BackEndcsvfile.Requests;
using BackEndcsvfile.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Commands
{
    public class CreateCsvFileCommand : IRequest<List<CsvfileResponse>>
    {
        public List<StudentRequest> students { get; set; }
    }
}
