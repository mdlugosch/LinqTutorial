using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.ViewModels
{
    class Page1ViewModel
    {
        public ObservableCollection<object> AktuelleAbfrageergebnisse { get; private set; }
        public Page1ViewModel()
        {
            AktuelleAbfrageergebnisse = new ObservableCollection<object>();
            LinqMachtAbfragenLeicht();
        }

        private void LinqMachtAbfragenLeicht()
        {
            int[] werte = new[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var ergebnis = from w in werte
                           where w < 37
                           orderby w
                           select w;
            foreach (int i in ergebnis)
            {
                AktuelleAbfrageergebnisse.Add(new { Zahl = i });
            }
        }

    }
}
