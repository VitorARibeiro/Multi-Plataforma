﻿using System.Windows.Input;

namespace MVVM_Listagem.MVVM
{
    class RelayCommand : ICommand
    {

        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged 
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
           this.canExecute = canExecute;
            this.execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null  || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
