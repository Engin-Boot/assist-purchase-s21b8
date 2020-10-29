using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AssetToPurchaseFrontend.ViewModel
{
    public class AssetToPurchaseviewModel : INotifyPropertyChanged
    {
        #region data member
        private string name;
        private string email;
        private List<String> modelType;
        private int contactNumber;
        private string yourMessage;
        private string chatArea = "Say 'Hi' to start the chat";
        int count = 0;
        static StringBuilder sb = new StringBuilder();
        StringBuilder temp = new StringBuilder();
        ClientRequests clientRequests = new ClientRequests();
        List<MonitoringDevice> devices = new List<MonitoringDevice>();
        List<UserDetails> userDetails = new List<UserDetails>();
        #endregion
        public ICommand ClearCommandRegistration { get; set; }
        #region Constructor
        public AssetToPurchaseviewModel()
        {
            RegisterAndOrderingCommand = new DelegateCommand(Execute_RegisterAndOrdering, CanExecute_Mehod);
            ClearCommand = new DelegateCommand(Execute_ClearCoomand, CanExecute_Mehod);
            SendCommand = new DelegateCommand(Execute_SendCommand, CanExecute_Mehod);
            ClearCommandRegistration = new DelegateCommand(Execute_ClearCommandRegistration, CanExecute_Mehod);
        }

        private void Execute_ClearCommandRegistration(object obj)
        {
            Name = "";
            Email = "";
            ContactNumber = default;
            ModelType = default;
        }
        #endregion

        int choice = 1;
        bool clinicallock;
        int clinicalrequirementChoice = default;
        // string url;
        bool clinicalMenuDisplay, screenOrientationMenu, microbialGlassMenu, patientLocationMenu, alarmingMenu = true;
        bool batteryMenuDisplay, physicallock = false;
        int physicalrequirementChoice, batteryrequirementChoice, patientLocationrequirementChoice, alarmingMenurequirementChoice,
            screenOrientationrequirementChoice, microbialGlassrequirementChoice, clinical, menuchoice, physicalchoice = default;
        #region ExecuteAndCanexecuteImplementation
        private void Execute_SendCommand(object obj)
        {
            if (choice == 1)
            {
                StartChat();

            }

            else if (choice == 2)
            {
                ChoiceTwoMethod();

            }
        }

        private void ChoiceTwoMethod()
        {
            if (clinicallock == false)
            {
                clinicalrequirementChoice = -1;
                menuchoice = int.Parse(YourMessage);
                clinicallock = true;
                clinicalMenuDisplay = true;
            }
            if (menuchoice == 1)
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
            if (menuchoice == 2)
            {
                MenuchoiceTwoMehod();

            }
            else if (menuchoice == 3)
            {
                Execute_API("api/productcategory/GetDevices");
            }
            else
            {
                sb.AppendLine("ChatBot: Please Enter Valid Input");
                ChatArea = sb.ToString();
                YourMessage = "";
            }
        }
        private void StartChat()
        {
            if (YourMessage.Equals("Hi") || YourMessage.Equals("hi"))
            {
                sb.AppendLine("Chat Bot: Say 'Hi' to start the chat");
                sb.AppendLine("User: " + YourMessage);
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Hello User Please Chat With Me For Customized Requirements");
                ChatArea = sb.ToString();
                YourMessage = "";
                sb.AppendLine("Chat Bot: Please choose one menu option from the below list : \n 1.Clinical Requirements \n 2.Physical Requirements Based\n 3.Display all available models");
                ChatArea = sb.ToString();
                choice = 2;
                clinicallock = false;
            }
            else
            {
                sb.AppendLine("Chat Bot: Invalid response \nSay 'Hi' to start the chat");
                ChatArea = sb.ToString();
            }
        }

        private void MenuchoiceTwoMehod()
        {

            PhysicalrequirementChoice();

            if (physicalrequirementChoice == 1)
            {
                PhysicalChoice();

            }
        }

        private void PhysicalChoice()
        {
            if (physicalchoice == 1)
            {
                BatteryReqirementChoice();
            }
            else if (physicalchoice == 2)
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
            if (physicalchoice == 3)
            {
                MicrobialGlassrequirementChoiceMethod();

            }
            else
                PhysicalChoiceMethodThree();
        }
        private void PhysicalChoiceMethodThree()
        {
            if (physicalchoice == 4)
            {
                PatientLocationrequirementChoiceMethod();

            }
            if (physicalchoice == 5)
            {
                PhysicalchoiceMethod();

            }
        }
        private void PatientLocationrequirementChoiceMethod()
        {
            if (patientLocationMenu == true)
            {
                sb.AppendLine(string.Format("{0,-10} | {1,5}", "", YourMessage));
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one option for Device Type from the below list :");
                sb.AppendLine("1. Mobile.\n 2.Static");
                ChatArea = sb.ToString();
                patientLocationrequirementChoice = 0;
                patientLocationMenu = false;
            }
            else if (patientLocationrequirementChoice == 0)
            {
                PatientLocationrequirementChoiceMethodTwo();
            }
        }

        private void PatientLocationrequirementChoiceMethodTwo()
        {
            sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                sb.AppendLine("Chat Bot:You have opted for Mobile Type of Device");
                Execute_API("api/productcategory/MobileorStatic/MOBILE");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                sb.AppendLine("Chat Bot:You have opted for Static Type of Device");
                Execute_API("api/productcategory/MobileorStatic/STATIC");
            }
            else
            {
                sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = sb.ToString();
                screenOrientationMenu = true;
            }
        }

        private void MicrobialGlassrequirementChoiceMethod()
        {
            if (microbialGlassMenu == true)
            {
                sb.AppendLine(string.Format("{0,-10} | {1,5}", "", YourMessage));
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one option for Advanced Features(Microbial Glass + Patient Location) from the below list :");
                sb.AppendLine("1. Required.\n 2.Not- Required");
                ChatArea = sb.ToString();
                microbialGlassrequirementChoice = 0;
                microbialGlassMenu = false;
            }
            else if (microbialGlassrequirementChoice == 0)
            {
                MicrobialGlassrequirementChoiceMethodTwo();

            }
        }

        private void MicrobialGlassrequirementChoiceMethodTwo()
        {
            sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                sb.AppendLine("Chat Bot:You have opted for Advanced Features(Microbial Glass + Patient Location)");
                Execute_API("api/productcategory/AdvancedFeatures/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                sb.AppendLine("Chat Bot:You have not opted for Advanced Features(Microbial Glass + Patient Location)");
                Execute_API("api/productcategory/AdvancedFeatures/NO");
            }
            else
            {
                sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = sb.ToString();
                screenOrientationMenu = true;
            }
        }

        private void ScreenOrientationMenuMethod()
        {
            if (screenOrientationMenu == true)
            {
                sb.AppendLine(string.Format("{0,-10} | {1,5}", YourMessage, 51));
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one option for Screen Orientation from the below list :");
                sb.AppendLine("1. Required.\n 2.Not-Required");
                ChatArea = sb.ToString();
                screenOrientationrequirementChoice = 0;
                screenOrientationMenu = false;
            }
            else if (screenOrientationrequirementChoice == 0)
            {
                ScreenOrientationrequirementChoiceMethod();

            }
        }

        private void ScreenOrientationrequirementChoiceMethod()
        {
            sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                sb.AppendLine("Chat Bot:You have opted for screen orientation feature");
                Execute_API("api/productcategory/Display/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                sb.AppendLine("Chat Bot:You have not opted for screen orientation feature");
                Execute_API("api/productcategory/Display/NO");
            }
            else
            {
                sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                ChatArea = sb.ToString();
                screenOrientationMenu = true;
            }
        }

        private void BatteryReqirementChoice()
        {

            if (batteryMenuDisplay == true)
            {
                sb.AppendLine(string.Format("{0,-10} | {1,5}", YourMessage, 51));
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one Battery Life from the below list :");
                sb.AppendLine("1. Battery Life > 5 and < 10.\n 2.Battery Life > 10");
                ChatArea = sb.ToString();
                batteryrequirementChoice = 0;
                batteryMenuDisplay = false;
            }
            else if (batteryrequirementChoice == 0)
            {
                BatteryReqirementChoiceMethod();

            }
        }

        private void BatteryReqirementChoiceMethod()
        {
            sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                sb.AppendLine("Chat Bot:You have selected requirement of battery life of > 5 years and < 10 years");
                Execute_API("api/productcategory/BatteryLife/5");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                sb.AppendLine("Chat Bot:You have selected requirement of battery life of more than 10 years");
                Execute_API("api/productcategory/BatteryLife/10");
            }
            else
            {
                sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct  Value");
                ChatArea = sb.ToString();
                batteryMenuDisplay = true;
            }
        }

        private void PhysicalrequirementChoice()
        {
            if (physicallock == false)
            {
                sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                sb.AppendLine("Chat Bot: Please choose one Physical Feature from the below list : \n " +
                    "1.Battery Life \n " +
                    "2.Screen Orientation\n " +
                    "3.Advanced Features (Anti Microbial Glass+ Patient Location)\n " +
                    "4.Device Type(Mobile/Static)" +
                    "5.Alarming Feature");
                ChatArea = sb.ToString();
                physicalrequirementChoice = 0;
                physicallock = true;
                batteryMenuDisplay = true;
                screenOrientationMenu = true;
                microbialGlassMenu = true;
                patientLocationMenu = true;
                alarmingMenu = true;
            }
            else if (physicalrequirementChoice == 0)
            {
                sb.AppendLine("User: " + YourMessage);
                ChatArea = sb.ToString();
                PhysicalrequirementChoiceTwo();
            }
        }
        private void PhysicalrequirementChoiceTwo()
        {
            try
            {
                physicalchoice = int.Parse(YourMessage);
                YourMessage = "";
                physicalrequirementChoice = 1;
            }
            catch (Exception e)
            {
                sb.AppendLine(YourMessage);
                sb.AppendLine("Error: Invalid Data Entered \n Stack Trace: " + e.StackTrace);
            }
        }
        private void MenuChoice1Method()
        {
            if (clinicalMenuDisplay == true)
            {
                sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one clinical requirements from below: \n 1.Cardiac " +
                    "\n2.Pnemonia " +
                    "\n3.Covid19 " +
                    "\n4.High BP");
                ChatArea = sb.ToString();
                clinicalrequirementChoice = 0;
                clinicalMenuDisplay = false;
            }
            else if (clinicalrequirementChoice == 0)
            {
                sb.AppendLine(YourMessage);
                chatArea = sb.ToString();
                ClinicalChoiceMethod();


            }

        }
        string url = "";
        private void ClinicalChoiceMethod()
        {
            try
            {
                clinical = int.Parse(YourMessage);
                YourMessage = "";
                //requirement = "";
                if (clinical == 1)
                {
                    url = "api/productcategory/cardiac";
                    sb.AppendLine("Chat Bot: You have selected Cardiac as your clinical requirement");
                    Execute_API(url);
                }
                else
                    ClinicalChoiceMethodTwo();
            }
            catch (Exception)
            {
                sb.AppendLine("Empty String Entered: Please Input Proper Values");
                ChatArea = sb.ToString();
            }
        }
        private void ClinicalChoiceMethodTwo()
        {
            if (clinical == 2)
            {
                url = "api/productcategory/Pneumonia";
                sb.AppendLine("Chat Bot: You have selected Pneumonia as your clinical requirement");
                Execute_API(url);
            }
            if (clinical == 3)
            {
                url = "api/productcategory/Covid19";
                sb.AppendLine("Chat Bot: You have selected Covid19 as your clinical requirement");
                Execute_API(url);
            }
            else
                ClinicalChoiceMethodThree();
        }
        private void ClinicalChoiceMethodThree()
        {
            if (clinical == 4)
            {
                url = "api/productcategory/HighBP";
                sb.AppendLine("Chat Bot: You have selected HighBP as your clinical requirement");
                Execute_API(url);
            }
            else
            {
                sb.AppendLine("Invalid Choice");
                ChatArea = sb.ToString();
                clinicallock = false;
            }
        }
        private void PhysicalchoiceMethod()
        {
            if (alarmingMenu == true)
            {
                sb.AppendLine("User: " + YourMessage);
                YourMessage = "";
                ChatArea = sb.ToString();
                sb.AppendLine("Chat Bot: Please choose one option for Alarming Feature from the below list :");
                sb.AppendLine("1. YES.\n 2.NO");
                ChatArea = sb.ToString();
                alarmingMenurequirementChoice = 0;
                alarmingMenu = false;
            }
            else if (alarmingMenurequirementChoice == 0)
            {
                AlarmingMenurequirementChoice();

            }

        }

        private void AlarmingMenurequirementChoice()
        {
            sb.AppendLine(YourMessage);
            if (int.Parse(YourMessage) == 1)
            {
                sb.AppendLine("Chat Bot:You have opted for Alarming Feature");
                Execute_API("api/productcategory/Alaraming/YES");
            }
            else if (int.Parse(YourMessage) == 2)
            {
                sb.AppendLine("Chat Bot:You have not opted for Alarming Feature");
                Execute_API("api/productcategory/Alaraming/NO");
            }
        }

        private void Execute_API(String url)
        {
            devices.Clear();
            temp.AppendLine("\nThe following result's matches to your requirement's");
            devices = clientRequests.ProductGetRequest(url);
            foreach (var d in devices)
            {
                count++;
                temp.AppendLine("\nDevice " + count + ": " +
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
            if (count > 0)
            {
                sb.AppendLine(temp.ToString());
                temp.Clear();
                ChatArea = sb.ToString();
            }
            else
            {
                sb.AppendLine("Could not find any devices of your preferences.\n" +
                    "Please register on our portal so that our Philips representative will contact you for more information!!");
                ChatArea = sb.ToString();
            }
        }
        List<string> modelName = new List<string>();
        public void PopoulateModelNames()
        {
            var Models = clientRequests.ProductGetRequest("api/productcategory/GetDevices");
            foreach (var Names in Models)
            {
                modelName.Add(Names.DeviceName);
            }
        }
        private void Execute_ClearCoomand(object obj)
        {
            sb = new StringBuilder();
            ChatArea = "Say 'Hi' to start the chat";
            choice = 1;
            count = 0;
            YourMessage = "";
            //throw new NotImplementedException();
        }
        private bool CanExecute_Mehod(object arg)
        {
            return true;
        }
        UserDetails user = new UserDetails();
        private void Execute_RegisterAndOrdering(object obj)
        {
            //userDetails.Add(new UserDetails { UserName = Name, ProductsBooked = modelTypeSelected, UserContactNo = ContactNumber });
            user.UserName = Name;
            user.UserContactNo = ContactNumber;
            user.ProductsBooked = ModelTypeSelected;
            clientRequests.UserPostRequest("api/AlertUser/Registration", user);
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
            get { return this.name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");

            }
        }
        public String Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");

            }
        }
        public List<String> ModelType
        {
            get
            {
                PopoulateModelNames();
                modelName.Add("Request to contact Philips person");
                //return new List<string>() { "Cardic", "Covid19", "Pnemonia","HighBp" ,"ContactToPhiliPsPerson"}; 
                return modelName;
            }
            set
            {
                modelType = value;
                OnPropertyChanged("ModelType");

            }
        }

        private String modelTypeSelected;
        public String ModelTypeSelected
        {
            get { return this.modelTypeSelected; }
            set
            {
                modelTypeSelected = value;
                OnPropertyChanged("ModelTypeSelected");
            }

        }
        public int ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                OnPropertyChanged("ContactNumber");

            }
        }
        public String YourMessage
        {
            get { return yourMessage; }
            set
            {
                yourMessage = value;
                OnPropertyChanged("YourMessage");

            }
        }
        public String ChatArea
        {
            get { return this.chatArea; }
            set
            {
                chatArea = value;
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
