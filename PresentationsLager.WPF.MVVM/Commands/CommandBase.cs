using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PresentationsLager.WPF.MVVM.Commands
{
    public abstract class CommandBase : ICommand
    {
        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
