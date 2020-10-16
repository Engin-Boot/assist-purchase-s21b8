using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssistPurchaseBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterByDeviceNameController : ControllerBase
    {
        readonly Services.IFilter _filter;

        public FilterByDeviceNameController(Services.IFilter filter)
        {
            this._filter = filter;
        }

        // GET: api/FilterByDeviceName/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<AssistPurchaseData.MonitoringDevice> Get(String id)
        {
            return _filter.Filter(id);
        }
        //FilterDeviceName filterDevice=new FilterDeviceName();
        
        //Services.IFilter filter;
        //Services.IFilter filter1;


        //public List<MonitoringDevice> Get(string FilterByName , string FilterByBatteryLife)
        //{
        //    List<MonitoringDevice> NameFilteredList=new List<MonitoringDevice>();

        //    NameFilteredList=filterDevice.Filter(FilterByName,FilterByBatteryLife);

        //     //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
        //     return NameFilteredList;

        //}
       // GET: api/FilterByDeviceName
       //[HttpGet]
       // public IEnumerable<MonitoringDevice> Get()
       // {
       //     retu
       // }

        //GET: api/FilterByDeviceName/5
        //[HttpGet("{id}", Name = "Get")]
        //public IEnumerable<> Get(string id)
        //{
        //    return _filter.Filter(id);
        //}

        //// POST: api/FilterByDeviceName
        //[HttpPost]
        //public void Post([FromBody] Services.IFilter filter)
        //{
        //    try
        //    {
        //        this.filter = filter;
        //        this.filter1 = filter;
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}

        //// PUT: api/FilterByDeviceName/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
