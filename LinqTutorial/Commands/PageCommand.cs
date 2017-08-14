using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace LinqTutorial.Commands
{
    class PageCommand : ICommand
    {       
        public event EventHandler CanExecuteChanged;

        NavigationService root;
        Page dest;

        public PageCommand(NavigationService root, Page dest)
        {
            this.root = root;
            this.dest = dest;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            root.Navigate(dest);
        }
    }
}
