using BackEndcsvfile.Data;
using BackEndcsvfile.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Repository
{
    public class CsvFileRepository : ICsvFileRepository
    {
        private CsvFileContext _csvFileContext;
        public CsvFileRepository(CsvFileContext csvFileContext)
        {
            _csvFileContext = csvFileContext;
        }

        public async Task<List<CsvFileDto>> GetAll()
        {
            return await _csvFileContext.CsvFile
                .ToListAsync();
        }

        public async Task<List<CsvFileDto>> Save(CsvFileDto csvFile)
        {
            try { 
                        csvFile.IsActive = true;
                        csvFile.CreateDate = DateTime.Now;
                        csvFile.DeletedDate = DateTime.Now;

                    await _csvFileContext.AddAsync(csvFile);
                    await _csvFileContext.SaveChangesAsync();

                    return await GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine($"The Csv couldn't be added: '{e}'");
            }
            return await GetAll();
        }
    }
}
