using AssetToPurchaseFrontend.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewRegisteredUser.ViewModel
{
    public class ViewRegisterUserViewModel :INotifyPropertyChanged
    {
        public ICommand     ViewCommand { get; set; }
        public ViewRegisterUserViewModel()
        {
            ViewCommand = new DelegateCommand(Execute_ViewCommand, CanExecute_ViewCommand);
        }

        private bool CanExecute_ViewCommand(object arg)
        {
            return true;
        }

        private void Execute_ViewCommand(object obj)
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
