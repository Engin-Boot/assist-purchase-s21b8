using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace ViewRegisteredUser.ViewModel
{
    public class ViewRegisterUserViewModel : INotifyPropertyChanged
    {
        ClientRequests clientRequest;
        List<UserDetails> userDetails = new List<UserDetails>();
        public ICommand ViewCommand { get; set; }
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
            userDetails = clientRequest.UserGetRequest(uri);
            foreach (var users in userDetails)
            {
                DisplayArea += "\nUser Name:" + users.UserName1 + "\n User Requested/Booked Model:" + users.ProductsBooked1 + "\nUser Contact Number:" + users.UserContactNo1;
            }
            //throw new NotImplementedException();
        }
        List<string> modelNames = new List<string>();
        public void PopoulateModelName()
        {
            clientRequest = new ClientRequests();
            var Model = clientRequest.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var Name in Model)
            {
                modelNames.Add(Name.DeviceName1);
            }
        }
        List<string> deviceType;
        public List<String> DeviceType
        {
            get
            {
                PopoulateModelName();
                modelNames.Add("Request to contact Philips person");
                return modelNames;
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
