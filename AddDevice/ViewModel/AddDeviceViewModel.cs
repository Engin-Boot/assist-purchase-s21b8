using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace AddDevice.ViewModel
{
    public class AddDeviceViewModel : INotifyPropertyChanged
    {
        ClientRequests clientRequests;
        public ICommand addCommand
        {
            get; set;
        }
        public ICommand clearCommand
        {
            get; set;
        }
        public AddDeviceViewModel()
        {
            addCommand = new DelegateCommand(Execute_Add, CanExecute);
            clearCommand = new DelegateCommand(Execute_Clear, CanExecute);
        }

        private bool CanExecute(object arg)
        {
            return true;
        }
        private void Execute_Clear(object obj)
        {
            ProductName = "";
            EcgSelected = default;
            Spo2Selected = default;
            RespSelected = default;
            HrSelected = default;
            PhysiologicalAlarmingSelected = default;
            BloodPressureSelected = default;
            BatteryLife = default;
            ScreenOrientationTypeSelected = default;
            SizeSelected = default;
            MobileOrStaticSelected = default;
            AntiMicrobalGlassSelected = default;
            PatientLocationSelected = default;
        }
        private void Execute_Add(object obj)
        {
            clientRequests = new ClientRequests();
            MonitoringDevice newDevice = new MonitoringDevice();
            newDevice.DeviceName1 = ProductName;
            newDevice.Ecg1 = EcgSelected;
            newDevice.Spo21 = Spo2Selected;
            newDevice.Respiration1 = RespSelected;
            newDevice.Hr1 = HrSelected;
            newDevice.PhysiologicalAlarming1 = PhysiologicalAlarmingSelected;
            newDevice.BloodPressure1 = BloodPressureSelected;
            newDevice.BatteryLife1 = BatteryLife;
            newDevice.SupportedScreenOrientations1 = ScreenOrientationTypeSelected;
            newDevice.Size1 = SizeSelected;
            newDevice.MobileOrStatic1 = MobileOrStaticSelected;
            newDevice.AntiMicrobialGlass1 = AntiMicrobalGlassSelected;
            newDevice.PatientLocation1 = PatientLocationSelected;
            clientRequests.ProductPostRequest("api/productcategory/PostDevice", newDevice);
            MessageBox.Show(newDevice.ToString());
            //throw new NotImplementedException();
        }

        //List<string> productType;
        //public List<String> ProductType
        //{
        //    get { return new List<string>() { "Cardic", "Pnemonia", "Covid19", "HighBp" }; }
        //    set
        //    {
        //        productType = value;
        //        OnPropertyChanged("ProductType");

        //    }
        //}

        private String productName;
        public String ProductName
        {
            get { return this.productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }

        }

        string batteryLife;
        public string BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                batteryLife = value;
                OnPropertyChanged("BatteryLife");

            }
        }

        private String batteryLifeTypeSelected;
        public String BatteryLifeTypeSelected
        {
            get { return this.batteryLifeTypeSelected; }
            set
            {
                batteryLifeTypeSelected = value;
                OnPropertyChanged("BatteryLifeTypeSelected");
            }

        }

        List<string> screenOrientation;
        public List<String> ScreenOrientation
        {
            get { return new List<string>() { "YES", "NO", "NULL" }; }
            set
            {
                screenOrientation = value;
                OnPropertyChanged("ScreenOrientation");

            }
        }

        private String screenOrientationTypeSelected;
        public String ScreenOrientationTypeSelected
        {
            get { return this.screenOrientationTypeSelected; }
            set
            {
                screenOrientationTypeSelected = value;
                OnPropertyChanged("ScreenOrientationTypeSelected");
            }

        }

        List<string> size;
        public List<String> Size
        {
            get { return new List<string>() { "Null", "249 x 97 x 111 mm", "12 in", "15 in", "12.1 in" }; }
            set
            {
                size = value;
                OnPropertyChanged("Szie");

            }
        }

        private String sizeSelected;
        public String SizeSelected
        {
            get { return this.sizeSelected; }
            set
            {
                sizeSelected = value;
                OnPropertyChanged("SizeSelected");
            }

        }

        List<string> mobileOrStatic;
        public List<String> MobileOrStatic
        {
            get { return new List<string>() { "MOBILE", "STATIC" }; }
            set
            {
                mobileOrStatic = value;
                OnPropertyChanged("MobileOrStatic");

            }
        }

        private String mobileOrStaticSelected;
        public String MobileOrStaticSelected
        {
            get { return this.mobileOrStaticSelected; }
            set
            {
                mobileOrStaticSelected = value;
                OnPropertyChanged("MobileOrStaticSelected");
            }

        }

        List<string> antiMicrobalGlass;
        public List<String> AntiMicrobalGlass
        {
            get { return new List<string>() { "YES", "NO", "NULL" }; }
            set
            {
                antiMicrobalGlass = value;
                OnPropertyChanged(" AntiMicrobalGlass");

            }
        }

        private String antiMicrobalGlassSelected;
        public String AntiMicrobalGlassSelected
        {
            get { return this.antiMicrobalGlassSelected; }
            set
            {
                antiMicrobalGlassSelected = value;
                OnPropertyChanged("AntiMicrobalGlassSelected");
            }

        }

        List<string> patientLocation;
        public List<String> PatientLocation
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                patientLocation = value;
                OnPropertyChanged(" PatientLocation");

            }
        }

        private String patientLocationSelected;
        public String PatientLocationSelected
        {
            get { return this.patientLocationSelected; }
            set
            {
                patientLocationSelected = value;
                OnPropertyChanged(" PatientLocationSelected");
            }

        }

        List<string> ecg;
        public List<String> Ecg
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                ecg = value;
                OnPropertyChanged(" Ecg");

            }
        }

        private String ecgSelected;
        public String EcgSelected
        {
            get { return this.ecgSelected; }
            set
            {
                ecgSelected = value;
                OnPropertyChanged(" EcgSelected");
            }

        }


        List<string> spo2;
        public List<String> Spo2
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                spo2 = value;
                OnPropertyChanged("Spo2");

            }
        }

        private String spo2Selected;
        public String Spo2Selected
        {
            get { return this.spo2Selected; }
            set
            {
                spo2Selected = value;
                OnPropertyChanged(" spo2Selected");
            }

        }
        List<string> resp;
        public List<String> Resp
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                resp = value;
                OnPropertyChanged("Resp");

            }
        }

        private String respSelected;
        public String RespSelected
        {
            get { return this.respSelected; }
            set
            {
                respSelected = value;
                OnPropertyChanged(" RespSelected");
            }

        }

        List<string> hr;
        public List<String> Hr
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                hr = value;
                OnPropertyChanged("Hr");

            }
        }

        private String hrSelected;
        public String HrSelected
        {
            get { return this.hrSelected; }
            set
            {
                hrSelected = value;
                OnPropertyChanged(" HrSelected");
            }

        }

        List<string> physiologicalAlarming;
        public List<String> PhysiologicalAlarming
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                physiologicalAlarming = value;
                OnPropertyChanged(" PhysiologicalAlarming");

            }
        }

        private String physiologicalAlarmingSelected;
        public String PhysiologicalAlarmingSelected
        {
            get { return this.physiologicalAlarmingSelected; }
            set
            {
                physiologicalAlarmingSelected = value;
                OnPropertyChanged("  physiologicalAlarmingSelected");
            }

        }

        List<string> bloodPressure;
        public List<String> BloodPressure
        {
            get { return new List<string>() { "YES", "NO" }; }
            set
            {
                bloodPressure = value;
                OnPropertyChanged(" BloodPressure");

            }
        }

        private String bloodPressureSelected;
        public String BloodPressureSelected
        {
            get { return this.bloodPressureSelected; }
            set
            {
                bloodPressureSelected = value;
                OnPropertyChanged("  BloodPressureSelected");
            }

        }


        #region OnpropertChanged    
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
