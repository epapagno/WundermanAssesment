using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wunderman.App.Contracts;
using Wunderman.App.DTO.Jobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPA.Distributed.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataJobController : ControllerBase
    {
        private readonly IDataProcessorService _dataJobServiceApp;

        public DataJobController(IDataProcessorService dataJobServiceApp)
        {
            _dataJobServiceApp = dataJobServiceApp;
        }
        // GET: api/DataJob
        [HttpGet()]
        public async Task<IActionResult> Find()
        {
            var response = await _dataJobServiceApp.GetAllDataJobs();

            return Ok(response);
        }

        // GET: api/DataJob/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var response = await _dataJobServiceApp.GetDataJob(id);
            return Ok(response);
        }

        // GET: api/DataJob/DataJobStatus
        [HttpGet("{DataJobStatus}")]
        public async Task<IActionResult> Get([FromQuery]DataJobStatus request)
        {
            var response = await _dataJobServiceApp.GetDataJobsByStatus(request);
            return Ok(response);
        }

        // POST: api/DataJob
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DataJobDTO request)
        {
            var response = await _dataJobServiceApp.Create(request);

            return Ok(response);
        }

        // PUT: api/DataJob/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] DataJobDTO request)
        {
            request.Id = id;
            var response = await _dataJobServiceApp.Update(request);

            return Ok(response);
        }

        // DELETE: api/ApiWithActions/5
        // DELETE: api/DataJob/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _dataJobServiceApp.Delete(id);

            return Ok();
        }
    }
}
