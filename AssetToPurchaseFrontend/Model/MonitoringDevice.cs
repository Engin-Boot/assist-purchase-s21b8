using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetToPurchaseFrontend.Model
{
    public class MonitoringDevice
    {

            public string DeviceName { get; set; }
            // Clinical Requirements
            public string Ecg { get; set; }
            public string Spo2 { get; set; }
            public string Respiration { get; set; }
            //public string NumberOfMeasurementWaves { get; set; }
            public string Hr { get; set; }
            public string PhysiologicalAlarming { get; set; }
            public string BloodPressure { get; set; }


            // Physical Requirements

            public string BatteryLife { get; set; }
            public string SupportedScreenOrientations { get; set; }
            public string Size { get; set; }
            public string MobileOrStatic { get; set; }
            public string AntiMicrobialGlass { get; set; }
            public string PatientLocation { get; set; }

    }
}
