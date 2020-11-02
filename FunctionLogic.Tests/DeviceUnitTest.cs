using AssistPurchaseData;
using Services;
using System.Collections.Generic;
using Xunit;

namespace FunctionLogic.Tests
{
    public  class DeviceUnitTest
    {
        //private List<MonitoringDevice> _resultList = new List<MonitoringDevice>();
        //private  readonly FilterMonitoringDevices _filterMonitoringDevices = new FilterMonitoringDevices();
        //[Fact]
        //public void Test_ShouldReturnCardiacDevice()
        //{
        //    _resultList = _filterMonitoringDevices.GetCardiacType();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.Ecg == "YES" && device.Hr == "YES");
        //    }

        //}
        //[Fact]
        //public void Test_ShouldReturnPnemoniaDevice()
        //{
        //    _resultList = _filterMonitoringDevices.GetPneumoniaType();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.Respiration == "YES" && device.Spo2 == "YES");
        //    }

        //}

        //[Fact]
        //public void Test_ShouldReturnCovid19Device()
        //{
        //    _resultList = _filterMonitoringDevices.GetCovid19Type();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.Respiration == "YES" && device.BloodPressure == "YES");
        //    }

        //}

        //[Fact]
        //public void Test_ShouldReturnHighBpDevice()
        //{
        //    _resultList = _filterMonitoringDevices.GetHighBpType();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.BloodPressure == "YES");
        //    }

        //}

        // [Fact]
        //public void Test_GetBatteryLifeDevice()
        //{
        //    int batteryLife = 5;
        //    _resultList = _filterMonitoringDevices.GetBatteryLifeType(batteryLife.ToString());
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.BatteryLife == batteryLife.ToString());
        //    }

        //}

        //[Fact]
        //public void Test_Display()
        //{
        //    string displaysize = "12.1";
        //    _resultList = _filterMonitoringDevices.GetDisplay(displaysize);
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.Size == displaysize || device.SupportedScreenOrientations == "YES");
        //    }

        //}

        //[Fact]
        //public void Test_AdvancedFeature()
        //{
            
        //    _resultList = _filterMonitoringDevices.GetAdvancedFeaturesType();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.PatientLocation == "YES" && device.AntiMicrobialGlass == "YES");
        //    }
        //}

        //[Fact]
        //public void Test_MobileOrStatic()
        //{
        //    string value = "MOBILE";
        //    _resultList = _filterMonitoringDevices.GetMobileorStaticType(value);
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.MobileOrStatic == value);
        //    }
        //}

        //[Fact]
        //public void Test_Alarming()
        //{
            
        //    _resultList = _filterMonitoringDevices.GetAlaramingType();
        //    foreach (var device in _resultList)
        //    {
        //        Assert.True(device.PhysiologicalAlarming == "YES");
        //    }
        //}

        //[Fact]
        //public void Test_AllDevice()
        //{

        //    _resultList = _filterMonitoringDevices.GetAllDevices();
        //    Assert.NotNull(_resultList);
        //}


    }
}
