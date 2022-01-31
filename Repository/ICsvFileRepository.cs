using BackEndcsvfile.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Repository
{
    public interface ICsvFileRepository
    {
        Task<List<CsvFileDto>> GetAll();
        Task<List<CsvFileDto>> Save(CsvFileDto csvFile);

    }
}
