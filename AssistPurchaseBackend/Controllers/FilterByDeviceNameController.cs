using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterByDeviceNameController : ControllerBase
    {
        Services.IFilter filter;

        public FilterByDeviceNameController(Services.IFilter _filter)
        {
            this.filter = _filter;
        }
        // GET: api/FilterByDeviceName
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FilterByDeviceName/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<MonitoringDevice> Get(string id)
        {
            return filter.Filter(id);
        }

        // POST: api/FilterByDeviceName
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FilterByDeviceName/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
