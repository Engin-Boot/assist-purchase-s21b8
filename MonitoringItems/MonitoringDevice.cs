using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringItems
{
    public class MonitoringDevice
    {
        public string DeviceName { get; set; }
        // Clinical Requirements
        public string ECG { get; set; }
        public string SPO2 { get; set; }
        public string Respiration { get; set; }
        public string NumberOfMeasurementWaves { get; set; }
        public string HR { get; set; } // is it HeatRate?
        public string PhysiologicalAlarming { get; set; }
        public string BloodPressure { get; set; }
        public string ST { get; set; }
        public string QT { get; set; }



        // Physical Requirements

        public string BatteryLife { get; set; }
        public string SupportedScreenOrientations { get; set; }
        public string Size { get; set; }
        public string MobileOrStatic { get; set; }
        public string AntiMicrobialGlass { get; set; }
        public string PatientLocation { get; set; }

    }
}
