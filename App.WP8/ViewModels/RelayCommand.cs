using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.WP8.ViewModels
{
    public class RelayCommand<T> : ICommand
    {
        private Action<T> action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<T> action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.action((T)parameter);
        }
    }

    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action action)
            : base(o => action())
        {
        }
    }
}
