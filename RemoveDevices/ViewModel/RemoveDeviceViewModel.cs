using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace RemoveDevices.ViewModel
{
    public class RemoveDeviceViewModel : INotifyPropertyChanged
    {
        ClientRequests _clientRequests;
        public ICommand DeleteCommand { get; set; }
        public RemoveDeviceViewModel()
        {
            DeleteCommand = new DelegateCommand(Execute_DeleteCommand, CanExecute_DeleteCommand);
            PopoulateModelNames();
        }

        private bool CanExecute_DeleteCommand(object arg)
        {
            return true;
        }

        private void Execute_DeleteCommand(object obj)
        {
            string uri = "api/productcategory/" + DeviceTypeSelected;
            _clientRequests = new ClientRequests();
            _clientRequests.ProductDeleteRequest(uri);
            MessageBox.Show("Device Deleted Successfuly");
            //clientRequests
            //throw new NotImplementedException();
        }

        private ObservableCollection<string> _deviceType;
        public ObservableCollection<string> DeviceType
        {
            get { return _deviceType; }
            set
            {
                _deviceType = value;
                OnPropertyChanged("DeviceType");

            }
        }

        private String _deviceTypeSelected;
        public String DeviceTypeSelected
        {
            get { return this._deviceTypeSelected; }
            set
            {
                _deviceTypeSelected = value;
                OnPropertyChanged("DeviceTypeSelected");
            }

        }
       // List<string> modelName = new List<string>();
        private void PopoulateModelNames()
        {
            _clientRequests = new ClientRequests();
            DeviceType = new ObservableCollection<string>();
            var models = _clientRequests.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var names in models)
            {
                DeviceType.Add(names.DeviceName);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
