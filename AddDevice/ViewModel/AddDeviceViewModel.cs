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
        ClientRequests _clientRequests;
        public ICommand AddCommand
        {
            get; set;
        }
        public ICommand ClearCommand
        {
            get; set;
        }
        public AddDeviceViewModel()
        {
            AddCommand = new DelegateCommand(Execute_Add, CanExecute);
            ClearCommand = new DelegateCommand(Execute_Clear, CanExecute);
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
            _clientRequests = new ClientRequests();
            MonitoringDevice newDevice = new MonitoringDevice();
            newDevice.DeviceName = ProductName;
            newDevice.Ecg = EcgSelected;
            newDevice.Spo2 = Spo2Selected;
            newDevice.Respiration = RespSelected;
            newDevice.Hr = HrSelected;
            newDevice.PhysiologicalAlarming = PhysiologicalAlarmingSelected;
            newDevice.BloodPressure = BloodPressureSelected;
            newDevice.BatteryLife = BatteryLife;
            newDevice.SupportedScreenOrientations = ScreenOrientationTypeSelected;
            newDevice.Size = SizeSelected;
            newDevice.MobileOrStatic = MobileOrStaticSelected;
            newDevice.AntiMicrobialGlass = AntiMicrobalGlassSelected;
            newDevice.PatientLocation = PatientLocationSelected;
            _clientRequests.ProductPostRequest("api/productcategory/PostDevice", newDevice);
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

        private String _productName;
        public String ProductName
        {
            get { return this._productName; }
           
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }

        }

        private string _batteryLife;
        public string BatteryLife
        {
            get { return this._batteryLife; }
            
            set
            {
                _batteryLife = value;
                OnPropertyChanged("BatteryLife");

            }
        }

       

        private  List<string> _screenOrientation= new List<string>() { "YES", "NO", "NULL" };
        public List<String> ScreenOrientation
        {
            get
            {
                return _screenOrientation;
            }
            set
            {
                _screenOrientation = value;
                OnPropertyChanged("ScreenOrientation");

            }
        }

        private String _screenOrientationTypeSelected;
        public String ScreenOrientationTypeSelected
        {
            get
            { 
                return this._screenOrientationTypeSelected;
            }
            set
            {
                _screenOrientationTypeSelected = value;
                OnPropertyChanged("ScreenOrientationTypeSelected");
            }

        }

       private List<string> _size= new List<string>() { "Null", "249 x 97 x 111 mm", "12 in", "15 in", "12.1 in" };
        public List<String> Size
        {
            get 
            {
                return _size;
            }
            set
            {
                _size = value;
                OnPropertyChanged("Szie");

            }
        }

        private  String _sizeSelected;
        public String SizeSelected
        {
            get 
            { 
                return this._sizeSelected;
            }
            set
            {
                _sizeSelected = value;
                OnPropertyChanged("SizeSelected");
            }

        }

       private List<string> _mobileOrStatic= new List<string>() { "MOBILE", "STATIC" };
        public List<String> MobileOrStatic
        {
            get
            {
                return _mobileOrStatic;
            }
            set
            {
                _mobileOrStatic = value;
                OnPropertyChanged("MobileOrStatic");

            }
        }

        private String _mobileOrStaticSelected;
        public String MobileOrStaticSelected
        {
            get
            { 
                return this._mobileOrStaticSelected;
            }
            set
            {
                _mobileOrStaticSelected = value;
                OnPropertyChanged("MobileOrStaticSelected");
            }

        }

        List<string> _antiMicrobalGlass= new List<string>() { "YES", "NO", "NULL" };
        public List<String> AntiMicrobalGlass
        {
            get
            {
                return _antiMicrobalGlass;
            }
            set
            {
                _antiMicrobalGlass = value;
                OnPropertyChanged(" AntiMicrobalGlass");

            }
        }

        private String _antiMicrobalGlassSelected;
        public String AntiMicrobalGlassSelected
        {
            get
            { 
                return this._antiMicrobalGlassSelected; 
            }
            set
            {
                _antiMicrobalGlassSelected = value;
                OnPropertyChanged("AntiMicrobalGlassSelected");
            }

        }

       private List<string> _patientLocation= new List<string>() { "YES", "NO" };
        public List<String> PatientLocation
        {
            get
            {
                return _patientLocation;
            }
            set
            {
                _patientLocation = value;
                OnPropertyChanged(" PatientLocation");

            }
        }

        private String _patientLocationSelected;
        public String PatientLocationSelected
        {
            get 
            {
                return this._patientLocationSelected;
            }
            set
            {
                _patientLocationSelected = value;
                OnPropertyChanged(" PatientLocationSelected");
            }

        }

       private List<string> _ecg= new List<string>() { "YES", "NO" }; 
        public List<String> Ecg
        {
            get 
            {
                return _ecg;
            }
            set
            {
                _ecg = value;
                OnPropertyChanged(" Ecg");

            }
        }

        private String _ecgSelected;
        public String EcgSelected
        {
            get
            { 
                return this._ecgSelected;
            }
            set
            {
                _ecgSelected = value;
                OnPropertyChanged(" EcgSelected");
            }

        }


        List<string> _spo2= new List<string>() { "YES", "NO" };
        public List<String> Spo2
        {
            get
            {
                return _spo2;
            }
            set
            {
                _spo2 = value;
                OnPropertyChanged("Spo2");

            }
        }

        private String _spo2Selected;
        public String Spo2Selected
        {
            get
            { 
                return this._spo2Selected; 
            }
            set
            {
                _spo2Selected = value;
                OnPropertyChanged(" spo2Selected");
            }

        }
        List<string> _resp= new List<string>() { "YES", "NO" }; 
        public List<String> Resp
        {
            get
            {
                return _resp;
            }
            set
            {
                _resp = value;
                OnPropertyChanged("Resp");

            }
        }

        private String _respSelected;
        public String RespSelected
        {
            get 
            {
                return this._respSelected;
            }
            set
            {
                _respSelected = value;
                OnPropertyChanged(" RespSelected");
            }

        }

        private List<string> _hr= new List<string>() { "YES", "NO" };
        public List<String> Hr
        {
            get
            {
                return _hr;
            }
            set
            {
                _hr = value;
                OnPropertyChanged("Hr");

            }
        }

        private String _hrSelected;
        public String HrSelected
        {
            get
            { 
                return this._hrSelected;
            }
            set
            {
                _hrSelected = value;
                OnPropertyChanged(" HrSelected");
            }

        }

        List<string> _physiologicalAlarming= new List<string>() { "YES", "NO" };
        public List<String> PhysiologicalAlarming
        {
            get
            {
                return _physiologicalAlarming;
            }
            set
            {
                _physiologicalAlarming = value;
                OnPropertyChanged(" PhysiologicalAlarming");

            }
        }

        private String _physiologicalAlarmingSelected;
        public String PhysiologicalAlarmingSelected
        {
            get
            { 
                return this._physiologicalAlarmingSelected; 
            }
            set
            {
                _physiologicalAlarmingSelected = value;
                OnPropertyChanged("  physiologicalAlarmingSelected");
            }

        }

        List<string> _bloodPressure= new List<string>() { "YES", "NO" };
        public List<String> BloodPressure
        {
            get
            {
                return _bloodPressure;
            }
            set
            {
                _bloodPressure = value;
                OnPropertyChanged(" BloodPressure");

            }
        }

        private String _bloodPressureSelected;
        public String BloodPressureSelected
        {
            get
            {
                return this._bloodPressureSelected;
            }
            set
            {
                _bloodPressureSelected = value;
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
