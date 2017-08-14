using LinqTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqTutorial.Models;
using System.Collections.ObjectModel;

namespace LinqTutorial.ViewModels
{
    class Page2ViewModel
    {
    public ObservableCollection<object> AktuelleAbfrageergebnisse { get; private set; }
    public Page2ViewModel()
    {
       AktuelleAbfrageergebnisse = new ObservableCollection<object>();
       TeureComics();
    }

    private void TeureComics()
        {
            IEnumerable<Comic> comics = DatenSammlungEins.KatalogGenerieren();
            Dictionary<int, decimal> werte = DatenSammlungEins.PreiseAufbauen();
            

            var amTeuersten = from comic in comics
                              where werte[comic.Folge] > 500
                              orderby werte[comic.Folge] descending
                              select comic;
            
            foreach (Comic comic in amTeuersten)
            {
                AktuelleAbfrageergebnisse.Add(new {
                    Name = comic.Name,
                    Folge = comic.Folge,
                    Preis = werte[comic.Folge]
                    }
                );
            }
        }


        
    }
}
