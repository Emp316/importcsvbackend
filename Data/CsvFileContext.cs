using BackEndcsvfile.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Data
{
    public class CsvFileContext : DbContext
    {
        private Microsoft.Extensions.Configuration.IConfiguration configuration;

        public CsvFileContext(DbContextOptions<CsvFileContext> options, Microsoft.Extensions.Configuration.IConfiguration iconfig)
           : base(options)
        {
            configuration = iconfig;
        }

        public DbSet<CsvFileDto> CsvFile { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetValue<string>("ConnectionStrings:CsvFileConnection"));
        }
    }
}
