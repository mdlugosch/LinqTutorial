using LinqTutorial.Commands;
using LinqTutorial.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LinqTutorial.ViewModels
{
    class Page3ViewModel : ModelBase
    {
        public ObservableCollection<object> AktuelleAbfrageergebnisse { get; private set; }
        IEnumerable<Book> books = DatenSammlungZwei.BuchListeAufbauen();

        public string Title { get; set; }
        public string Description { get; set; }
        public int? Pages { get; set; }
        public double? Popularity { get; set; }
        public bool IsInStock { get; set; }

        public Page3ViewModel()
        {
            AktuelleAbfrageergebnisse = new ObservableCollection<object>();
        }

        public SearchCommand search;
        public SearchCommand Search
        {
            get
            {
                if (search == null)
                {
                    search = new SearchCommand();
                }

                return search;
            }
            set
            {
                search = value;
            }
        }

        public void BuildQuery()
        {
            // PropertyListe wird generiert
            List<string> activePropereties=null;
            activePropereties = PropertyList.PropertyCheck(this);
            
            var query = from book in books
                        select book;

            /*
             * Der PropertyCheck sorgt dafür das nur Properties
             * in der der PropertyListe sind die Inhalte haben
             * Die Liste wird durchlaufen und bestimmte Properties
             * aus der Liste sorgen für das Anhängen von LinQ-Clauses
             */
            foreach (string prop in activePropereties)
            {
                switch(prop)
                {
                    case "Title":
                        query = query.Where(book => book.Title.Contains(Title));
                        break;
                    case "Description":
                        query = query.Where(book => book.Description.Contains(this.Description));
                        break;
                    case "Pages":
                        query = query.Where(book => book.Pages == this.Pages);
                        break;
                    case "Popularity":
                        query = query.Where(book => book.Popularity == this.Popularity);
                        break;
                }
            }    
                // Eine Checkbox ist immer teil der Clause. Da sie immer einen Wert hat.      
                query = query.Where(book => book.IsInStock == this.IsInStock);

                AktuelleAbfrageergebnisse.Clear();
                foreach (Book book in query)
                {
                    AktuelleAbfrageergebnisse.Add(book);
                }
        }
    }
}
