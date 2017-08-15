using LinqTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LinqTutorial.Commands
{
    class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public SearchCommand() { }

        public void RaiseCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
                this.CanExecuteChanged(this, null);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ((Page3ViewModel)parameter).BuildQuery();
        }
    }
}
