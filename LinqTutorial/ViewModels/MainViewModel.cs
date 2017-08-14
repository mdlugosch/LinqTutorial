using LinqTutorial.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace LinqTutorial.ViewModels
{
    class MainViewModel : ModelBase
    {
        NavigationService root;
        public MainViewModel(NavigationService root)
        {
            this.root = root;
        }

        public PageCommand seite1;
        public PageCommand Seite1 {
            get
            {
                if (seite1 == null)
                {
                    seite1 = new PageCommand(root, new Page1());
                }
                return seite1;
            }
            set
            {
                seite1 = value;
            }
        }

        public PageCommand seite2;
        public PageCommand Seite2
        {
            get
            {
                if (seite2 == null)
                {
                    seite2 = new PageCommand(root, new Page2());
                }
                return seite2;
            }
            set
            {
                seite2 = value;
            }
        }

    }
}
