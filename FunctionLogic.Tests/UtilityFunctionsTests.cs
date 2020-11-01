using System.Collections.Generic;
using AssistPurchaseData;
using Services;
using Xunit;


namespace FunctionLogic.Tests
{
    public class UtilityFunctionsTests
    {
        private readonly UtilityFunctions _utility = new UtilityFunctions();
       // private readonly EmailService _emailService = new EmailService();
        private readonly MonitoringDevice _dummDevice = new MonitoringDevice()
        {
            DeviceName = "IntelliVue v3",
            Ecg = "YES",
            Spo2 = "YES",
            Respiration = "YES",
            Hr = "YES",
            PhysiologicalAlarming = "NO",
            BloodPressure = "NO",
            BatteryLife = "5 in",
            SupportedScreenOrientations = "0° / 90° / 180°",
            Size = "249 x 97 x 111 mm",
            MobileOrStatic = "STATIC",
            AntiMicrobialGlass = "YES",
            PatientLocation = "NO"
        };
        [Fact]
        public void AddDevice_ShouldAddNewDevice()
        {
            _utility.AddDevice(_dummDevice);
            List<MonitoringDevice> deviceList = _utility.MonitoringDevices;
            var indexOfLastDevice =deviceList.Count - 1;
            Assert.True(deviceList[indexOfLastDevice].DeviceName == _dummDevice.DeviceName);
            //_utility.RemoveDevice(_dummDevice.DeviceName);
        }
        [Fact]
        public void ReadDevice_ShouldReadADeviceWhenDeviceNameIsGiven()
        {
            _utility.AddDevice(_dummDevice);
            MonitoringDevice foundDevice = _utility.ReadDevice("IntelliVue v3");
            Assert.True(foundDevice.DeviceName == _dummDevice.DeviceName);
            //_utility.RemoveDevice(_dummDevice.DeviceName);
        }

        [Fact]
        public void GetList_ShouldReturnListOfAllDevices()
        {
            _utility.AddDevice(_dummDevice);
            var allDeviceList = _utility.GetList();
            Assert.True(allDeviceList.Count>0);
            //_utility.RemoveDevice(_dummDevice.DeviceName);
        }

        [Fact]
        public void ReadFromXml_ShouldReadFromXmlFileAndReturnAListOfObjects()
        {
            _utility.AddDevice(_dummDevice);
            List<MonitoringDevice> deviceList = _utility.ReadFromXml();
            Assert.True(deviceList.Count > 0);
            //_utility.RemoveDevice(_dummDevice.DeviceName);
        }

        [Fact]
        public void WriteToXml_ShouldWriteListOfDevicesToFile()
        {
            _utility.AddDevice(_dummDevice);
            var deviceList = _utility.ReadFromXml();
            Assert.True(deviceList.Count>0);
            //_utility.RemoveDevice(_dummDevice.DeviceName);
        }
        [Fact]
        public void RemoveDevice_Test()
        {
            var deviceActual=_utility.RemoveDevice(_dummDevice.DeviceName);
            Assert.NotNull(deviceActual);
        }
        [Fact]
        public void Test_EmailAlert()
        {
            var message ="Unit Tests: Email Function Test";
            var emailId = "casestudyb217@gmail.com";
            EmailService.IAlerter alerter = new EmailService.EmailAlert(emailId);
            Assert.True(alerter.Alert(message));
        }
    }
}
