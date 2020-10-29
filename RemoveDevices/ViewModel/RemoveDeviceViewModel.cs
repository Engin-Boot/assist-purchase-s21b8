using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace RemoveDevices.ViewModel
{
    public class RemoveDeviceViewModel : INotifyPropertyChanged
    {
        ClientRequests clientRequests;
        public ICommand DeleteCommand { get; set; }
        public RemoveDeviceViewModel()
        {
            DeleteCommand = new DelegateCommand(Execute_DeleteCommand, CanExecute_DeleteCommand);
            //PopoulateModelNames();
        }

        private bool CanExecute_DeleteCommand(object arg)
        {
            return true;
        }

        private void Execute_DeleteCommand(object obj)
        {
            string uri = "api/productcategory/" + DeviceTypeSelected;
            clientRequests = new ClientRequests();
            clientRequests.ProductDeleteRequest(uri);
            MessageBox.Show("Device Deleted Successfuly");
            //clientRequests
            //throw new NotImplementedException();
        }

        List<string> deviceType;
        public List<String> DeviceType
        {
            get
            {
                PopoulateModelNames();
                return modelName;
                // return new List<string>() { "Cardic", "Pnemonia", "Covid19", "HighBp" }; 
            }
            set
            {
                deviceType = value;
                OnPropertyChanged("DeviceType");

            }
        }

        private String deviceTypeSelected;
        public String DeviceTypeSelected
        {
            get { return this.deviceTypeSelected; }
            set
            {
                deviceTypeSelected = value;
                OnPropertyChanged("DeviceTypeSelected");
            }

        }
        List<string> modelName = new List<string>();
        public void PopoulateModelNames()
        {
            clientRequests = new ClientRequests();
            var Models = clientRequests.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var Names in Models)
            {
                modelName.Add(Names.DeviceName1);
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
