using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistPurchaseBackend.Database
{
    public class DevicesList
    {
        
       public void GetItems()
        {
            List<MonitoringDevice> monitoringItems = new List<MonitoringDevice>();
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue X3",
                ECG = "YES",
                SPO2="YES",
                Respiration="YES",
                NumberOfMeasurementWaves="5",
                HR="YES",
                PhysiologicalAlarming="NO",
                BloodPressure="NO",
                ST="NO",
                QT="NO",
                BatteryLife="5",
                SupportedScreenOrientations= "0° / 90° / 180°",
                Size= "249 x 97 x 111 mm",
                MobileOrStatic="STATIC",
                AntiMicrobialGlass="YES",
                PatientLocation="NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX40",
                ECG = "YES",
                SPO2 = "YES",
                Respiration = "YES",
                NumberOfMeasurementWaves = "5",
                HR = "YES",
                PhysiologicalAlarming = "YES",
                BloodPressure = "NO",
                ST = "YES",
                QT = "YES",
                BatteryLife = "9",
                SupportedScreenOrientations = "NO",
                Size = "NULL",
                MobileOrStatic = "MOBILE",
                AntiMicrobialGlass = "NO",
                PatientLocation = "YES"

            });




        }
    }
}
