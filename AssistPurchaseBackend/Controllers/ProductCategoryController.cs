using System.Collections.Generic;
using AssistPurchaseData;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        readonly FilterMonitoringDevices _filter=new FilterMonitoringDevices();
        readonly UtilityFunctions utility = new UtilityFunctions();

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
           return _filter.GetHighBpType();
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
        [HttpGet("GetDevices")]
        public List<MonitoringDevice> GetAllMonitoringDevices()
        {
            return _filter.GetAllDevices();
        }

        [HttpDelete("{devicename}")]
        public List<MonitoringDevice> Delete(string deviceName)
        {
            return this.utility.RemoveDevice(deviceName);
        }
        [HttpPost("PostDevice")]
        public void AddMonitoringDevice(MonitoringDevice device)
        {
            utility.AddDevice(device);
        }


    }
}
