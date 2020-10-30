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
        ClientRequests _clientRequest;
       List<UserDetails> _userDetails = new List<UserDetails>();
        public ICommand ViewCommand { get; set; }
        public ICommand SendEmailCommand { get; set; }
        public ICommand ClearEmailCommand { get; set; }
        public ViewRegisterUserViewModel()
        {
            ViewCommand = new DelegateCommand(Execute_ViewCommand, CanExecute_Command);
            SendEmailCommand = new DelegateCommand(Execute_SendEmailCommand, CanExecute_Command);
            ClearEmailCommand = new DelegateCommand(Execute_ClerEmailCommand, CanExecute_Command);

        }

        private void Execute_ClerEmailCommand(object obj)
        {
            _emailType = default;
            EmailType = default;
            EmailTypeSelected = default;
            EmailBody = default;
            _emailBody = default;
        }

        private void Execute_SendEmailCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanExecute_Command(object arg)
        {
            return true;
        }

        private void Execute_ViewCommand(object obj)
        {
            DisplayArea = "";
            string uri = "api/AlertUser/GetUserDetail/" + DeviceTypeSelected;
            _userDetails = _clientRequest.UserGetRequest(uri);
            foreach (var users in _userDetails)
            {
                DisplayArea += "\nUser Name:" + users.UserName + "\n User Requested/Booked Model:" + users.Email + "\n User Requested/Booked Model:" + users.ProductsBooked + "\nUser Contact Number:" + users.UserContactNo;
            }
            //throw new NotImplementedException();
        }
        readonly List<string> modelNames = new List<string>();
        private void PopoulateModelName()
        {
            _clientRequest = new ClientRequests();
            var model = _clientRequest.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var name in model)
            {
                modelNames.Add(name.DeviceName);
            }
        }


       
        List<string> _deviceType;
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
                _deviceType = value;
                OnPropertyChanged("DeviceType");

            }
        }

        private String _deviceTypeSelected;
        public String DeviceTypeSelected
        {
            get
            {
                return this._deviceTypeSelected;
            }
            set
            {
                _deviceTypeSelected = value;
                OnPropertyChanged("DeviceTypeSelected");
            }

        }

        private String _displayArea;
        public String DisplayArea
        {
            get
            {
                return this._displayArea;
            }
            set
            {
                _displayArea = value;
                OnPropertyChanged("DisplayArea");
            }
        }

       private List<string> _emailType;
        public List<String> EmailType
        {
            get
            { 
                return _emailType; ;
            }
            set
            {
                _emailType = value;
                OnPropertyChanged("EmailType");

            }
        }

        private String _emailTypeSelected;
        public String EmailTypeSelected
        {
            get
            {
                return this._emailTypeSelected;
            }
            set
            {
                _emailTypeSelected = value;
                OnPropertyChanged("EmailTypeSelected");
            }

        }
        private String _emailBody;
        public String EmailBody
        {
            get
            {
                return this._emailBody;
            }
            set
            {
                _emailBody = value;
                OnPropertyChanged("EmailBody");
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
