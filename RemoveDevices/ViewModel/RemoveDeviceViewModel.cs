using AssetToPurchaseFrontend.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RemoveDevices.ViewModel
{
    public class RemoveDeviceViewModel :INotifyPropertyChanged
    {
        public ICommand DeleteCommand { get; set; }
        public RemoveDeviceViewModel()
        {
            DeleteCommand = new DelegateCommand(Execute_DeleteCommand, CanExecute_DeleteCommand);
        }

        private bool CanExecute_DeleteCommand(object arg)
        {
            return true;
        }

        private void Execute_DeleteCommand(object obj)
        {
            throw new NotImplementedException();
        }

        List<string> deviceType;
        public List<String> DeviceType
        {
            get { return new List<string>() { "Cardic", "Pnemonia", "Covid19", "HighBp" }; }
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
