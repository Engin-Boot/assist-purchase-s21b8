using Services;
using Xunit;


namespace Api.Tests
{
    public class FilterMonitoringDeviceTests
    {
        private readonly FilterMonitoringDevices _filterMonitoringDevice = new FilterMonitoringDevices();

        [Fact]
        void GetCardiacType_ShouldReturnCardiacTypeObjects()
        {
            var resultList = _filterMonitoringDevice.GetCardiacType();
            foreach (var device in resultList)
            {
                Assert.True(device.Ecg == "YES" && device.Hr == "YES");
            }
        }
        [Fact]
        void GetPnemoniaType_ShouldReturnPneumoniaTypeObjects()
        {
            var resultList = _filterMonitoringDevice.GetPneumoniaType();
            foreach (var device in resultList)
            {
                Assert.True(device.Respiration == "YES" && device.Spo2 == "YES") ;
            }
        }
        [Fact]
        void GetCovid19Type_ShouldReturnDevicesOfCovid19Type()
        {
            var resultList = _filterMonitoringDevice.GetCovid19Type();
            foreach (var device in resultList)
            {
                Assert.True(device.Respiration == "YES" && device.BloodPressure == "YES");
            }
        }
        [Fact]
        void GetHighBPType_ShouldReturnDevicesOfHighBPType()
        {
            var resultList = _filterMonitoringDevice.GetHighBpType();
            foreach (var device in resultList)
            {
                Assert.True(device.BloodPressure == "YES");
            }
        }
        [Fact]
        void GetNoOfMeasurementsType_ShouldReturnDevicesGivenThatNoOfMeasurementsType()
        {
            string numberOfWaves = "3";
            var resultList = _filterMonitoringDevice.GetNumberofMeasurmentParams(numberOfWaves);
            foreach (var device in resultList)
            {
                Assert.True(device.NumberOfMeasurementWaves == numberOfWaves);
            }
        }
        [Fact]
        void GetBatteryLifeType_ShouldReturnDevicesWithGivenBatteryLifeType()
        {
            string batteryLife = "4";
            var resultList = _filterMonitoringDevice.GetBatteryLifeType(batteryLife);
            foreach (var device in resultList)
            {
                Assert.True(device.BatteryLife == batteryLife);
            }
        }
        [Fact]
        void GetMobileOrStaticType_ShouldReturnDevicesOfMobileOrStaticType()
        {
            string value = "MOBILE";
            var resultList = _filterMonitoringDevice.GetMobileorStaticType(value);
            foreach (var device in resultList)
            {
                Assert.True(device.MobileOrStatic == value);
            }
        }
        [Fact]
        void GetAdvancedFeaturesType_ReturnsDevicesHavingAdvancedFeaturesType()
        {
            var resultList = _filterMonitoringDevice.GetAdvancedFeaturesType();
            foreach (var device in resultList)
            {
                Assert.True(device.PatientLocation == "YES" && device.AntiMicrobialGlass == "YES");
            }
        }
        [Fact]
        void GetDisplayType_ShouldReturndevicesWithSpecifiedScreeSizeOrOrientation()
        {
            string displaySize = "12.1 in";
            var resultList = _filterMonitoringDevice.GetDisplay(displaySize);
            foreach (var device in resultList)
            {
                Assert.True(device.Size == displaySize || device.SupportedScreenOrientations == "YES");
            }
        }
        [Fact]
        void GetAlarmingType_ShouldReturnDevicesThatCanSoundAnAlarm()
        {
          
            var resultList = _filterMonitoringDevice.GetAlaramingType();
            foreach (var device in resultList)
            {
                Assert.True(device.PhysiologicalAlarming == "YES");
            }
        }
    }
}
