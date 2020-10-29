using System;
using System.Collections.Generic;
using System.Text;

namespace AssetToPurchaseFrontend.Model
{
    public class MonitoringDevice
    {
        public string DeviceName1 { get; set; }
        // Clinical Requirements
        public string Ecg1 { get; set; }
        public string Spo21 { get; set; }
        public string Respiration1 { get; set; }
        //public string NumberOfMeasurementWaves { get; set; }
        public string Hr1 { get; set; }
        public string PhysiologicalAlarming1 { get; set; }
        public string BloodPressure1 { get; set; }

        // Physical Requirements
        public string BatteryLife1 { get; set; }
        public string SupportedScreenOrientations1 { get; set; }
        public string Size1 { get; set; }
        public string MobileOrStatic1 { get; set; }
        public string AntiMicrobialGlass1 { get; set; }
        public string PatientLocation1 { get; set; }

    }
}
