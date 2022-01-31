using AutoMapper;
using BackEndcsvfile.Commands;
using BackEndcsvfile.Dtos;
using BackEndcsvfile.Requests;
using BackEndcsvfile.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CsvFileDto, CsvfileResponse>();
            CreateMap<StudentRequest, CsvFileDto>();
            CreateMap<CreateCsvFileCommand, CsvFileDto>();
        }
    }
}
