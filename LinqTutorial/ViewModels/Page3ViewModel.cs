using LinqTutorial.Commands;
using LinqTutorial.Models;
using System;
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
            /*
            MessageBox.Show(String.Format("Titel: {0} Beschreibung: {1} Seiten: {2} Bewertung: {3} auf Lager: {4}", 
                                            Title, Description, Pages, Popularity, IsInStock));
                                            */

            int queryLevel = 0;

            var query = from book in books
                              select book;

            AktuelleAbfrageergebnisse.Clear();

            if (!String.IsNullOrEmpty(Title))
            {
                queryLevel++;
                query = query.Where(book => book.Title.Contains(this.Title));
            }

            if (Pages!=null || Pages<=0) {
                queryLevel++;
                query = query.Where(book => book.Pages == this.Pages);
            }

            if (!String.IsNullOrEmpty(Description))
            {
                queryLevel++;
                query = query.Where(book => book.Description.Contains(this.Description));
            }

            if (Popularity != null || Popularity < 0)
            {
                queryLevel++;
                query = query.Where(book => book.Popularity == this.Popularity);
            }

            if (queryLevel > 0)
            {
                query = query.Where(book => book.IsInStock == this.IsInStock);

                foreach (Book book in query)
                {
                    AktuelleAbfrageergebnisse.Add(book);
                }
            }

        }
    }
}
