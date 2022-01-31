using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndcsvfile.Commands;
using BackEndcsvfile.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndcsvfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CsvController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CsvController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllCsvFilesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCsvFileCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
