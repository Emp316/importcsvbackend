using BackEndcsvfile.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Query
{
    public class GetAllCsvFilesQuery : IRequest<List<CsvfileResponse>>
    {
    }
}
