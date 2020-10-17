using System.Collections.Generic;
using AssistPurchaseBackend.Services;
using AssistPurchaseData;
using Microsoft.AspNetCore.Mvc;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        readonly FilterMonitoringDevices _filter=new FilterMonitoringDevices();
       
        [HttpGet("Cardiac")]
        public List<MonitoringDevice> GetCategoryCardiacTypeDevices()
        {
            var nameFilteredList = _filter.Cardiac();


            return nameFilteredList;
        }
        [HttpGet("Pneumonia")]
        public List<MonitoringDevice> GetCategoryPneumoniaTypeDevices()
        {
            var nameFilteredList = _filter.Pneumonia();


            return nameFilteredList;
        }
        [HttpGet("Covid19")]
        public List<MonitoringDevice> GetCategoryCovid19TypeDevices()
        {
            var nameFilteredList = _filter.Covid19();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return nameFilteredList;
        }

        [HttpGet("HighBP")]
        public List<MonitoringDevice> GetCategoryHighBpTypeDevices()
        {
            var nameFilteredList = _filter.HighBP();


            return nameFilteredList;
        }
        [HttpGet("BatteryLife/{value}")]
        public List<MonitoringDevice> GetCatergoryBatteryLifeOfDevices(string value)
        {
            var nameFilteredList = _filter.BatteryLife(value);


            return nameFilteredList;
        }
        [HttpGet("Display/{value}")]
        public List<MonitoringDevice> GetCategoryDisplayofDevices(string value)
        {
            var nameFilteredList = _filter.Display(value);


            return nameFilteredList;
        }
        [HttpGet("MobileorStatic/{value}")]
        public List<MonitoringDevice> GetCategoryMobileorStaticDevices(string value)
        {
            var nameFilteredList = _filter.MobileorStatic(value);


            return nameFilteredList;
        }
        [HttpGet("AdvancedFeatures/{value}")]
        public List<MonitoringDevice> GetCategoryAdvancedFeaturedDevices()
        {
            var nameFilteredList = _filter.AdvancedFeatures();


            return nameFilteredList;
        }
        [HttpGet("Alaraming/{value}")]
        public List<MonitoringDevice> GetCateDevicesgoryPhysiologicalAlaramedDevices()
        {
            var nameFilteredList = _filter.Alaraming();


            return nameFilteredList;
        }


    }
}
