using AssetToPurchaseFrontend.Commands;
using AssetToPurchaseFrontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace AssetToPurchaseFrontend.ViewModel
{
    public class AssetToPurchaseviewModel : INotifyPropertyChanged
    {
        #region data member
        private string name;
        private string email;
        private List<String> modelType;
        private string contactNumber;
        private string yourMessage;
        private string chatArea="Say 'Hi' to start the chat";
        int count = 0;
        static StringBuilder sb = new StringBuilder();
        StringBuilder temp = new StringBuilder();
        ClientRequests clientRequests = new ClientRequests();
        List<MonitoringDevice> devices = new List<MonitoringDevice>();
        List<UserDetails> userDetails = new List<UserDetails>();
        #endregion

        #region Constructor
        public AssetToPurchaseviewModel()
        {
            RegisterAndOrderingCommand = new DelegateCommand(Execute_RegisterAndOrdering, CanExecute_Mehod);
            ClearCommand = new DelegateCommand(Execute_ClearCoomand, CanExecute_Mehod);
            SendCommand = new DelegateCommand(Execute_SendCommand, CanExecute_Mehod);
        }
        #endregion
        int choice = 1;
        bool clinicallock;
        bool firsttime = true;
        int clinicalrequirementChoice = default;
        bool clinicalMenuDisplay, screenOrientationMenu, microbialGlassMenu, patientLocationMenu,alarmingMenu = true;
        bool batteryMenuDisplay, physicallock = false;
        int physicalrequirementChoice, batteryrequirementChoice, patientLocationrequirementChoice, alarmingMenurequirementChoice,
            screenOrientationrequirementChoice, microbialGlassrequirementChoice, clinical, menuchoice, physicalchoice = default;
        #region ExecuteAndCanexecuteImplementation
        private void Execute_SendCommand(object obj)
        {
            if (firsttime)
            {
                if (choice == 1)
                {
                    sb.AppendLine("Chat Bot: Say 'Hi' to start the chat");
                    sb.AppendLine("User: "+YourMessage);
                    ChatArea = sb.ToString();
                    sb.AppendLine("Chat Bot: Hello User Please Chat With Me For Customized Requirements");
                    ChatArea = sb.ToString();
                    YourMessage = "";
                    sb.AppendLine("Chat Bot: Please choose one menu option from the below list : \n 1.Clinical Requirements \n 2.Physical Requirements Based\n 3.Display all available models");
                    ChatArea = sb.ToString();
                    choice = 2;
                    clinicallock = false;
                }
                else if (choice == 2)
                {
                    if (clinicallock == false)
                    {
                        clinicalrequirementChoice = -1;
                        menuchoice = int.Parse(YourMessage);
                        clinicallock = true;
                        clinicalMenuDisplay = true;
                    }
                    if (menuchoice > 0 && menuchoice <= 3)
                    {
                        if (menuchoice == 1)
                        {
                            if (clinicalMenuDisplay == true)
                            {
                                sb.AppendLine("User: "+YourMessage);
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
                                try
                                {
                                    clinical = int.Parse(YourMessage);
                                    YourMessage = "";
                                    if (clinical == 1)
                                    {
                                        sb.AppendLine("Chat Bot: You have selected Cardiac as your clinical requirement");
                                        temp.AppendLine("\nThe following result's matches to your requirement's");
                                        devices = clientRequests.ProductGetRequest("api/productcategory/cardiac");
                                        foreach (var d in devices)
                                        {
                                            count++;
                                            temp.AppendLine("\nDevice "+count+": "+
                                                "\nDeviceName:"+d.DeviceName+
                                                "\nECG: "+d.Ecg+
                                                "\nSpo2: "+d.Spo2+
                                                "\nRespiration: "+d.Respiration+
                                                "\nHeart-Rate: "+d.Hr+
                                                "\nPhyscological-Alarming: "+d.PhysiologicalAlarming+
                                                "\nBlood-Pressure: "+d.BloodPressure+
                                                "\nBattery-Life: "+d.BatteryLife+
                                                "\nScreen-Orientation: "+d.SupportedScreenOrientations+
                                                "\nSize: "+d.Size+
                                                "\nMobile/Static: "+d.MobileOrStatic+
                                                "\nAnti-Microbial Glass: "+d.AntiMicrobialGlass+
                                                "\nPatient-Location: "+d.PatientLocation);
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
                                        // menuchoice = 2;
                                    }
                                    else if (clinical == 2)
                                    {
                                        sb.AppendLine("Chat Bot: You have selected Pnemonia as your clinical requirement");
                                        temp.AppendLine("\nThe following result's matches to your requirement's");
                                        devices = clientRequests.ProductGetRequest("api/productcategory/Pneumonia");
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
                                        // menuchoice = 2;
                                    }
                                    else if (clinical == 3)
                                    {

                                        sb.AppendLine("Chat Bot: You have selected Covid19 as your clinical requirement");
                                        temp.AppendLine("\nThe following result's matches to your requirement's");
                                        devices = clientRequests.ProductGetRequest("api/productcategory/Covid19");
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
                                        //menuchoice = 2;
                                    }
                                    else if(clinical==4)
                                    {
                                        sb.AppendLine("Chat Bot: You have selected High BP as your clinical requirement");
                                        temp.AppendLine("\nThe following result's matches to your requirement's");
                                        devices = clientRequests.ProductGetRequest("api/productcategory/HighBP");
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
                                        if(count>0)
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
                                        //menuchoice = 2;
                                    }
                                    else
                                    {
                                        sb.AppendLine("Invalid Choice");
                                        ChatArea = sb.ToString();
                                        clinicallock = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    //sb.AppendLine("Empty String Entered: Please Input Proper Values");
                                    //ChatArea = sb.ToString();
                                }

                            }
                        }
                         else if(menuchoice==2)
                         {
                            if (physicallock == false)
                            {
                                sb.AppendLine("User: " + YourMessage);
                                YourMessage = "";
                                sb.AppendLine("Chat Bot: Please choose one Physical Feature from the below list : \n " +
                                    "1.Battery Life \n " +
                                    "2.Screen Orientation\n " +
                                    "3.Advanced Features (Anti Microbial Glass+ Patient Location)\n " +
                                    "4.Device Type(Mobile/Static)"+
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
                            if (physicalrequirementChoice == 1)
                            {
                                if (physicalchoice == 1)
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
                                        sb.AppendLine(YourMessage);
                                        if (int.Parse(YourMessage) == 1)
                                        {
                                            sb.AppendLine("Chat Bot:You have selected requirement of battery life of > 5 years and < 10 years");
                                            temp.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/BatteryLife/5");
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
                                            //menuchoice = 4;
                                        }
                                        else if (int.Parse(YourMessage) == 2)
                                        {
                                            sb.AppendLine("Chat Bot:You have selected requirement of battery life of more than 10 years");
                                            sb.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/BatteryLife/10");
                                            foreach (var d in devices)
                                            {
                                                count++;
                                                sb.AppendLine("\nDevice " + count + ": " +
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
                                            ChatArea = sb.ToString();
                                            //menuchoice = 4;
                                        }
                                        else
                                        {
                                            sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct  Value");
                                            ChatArea = sb.ToString();
                                            batteryMenuDisplay = true;
                                        }
                                    }
                                }
                                else if (physicalchoice == 2)
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
                                        sb.AppendLine(YourMessage);
                                        if (int.Parse(YourMessage) == 1)
                                        {
                                            sb.AppendLine("Chat Bot:You have opted for screen orientation feature");
                                            temp.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/Display/YES");
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
                                            //menuchoice = 4;
                                        }
                                        else if (int.Parse(YourMessage) == 2)
                                        {
                                            sb.AppendLine("Chat Bot:You have not opted for screen orientation feature");
                                            sb.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/Display/NO");
                                            foreach (var d in devices)
                                            {
                                                count++;
                                                sb.AppendLine("\nDevice " + count + ": " +
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
                                            ChatArea = sb.ToString();
                                            //menuchoice = 4;
                                        }
                                        else
                                        {
                                            sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                                            ChatArea = sb.ToString();
                                            screenOrientationMenu = true;
                                        }
                                    }
                                }
                                else if (physicalchoice == 3)
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
                                        sb.AppendLine(YourMessage);
                                        if (int.Parse(YourMessage) == 1)
                                        {
                                            sb.AppendLine("Chat Bot:You have opted for Advanced Features(Microbial Glass + Patient Location)");
                                            temp.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/AdvancedFeatures/YES");
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
                                            //menuchoice = 4;
                                        }
                                        else if (int.Parse(YourMessage) == 2)
                                        {
                                            sb.AppendLine("Chat Bot:You have not opted for Advanced Features(Microbial Glass + Patient Location)");
                                            sb.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/AdvancedFeatures/NO");
                                            foreach (var d in devices)
                                            {
                                                count++;
                                                sb.AppendLine("\nDevice " + count + ": " +
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
                                            ChatArea = sb.ToString();
                                            //menuchoice = 4;
                                        }
                                        else
                                        {
                                            sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                                            ChatArea = sb.ToString();
                                            screenOrientationMenu = true;
                                        }
                                    }
                                }
                                else if (physicalchoice == 4)
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
                                        sb.AppendLine(YourMessage);
                                        if (int.Parse(YourMessage) == 1)
                                        {
                                            sb.AppendLine("Chat Bot:You have opted for Mobile Type of Device");
                                            temp.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/MobileorStatic/MOBILE");
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
                                            //menuchoice = 4;
                                        }
                                        else if (int.Parse(YourMessage) == 2)
                                        {
                                            sb.AppendLine("Chat Bot:You have not opted for Static Type of Device");
                                            sb.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/MobileorStatic/STATIC");
                                            foreach (var d in devices)
                                            {
                                                count++;
                                                sb.AppendLine("\nDevice " + count + ": " +
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
                                            ChatArea = sb.ToString();
                                            //menuchoice = 4;
                                        }
                                        //---------dddddjddd j ckd ckc//////
                                        else
                                        {
                                            sb.AppendLine("Chat Bot:Invalid Input: Please Input Correct Value");
                                            ChatArea = sb.ToString();
                                            screenOrientationMenu = true;
                                        }
                                    }
                                }
                                else if (physicalchoice == 5)
                                {
                                    if (alarmingMenu == true)
                                    {
                                        sb.AppendLine("User: "+YourMessage);
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
                                        sb.AppendLine(YourMessage);
                                        if (int.Parse(YourMessage) == 1)
                                        {
                                            sb.AppendLine("Chat Bot:You have opted for Alarming Feature");
                                            sb.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/Alaraming/YES");
                                            foreach (var d in devices)
                                            {
                                                count++;
                                                sb.AppendLine("\nDevice " + count + ": " +
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
                                            ChatArea = sb.ToString();
                                            //menuchoice = 4;
                                        }
                                        else if (int.Parse(YourMessage) == 2)
                                        {
                                            sb.AppendLine("Chat Bot:You have not opted for Alarming Feature");
                                            temp.AppendLine("\nThe following result's matches to your requirement's");
                                            devices = clientRequests.ProductGetRequest("api/productcategory/Alaraming/NO");
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
                                            //menuchoice = 4;
                                        }
                                    }
                                }   
                            }
                         }
                        else if (menuchoice==3)
                        {
                            devices = clientRequests.ProductGetRequest("api/productcategory/GetDevices");
                            foreach (var d in devices)
                            {
                                count++;
                                sb.AppendLine("\nDevice " + count + ": " +
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
                            ChatArea = sb.ToString();
                        }
                    }
                }
            }
        }
        private void Execute_ClearCoomand(object obj)
        {
            sb = new StringBuilder();
            ChatArea="Say 'Hi' to start the chat";
        }
        private bool CanExecute_Mehod(object arg)
        {
            return true;
        }

        private void Execute_RegisterAndOrdering(object obj)
        {
            throw new NotImplementedException();
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
            get { return new List<string>() { "Cardic", "Covid", "Alaram" }; }
            set
            {
                modelType = value;
                OnPropertyChanged("ModelType");

            }
        }
        public String ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber= value;
                OnPropertyChanged("ContactNumber");

            }
        }
        public String YourMessage
        {
            get { return yourMessage; }
            set
            {
                yourMessage= value;
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
