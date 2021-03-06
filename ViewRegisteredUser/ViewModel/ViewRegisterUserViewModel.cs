﻿using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ViewRegisteredUser.ViewModel
{
    public class ViewRegisterUserViewModel : INotifyPropertyChanged
    {
        ClientRequests _clientRequest;
        List<UserDetails> _userDetails = new List<UserDetails>();
        readonly EmailDetails _emailDetails = new EmailDetails();
        public ICommand ViewCommand { get; set; }
        public ICommand SendEmailCommand { get; set; }
        public ICommand ClearEmailCommand { get; set; }
        public ViewRegisterUserViewModel()
        {
            ViewCommand = new DelegateCommand(Execute_ViewCommand, CanExecute_Command);
            SendEmailCommand = new DelegateCommand(Execute_SendEmailCommand, CanExecute_Command);
            ClearEmailCommand = new DelegateCommand(Execute_ClerEmailCommand, CanExecute_Command);
            PopoulateModelName();
        }

        private void Execute_ClerEmailCommand(object obj)
        {
            
            EmailType = default;
            EmailTypeSelected = default;
            EmailBody = default;
            _emailBody = default;
        }

        private void Execute_SendEmailCommand(object obj)
        {
            
            _emailDetails.EmailId = EmailTypeSelected;
            _emailDetails.Message = EmailBody;
            _clientRequest.EmailAlert("api/AlertUser/OrderConfirmation", _emailDetails);
            //throw new NotImplementedException();
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
        private void PopoulateModelName()
        {
            _clientRequest = new ClientRequests();
            DeviceType = new ObservableCollection<string>();
            var model = _clientRequest.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var name in model)
            {
                DeviceType.Add(name.DeviceName);
            }
            DeviceType.Add("Request to contact Philips person");
        }
       readonly List<string> _devices = new List<string>();
        private void PopoulateModels()
        {
            string uri = "api/productcategory/GetDevices";
            _clientRequest = new ClientRequests();
            var models = _clientRequest.ProductGetRequest(uri);
            foreach (var model in models)
            {
                _devices.Add(model.DeviceName);
            }
        }
        //List<string> emails = new List<string>();

        private void PopulateEmailIds()
        {
            _clientRequest = new ClientRequests();
            EmailType = new ObservableCollection<string>();
            var users = _clientRequest.UserGetRequest("api/AlertUser/GetUserDetail/" + EmailDeviceTypeSelected);
            if (users == null)
            {
            }
            else
            {
                foreach (var details in users)
                {
                    EmailType.Add(details.Email);
                }

                // return true;
            }
        }

        private ObservableCollection<string> _deviceType;
        public ObservableCollection<String> DeviceType
        {
            get { return _deviceType; }
            set
            {
                _deviceType = value;
                OnPropertyChanged("DeviceType");

            }
        }

        private List<string> _emailDeviceType;
        public List<string> EmailDeviceType
        {
            get
            {
                PopoulateModels();
                _devices.Add("Request to contact Philips person");
                _emailDeviceType = _devices;
                return _emailDeviceType;
            }
            set
            {
                _emailDeviceType = value;
                OnPropertyChanged("EmailDeviceType");

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

        private String _emaildeviceTypeSelected;
        public String EmailDeviceTypeSelected
        {
            get { return this._emaildeviceTypeSelected; }
            
            set
            {
                _emaildeviceTypeSelected = value;
                OnPropertyChanged("EmailDeviceTypeSelected");
                PopulateEmailIds();
            }

        }

        private String _displayArea;
        public String DisplayArea
        {
            get { return this._displayArea; }
            
            set
            {
                _displayArea = value;
                OnPropertyChanged("DisplayArea");
            }
        }

        //public ObservableCollection<string> EmailType {​​​​​​ get; set; }​​​​​​ = new ObservableCollection<string>();

        private ObservableCollection<string> _emailType;
        public ObservableCollection<string> EmailType
        {
            get { return _emailType; }
            
            set
            {
                _emailType = value;
                OnPropertyChanged("EmailType");

            }
        }

        private String _emailTypeSelected;
        public String EmailTypeSelected
        {
            get { return this._emailTypeSelected; }
            
            set
            {
                _emailTypeSelected = value;
                OnPropertyChanged("EmailTypeSelected");
            }

        }
        private String _emailBody;
        public String EmailBody
        {
            get { return this._emailBody; }
           
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
