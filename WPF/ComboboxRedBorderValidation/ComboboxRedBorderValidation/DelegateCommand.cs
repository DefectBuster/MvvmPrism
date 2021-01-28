using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxRedBorderValidation
{
    internal class DelegateCommand : ICommand
    {
        /// <summary>
        /// To be executed
        /// </summary>
        private readonly Action<object> ToBeExecuted;

        bool canExecuteCache;

        /// <summary>
        /// The can execute
        /// </summary>
        private readonly Func<object, bool> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="ToBeExecuted">To be executed.</param>
        /// <param name="CanExecute">The can execute.</param>
        public DelegateCommand(Action<object> ToBeExecuted, Func<object, bool> CanExecute)
        {
            this.ToBeExecuted = ToBeExecuted;
            this.canExecute = CanExecute;
        }

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        /// <returns>
        ///   <see langword="true" /> if this command can be executed; otherwise, <see langword="false" />.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            bool temp = canExecute(parameter);
            if (canExecuteCache != temp)
            {
                canExecuteCache = temp;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
            return canExecuteCache;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public void Execute(object parameter)
        {
            ToBeExecuted(parameter);
        }
    }
}
