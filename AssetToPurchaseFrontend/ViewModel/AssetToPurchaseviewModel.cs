using AssetToPurchaseFrontend.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string chatArea;
        #endregion

        #region Constructor
        public AssetToPurchaseviewModel()
        {
            RegisterAndOrderingCommand = new DelegateCommand(Execute_RegisterAndOrdering, CanExecute_Mehod);
            ClearCommand = new DelegateCommand(Execute_ClearCoomand, CanExecute_Mehod);
            SendCommand = new DelegateCommand(Execute_SendCommand, CanExecute_Mehod);
        }
        #endregion

        #region ExecuteAndCanexecuteImplementation
        private void Execute_SendCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void Execute_ClearCoomand(object obj)
        {
            throw new NotImplementedException();
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
            get { return name; }
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
            get { return chatArea; }
            set
            {
                ChatArea = value;
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
