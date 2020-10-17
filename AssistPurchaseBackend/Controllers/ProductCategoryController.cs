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
            return _filter.GetCardiacType();
        }
        [HttpGet("Pneumonia")]
        public List<MonitoringDevice> GetCategoryPneumoniaTypeDevices()
        {
             return _filter.GetPneumoniaType();
        }
        [HttpGet("Covid19")]
        public List<MonitoringDevice> GetCategoryCovid19TypeDevices()
        {
            return _filter.GetCovid19Type();
        }

        [HttpGet("HighBP")]
        public List<MonitoringDevice> GetCategoryHighBpTypeDevices()
        {
           return _filter.GetHighBPType();
        }
        [HttpGet("BatteryLife/{value}")]
        public List<MonitoringDevice> GetCatergoryBatteryLifeOfDevices(string value)
        {
            return _filter.GetBatteryLifeType(value);
        }
        [HttpGet("Display/{value}")]
        public List<MonitoringDevice> GetCategoryDisplayofDevices(string value)
        {
            return _filter.GetDisplay(value);
        }
        [HttpGet("MobileorStatic/{value}")]
        public List<MonitoringDevice> GetCategoryMobileorStaticDevices(string value)
        {
            return _filter.GetMobileorStaticType(value);
        }
        [HttpGet("AdvancedFeatures/{value}")]
        public List<MonitoringDevice> GetCategoryAdvancedFeaturedDevices()
        {
            return _filter.GetAdvancedFeaturesType();
        }
        [HttpGet("Alaraming/{value}")]
        public List<MonitoringDevice> GetCateDevicesgoryPhysiologicalAlaramedDevices()
        {
            return _filter.GetAlaramingType();
        }


    }
}
