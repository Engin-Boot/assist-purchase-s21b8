using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssistPurchaseBackend.Services;
using AssistPurchaseData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssistPurchaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterByDeviceNameController : ControllerBase
    {
        FilterDeviceName filter=new FilterDeviceName();
       
        [HttpGet("Cardiac")]
        public List<MonitoringDevice> GetCardiac()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.Cardiac();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;

        }
        [HttpGet("Pneumonia")]
        public List<MonitoringDevice> GetPneumonia()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.Pneumonia();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;

        }
        [HttpGet("Covid19")]
        public List<MonitoringDevice> GetCovid19()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.Covid19();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;

        }

        [HttpGet("HighBP")]
        public List<MonitoringDevice> Get()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.HighBP();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }
        [HttpGet("BatteryLife/{value}")]
        public List<MonitoringDevice> GetBatteryLife(string value)
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.BatteryLife(value);

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }
        [HttpGet("Display/{value}")]
        public List<MonitoringDevice> GetDisplay(string value)
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.Display(value);

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }
        [HttpGet("MobileorStatic/{value}")]
        public List<MonitoringDevice> GetMobileorStatic(string value)
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.MobileorStatic(value);

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }
        [HttpGet("AdvancedFeatures/{value}")]
        public List<MonitoringDevice> GetAdvancedFeatures()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.AdvancedFeatures();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }
        [HttpGet("Alaraming/{value}")]
        public List<MonitoringDevice> GetPhysiologicalAlaram()
        {
            List<MonitoringDevice> NameFilteredList = new List<MonitoringDevice>();

            NameFilteredList = filter.Alaraming();

            //NameFilteredList=filterDevice.Filter1(FilterByBatteryLife);
            return NameFilteredList;
        }


    }
}
