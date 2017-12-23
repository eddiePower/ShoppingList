using System;
using System.Windows.Input;

namespace ShoppingList
{
    /// <summary>
    /// A command whose sole purpose is to relay its functionality 
    /// to other objects by invoking delegates. 
    /// The default return value for the CanExecute method is 'true'.
    /// <see cref="RaiseCanExecuteChanged"/> needs to be called whenever
    /// <see cref="CanExecute"/> is expected to return a different value.
    /// </summary>
    /// 

    public class RelayCommand : ICommand
    {
        readonly Action _execute;
        readonly Func<bool> _canExecute;
        
        /// <summary>
        /// Initializes a new instance of <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="RelayCommand"/> that can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>

        public RelayCommand(Action execute) : this(execute, null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}