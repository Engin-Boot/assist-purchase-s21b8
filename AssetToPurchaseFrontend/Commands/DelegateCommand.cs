using System;
using System.Windows.Input;

namespace AssetToPurchaseFrontend.Commands
{
   public  class DelegateCommand :ICommand
    {

        Action<object> _executeMethodAddress;
        Func<object, bool> _canExecuteMethodAddress;

        public DelegateCommand(Action<object> executeMethodAddress, Func<object, bool> canExecuteMethodAddress)
        {
            this._executeMethodAddress = executeMethodAddress;
            this._canExecuteMethodAddress = canExecuteMethodAddress;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this._canExecuteMethodAddress.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this._executeMethodAddress.Invoke(parameter);
        }
    }
}
