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
                BatteryLife="5 in",
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
                BatteryLife = "9 in",
                SupportedScreenOrientations = "NO",
                Size = "NULL",
                MobileOrStatic = "MOBILE",
                AntiMicrobialGlass = "NO",
                PatientLocation = "YES"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX750",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "9 in",
                NumberOfMeasurementWaves = "12",
                PhysiologicalAlarming = "YES",
                BloodPressure = "YES",
                ST = "NO",
                QT = "NO",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP2",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "NO",
                MobileOrStatic = "MOBILE",
                Size = "NULL",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                ST = "NO",
                QT = "NO",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP5",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "NULL",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                ST = "YES",
                QT = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX450",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "12 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                ST = "NO",
                QT = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX700",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "15 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "YES",
                BloodPressure = "NO",
                ST = "NO",
                QT = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MMS X2",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "3.5 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                ST = "YES",
                QT = "NO",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX500",
                ECG = "YES",
                SPO2 = "YES",
                HR = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "12 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                ST = "NO",
                QT = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX400",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "9 in",
                NumberOfMeasurementWaves = "0",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                ST = "YES",
                QT = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "YES"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX550",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "15 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                ST = "YES",
                QT = "YES",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP90",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "15 in",
                NumberOfMeasurementWaves = "13",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX800",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "13 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP5T",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "8.4 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX100",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "6.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "0° / 90° / 180°",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "Efficia CM Series",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "10.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "0° / 90° / 180°",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
            monitoringItems.Add(new MonitoringDevice
            {
                DeviceName = "Goldway G40E G40E",
                ECG = "YES",
                SPO2 = "YES",
                HR = "YES",
                ST = "YES",
                QT = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "12.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
        }
    }
}
