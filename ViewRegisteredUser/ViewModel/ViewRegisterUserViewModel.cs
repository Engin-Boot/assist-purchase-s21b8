using AssetToPurchaseFrontend.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetToPurchaseFrontend.Model;

namespace ViewRegisteredUser.ViewModel
{
    public class ViewRegisterUserViewModel :INotifyPropertyChanged
    {
        ClientRequests clientRequests;
        List<UserDetails> userDetails = new List<UserDetails>();
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
            DisplayArea = "";
            string uri = "api/AlertUser/GetUserDetail/" + DeviceTypeSelected;
            userDetails=clientRequests.UserGetRequest(uri);
            foreach (var users in userDetails)
            {
                DisplayArea += "\nUser Name:" + users.UserName + "\n User Requested/Booked Model:" + users.ProductsBooked + "\nUser Contact Number:" + users.UserContactNo;
            }
            //throw new NotImplementedException();
        }
        List<string> modelName = new List<string>();
        public void PopoulateModelNames()
        {
            clientRequests = new ClientRequests();
            var Models = clientRequests.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var Names in Models)
            {
                modelName.Add(Names.DeviceName);
            }
        }
        List<string> deviceType;
        public List<String> DeviceType
        {
            get 
            {
                PopoulateModelNames();
                modelName.Add("Request to contact Philips person");
                return modelName; 
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

        private String displayArea;
        public String DisplayArea
        {
            get { return this.displayArea; }
            set 
            {
                displayArea = value;
                OnPropertyChanged("DisplayArea");
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
