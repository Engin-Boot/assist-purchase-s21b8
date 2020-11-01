using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AssetToPurchaseFrontend.ViewModel
{
    public class AssetToPurchaseviewModel : INotifyPropertyChanged
    {
        #region data member
        private string _name;
        private string _email;
        private ObservableCollection<String> _modelType;
        private int _contactNumber;
        private string _yourMessage;
        private string _chatArea = "Say 'Hi' to start the chat";
        int _count = 0;
        static StringBuilder _sb = new StringBuilder();
        readonly StringBuilder _temp = new StringBuilder();
        ClientRequests _clientRequests = new ClientRequests();
        List<MonitoringDevice> _devices = new List<MonitoringDevice>();
       // List<UserDetails> _userDetails = new List<UserDetails>();
        #endregion
        public ICommand ClearCommandRegistration { get; set; }
        #region Constructor
        public AssetToPurchaseviewModel()
        {
            RegisterAndOrderingCommand = new DelegateCommand(Execute_RegisterAndOrdering, CanExecute_Mehod);
            ClearCommand = new DelegateCommand(Execute_ClearCoomand, CanExecute_Mehod);
            SendCommand = new DelegateCommand(Execute_SendCommand, CanExecute_Mehod);
            ClearCommandRegistration = new DelegateCommand(Execute_ClearCommandRegistration, CanExecute_Mehod);
            PopoulateModelNames();
        }

        private void Execute_ClearCommandRegistration(object obj)
        {
            Name = "";
            Email = "";
            ContactNumber = default;
            
        }
        #endregion

        int _choice = 1;
        bool _clinicallock;
        int _clinicalrequirementChoice = default;
        // string url;
        bool _clinicalMenuDisplay, _screenOrientationMenu, _microbialGlassMenu, _patientLocationMenu, _alarmingMenu = true;
        bool _batteryMenuDisplay, _physicallock = false;
        int _physicalrequirementChoice, _batteryrequirementChoice, _patientLocationrequirementChoice, _alarmingMenurequirementChoice,
            _screenOrientationrequirementChoice, _microbialGlassrequirementChoice, _clinical, _menuchoice, _physicalchoice = default;
        #region ExecuteAndCanexecuteImplementation
        private void Execute_SendCommand(object obj)
        {
            if (_choice == 1)
            {
                StartChat();

            }

            else if (_choice == 2)
            {
                ChoiceTwoMethod();

            }
        }

        private void ChoiceTwoMethod()
        {
            if (_clinicallock == false)
            {
                _clinicalrequirementChoice = -1;
                _menuchoice = int.Parse(YourMessage);
                _clinicallock = true;
                _clinicalMenuDisplay = true;
            }
            if (_menuchoice == 1)
            {
                MenuChoice1Method();

            }
            else
                ChoiceTwoMethod2();
            //if (menuchoice == 2)
            //{
            //    MenuchoiceTwoMehod();

            //}
            //else if (menuchoice == 3)
            //{
            //    Execute_API("api/productcategory/GetDevices");
            //}
            //else
            //{
            //    sb.AppendLine("ChatBot: Please Enter Valid Input");
            //    ChatArea = sb.ToString();
            //    YourMessage = "";
            //}
        }
        private void ChoiceTwoMethod2()
        {
            if (_menuchoice == 2)
            {
                MenuchoiceTwoMehod();

            }
            else if (_menuchoice == 3)
            {
                Execute_API("api/productcategory/GetDevices");
            }
            else
            {
                _sb.AppendLine("ChatBot: Please Enter Valid Input");
                ChatArea = _sb.ToString();
                YourMessage = "";
            }
        }
        private void StartChat()
        {
            if (YourMessage.Equals("Hi") || YourMessage.Equals("hi"))
            {
                _sb.AppendLine("Chat Bot: Say 'Hi' to start the chat");
                _sb.AppendLine("User: " + YourMessage);
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Hello User Please Chat With Me For Customized Requirements");
                ChatArea = _sb.ToString();
                YourMessage = "";
                _sb.AppendLine("Chat Bot: Please choose one menu option from the below list : \n 1.Clinical Requirements \n 2.Physical Requirements Based\n 3.Display all available models");
                ChatArea = _sb.ToString();
                _choice = 2;
                _clinicallock = false;
            }
            else
            {
                _sb.AppendLine("Chat Bot: Invalid response \nSay 'Hi' to start the chat");
                ChatArea = _sb.ToString();
            }
        }

        private void MenuchoiceTwoMehod()
        {

            PhysicalrequirementChoice();

            if (_physicalrequirementChoice == 1)
            {
                PhysicalChoice();

            }
        }

        private void PhysicalChoice()
        {
            if (_physicalchoice == 1)
            {
                BatteryReqirementChoice();
            }
            else if (_physicalchoice == 2)
            {
                ScreenOrientationMenuMethod();

            }
            else
                PhysicalChoiceMethodTwo();
            //else if (physicalchoice == 4)
            //{
            //    PatientLocationrequirementChoiceMethod();

            //}
            //else if (physicalchoice == 5)
            //{
            //    PhysicalchoiceMethod();

            //}
        }
        private void PhysicalChoiceMethodTwo()
        {
            if (_physicalchoice == 3)
            {
                MicrobialGlassrequirementChoiceMethod();

            }
            else
                PhysicalChoiceMethodThree();
        }
        private void PhysicalChoiceMethodThree()
        {
            if (_physicalchoice == 4)
            {
                PatientLocationrequirementChoiceMethod();

            }
            if (_physicalchoice == 5)
            {
                PhysicalchoiceMethod();

            }
        }
        private void PatientLocationrequirementChoiceMethod()
        {
            if (_patientLocationMenu)
            {
                _sb.AppendLine(YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one option for Device Type from the below list :");
                _sb.AppendLine("1. Mobile.\n 2.Static");
                ChatArea = _sb.ToString();
                _patientLocationrequirementChoice = 0;
                _patientLocationMenu = false;
            }
            else if (_patientLocationrequirementChoice == 0)
            {
                PatientLocationrequirementChoiceMethodTwo();
            }
        }

        private void PatientLocationrequirementChoiceMethodTwo()
        {
            _sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                _sb.AppendLine("Chat Bot:You have opted for Mobile Type of Device");
                Execute_API("api/productcategory/MobileorStatic/MOBILE");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                _sb.AppendLine("Chat Bot:You have opted for Static Type of Device");
                Execute_API("api/productcategory/MobileorStatic/STATIC");
            }
            else
            {
                _sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = _sb.ToString();
                _screenOrientationMenu = true;
            }
        }

        private void MicrobialGlassrequirementChoiceMethod()
        {
            if (_microbialGlassMenu)
            {
                _sb.AppendLine(YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one option for Advanced Features(Microbial Glass + Patient Location) from the below list :");
                _sb.AppendLine("1. Required.\n 2.Not- Required");
                ChatArea = _sb.ToString();
                _microbialGlassrequirementChoice = 0;
                _microbialGlassMenu = false;
            }
            else if (_microbialGlassrequirementChoice == 0)
            {
                MicrobialGlassrequirementChoiceMethodTwo();

            }
        }

        private void MicrobialGlassrequirementChoiceMethodTwo()
        {
            _sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                _sb.AppendLine("Chat Bot:You have opted for Advanced Features(Microbial Glass + Patient Location)");
                Execute_API("api/productcategory/AdvancedFeatures/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                _sb.AppendLine("Chat Bot:You have not opted for Advanced Features(Microbial Glass + Patient Location)");
                Execute_API("api/productcategory/AdvancedFeatures/NO");
            }
            else
            {
                _sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = _sb.ToString();
                _screenOrientationMenu = true;
            }
        }

        private void ScreenOrientationMenuMethod()
        {
            if (_screenOrientationMenu)
            {
                _sb.AppendLine( YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one option for Screen Orientation from the below list :");
                _sb.AppendLine("1. Required.\n 2.Not-Required");
                ChatArea = _sb.ToString();
                _screenOrientationrequirementChoice = 0;
                _screenOrientationMenu = false;
            }
            else if (_screenOrientationrequirementChoice == 0)
            {
                ScreenOrientationrequirementChoiceMethod();

            }
        }

        private void ScreenOrientationrequirementChoiceMethod()
        {
            _sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                _sb.AppendLine("Chat Bot:You have opted for screen orientation feature");
                Execute_API("api/productcategory/Display/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                _sb.AppendLine("Chat Bot:You have not opted for screen orientation feature");
                Execute_API("api/productcategory/Display/NO");
            }
            else
            {
                _sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = _sb.ToString();
                _screenOrientationMenu = true;
            }
        }

        private void BatteryReqirementChoice()
        {

            if (_batteryMenuDisplay)
            {
                _sb.AppendLine(YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one Battery Life from the below list :");
                _sb.AppendLine("1. Battery Life > 5 and < 10.\n 2.Battery Life > 10");
                ChatArea = _sb.ToString();
                _batteryrequirementChoice = 0;
                _batteryMenuDisplay = false;
            }
            else if (_batteryrequirementChoice == 0)
            {
                BatteryReqirementChoiceMethod();

            }
        }

        private void BatteryReqirementChoiceMethod()
        {
            _sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                _sb.AppendLine("Chat Bot:You have selected requirement of battery life of > 5 years and < 10 years");
                Execute_API("api/productcategory/BatteryLife/5");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                _sb.AppendLine("Chat Bot:You have selected requirement of battery life of more than 10 years");
                Execute_API("api/productcategory/BatteryLife/10");
            }
            else
            {
                _sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct  Value");
                ChatArea = _sb.ToString();
                _batteryMenuDisplay = true;
            }
        }

        private void PhysicalrequirementChoice()
        {
            if (_physicallock == false)
            {
                _sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                _sb.AppendLine("Chat Bot: Please choose one Physical Feature from the below list : \n " +
                    "1.Battery Life \n " +
                    "2.Screen Orientation\n " +
                    "3.Advanced Features (Anti Microbial Glass+ Patient Location)\n " +
                    "4.Device Type(Mobile/Static)" +
                    "5.Alarming Feature");
                ChatArea = _sb.ToString();
                _physicalrequirementChoice = 0;
                _physicallock = true;
                _batteryMenuDisplay = true;
                _screenOrientationMenu = true;
                _microbialGlassMenu = true;
                _patientLocationMenu = true;
                _alarmingMenu = true;
            }
            else if (_physicalrequirementChoice == 0)
            {
                _sb.AppendLine("User: " + YourMessage);
                ChatArea = _sb.ToString();
                PhysicalrequirementChoiceTwo();
            }
        }
        private void PhysicalrequirementChoiceTwo()
        {
            try
            {
                _physicalchoice = int.Parse(YourMessage);
                YourMessage = "";
                _physicalrequirementChoice = 1;
            }
            catch (Exception e)
            {
                _sb.AppendLine(YourMessage);
                _sb.AppendLine("Error: Invalid Data Entered \n Stack Trace: " + e.StackTrace);
            }
        }
        private void MenuChoice1Method()
        {
            if (_clinicalMenuDisplay)
            {
                _sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one clinical requirements from below: \n 1.Cardiac " +
                    "\n2.Pnemonia " +
                    "\n3.Covid19 " +
                    "\n4.High BP");
                ChatArea = _sb.ToString();
                _clinicalrequirementChoice = default;
                _clinicalMenuDisplay = false;
            }
            else if (_clinicalrequirementChoice == 0)
            {
                _sb.AppendLine(YourMessage);
                _chatArea = _sb.ToString();
                ClinicalChoiceMethod();


            }

        }
        string _url = "";
        private void ClinicalChoiceMethod()
        {
            try
            {
                _clinical = int.Parse(YourMessage);
                YourMessage = "";
                //requirement = "";
                if (_clinical == 1)
                {
                    _url = "api/productcategory/cardiac";
                    _sb.AppendLine("Chat Bot: You have selected Cardiac as your clinical requirement");
                    Execute_API(_url);
                }
                else
                    ClinicalChoiceMethodTwo();
            }
            catch (Exception)
            {
                _sb.AppendLine("Empty String Entered: Please Input Proper Values");
                ChatArea = _sb.ToString();
            }
        }
        private void ClinicalChoiceMethodTwo()
        {
            if (_clinical == 2)
            {
                _url = "api/productcategory/Pneumonia";
                _sb.AppendLine("Chat Bot: You have selected Pneumonia as your clinical requirement");
                Execute_API(_url);
            }
            if (_clinical == 3)
            {
                _url = "api/productcategory/Covid19";
                _sb.AppendLine("Chat Bot: You have selected Covid19 as your clinical requirement");
                Execute_API(_url);
            }
            else
                ClinicalChoiceMethodThree();
        }
        private void ClinicalChoiceMethodThree()
        {
            if (_clinical == 4)
            {
                _url = "api/productcategory/HighBP";
                _sb.AppendLine("Chat Bot: You have selected HighBP as your clinical requirement");
                Execute_API(_url);
            }
            else
            {
                _sb.AppendLine("Invalid Choice");
                ChatArea = _sb.ToString();
                _clinicallock = false;
            }
        }
        private void PhysicalchoiceMethod()
        {
            if (_alarmingMenu)
            {
                _sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                ChatArea = _sb.ToString();
                _sb.AppendLine("Chat Bot: Please choose one option for Alarming Feature from the below list :");
                _sb.AppendLine("1. YES.\n 2.NO");
                ChatArea = _sb.ToString();
                _alarmingMenurequirementChoice = 0;
                _alarmingMenu = false;
            }
            else if (_alarmingMenurequirementChoice == 0)
            {
                AlarmingMenurequirementChoice();

            }

        }

        private void AlarmingMenurequirementChoice()
        {
            _sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                _sb.AppendLine("Chat Bot:You have opted for Alarming Feature");
                Execute_API("api/productcategory/Alaraming/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                _sb.AppendLine("Chat Bot:You have not opted for Alarming Feature");
                Execute_API("api/productcategory/Alaraming/NO");
            }
        }

        private void Execute_API(String url)
        {
            _devices.Clear();
            _temp.AppendLine("\nThe following result's matches to your requirement's");
            _devices = _clientRequests.ProductGetRequest(url);
            foreach (var d in _devices)
            {
                _count++;
                _temp.AppendLine("\nDevice " + _count + ": " +
                    "\nDeviceName:" + d.DeviceName +
                    "\nECG: " + d.Ecg +
                    "\nSpo2: " + d.Spo2 +
                    "\nRespiration: " + d.Respiration +
                    "\nHeart-Rate: " + d.Hr +
                    "\nPhyscological-Alarming: " + d.PhysiologicalAlarming +
                    "\nBlood-Pressure: " + d.BloodPressure +
                    "\nBattery-Life: " + d.BatteryLife +
                    "\nScreen-Orientation: " + d.SupportedScreenOrientations +
                    "\nSize: " + d.Size +
                    "\nMobile/Static: " + d.MobileOrStatic +
                    "\nAnti-Microbial Glass: " + d.AntiMicrobialGlass +
                    "\nPatient-Location: " + d.PatientLocation);
            }
            if (_count > 0)
            {
                _sb.AppendLine(_temp.ToString());
                _temp.Clear();
                ChatArea = _sb.ToString();
            }
            else
            {
                _sb.AppendLine("Could not find any devices of your preferences.\n" +
                    "Please register on our portal so that our Philips representative will contact you for more information!!");
                ChatArea = _sb.ToString();
            }
        }
        //ObservableCollection<string> modelName = new ObservableCollection<string>();
        private void PopoulateModelNames()
        {
            _clientRequests = new ClientRequests();
            ModelType = new ObservableCollection<string>();
            var models = _clientRequests.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var names in models)
            {
                ModelType.Add(names.DeviceName);
            }
            _modelType.Add("Request to contact Philips person");
            //ModelType = modelName;
        }

        private void Execute_ClearCoomand(object obj)
        {
            _sb = new StringBuilder();
            ChatArea = "Say 'Hi' to start the chat";
            _choice = 1;
            _count = 0;
            YourMessage = "";
            //throw new NotImplementedException();
        }
        private bool CanExecute_Mehod(object arg)
        {
            return true;
        }
        readonly UserDetails _user = new UserDetails();
        private void Execute_RegisterAndOrdering(object obj)
        {
            //userDetails.Add(new UserDetails { UserName = Name, ProductsBooked = modelTypeSelected, UserContactNo = ContactNumber });
            _user.UserName = Name;
            _user.Email = Email;
            _user.UserContactNo = ContactNumber;
            _user.ProductsBooked = ModelTypeSelected;
            _clientRequests.UserPostRequest("api/AlertUser/Registration", _user);
            MessageBox.Show(Name + " Registered Successfuly" + "\n Philips person will conatct you personally");
        }
        #endregion


        #region Property
        public ICommand RegisterAndOrderingCommand
        {
            get; set;
        }
        public ICommand ClearCommand
        {
            get; set;
        }
        public ICommand SendCommand
        {
            get; set;
        }
        public String Name
        {
            get { return this._name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");

            }
        }
        public String Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public ObservableCollection<String> ModelType
        {
            get
            {
                //PopoulateModelNames();
                //return new List<string>() { "Cardic", "Covid19", "Pnemonia","HighBp" ,"ContactToPhiliPsPerson"}; 
                return _modelType;
            }
            set
            {
                _modelType = value;
                OnPropertyChanged("ModelType");
            }
        }

        private String _modelTypeSelected;
        public String ModelTypeSelected
        {
            get { return this._modelTypeSelected; }
            set
            {
                _modelTypeSelected = value;
                OnPropertyChanged("ModelTypeSelected");
            }

        }
        public int ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");

            }
        }
        public String YourMessage
        {
            get { return _yourMessage; }
            set
            {
                _yourMessage = value;
                OnPropertyChanged("YourMessage");

            }
        }
        public String ChatArea
        {
            get { return this._chatArea; }
            private set
            {
                _chatArea = value;
                OnPropertyChanged("ChatArea");

            }
        }
        #endregion

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
