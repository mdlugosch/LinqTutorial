using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
    public static class DatenSammlungZwei
    {
        public static List<Book> BuchListeAufbauen()
        {
            return new List<Book>
            {   new Book { Title = "Seth-Apophis", Description = "Band 138", Pages = 415, Popularity = 1.1, IsInStock = true },
                new Book { Title = "Kampf um Terra", Description = "Band 137", Pages = 515, Popularity = 5.1, IsInStock = true  },
                new Book { Title = "Einer gegen Terra", Description = "Band 136", Pages = 398, Popularity = 1.5, IsInStock = true },
                new Book { Title = "Sammelpunkt Vier-Sonnen-Reich", Description = "Band 135", Pages = 450, Popularity = 2.3, IsInStock = true },
                new Book { Title = "Die Ewigen Diener", Description = "Band 134", Pages = 489, Popularity = 7.8, IsInStock = false },
                new Book { Title = "Der Fluch der Kosmokratin", Description = "Band 133", Pages = 510, Popularity = 10.1, IsInStock = false },
                new Book { Title = "Der Fluch der Kosmokratin", Description = "Band 132", Pages = 432, Popularity = 9.2, IsInStock = false },
                new Book { Title = "Sturz aus dem Frostrubin", Description = "Band 131", Pages = 515, Popularity = 3.2, IsInStock = true },
                new Book { Title = "Der Frostrubin", Description = "Band 130", Pages = 397, Popularity = 4.1, IsInStock = false },
                new Book { Title = "Der steinerne Bote", Description = "Band 129", Pages = 522, Popularity = 4.4, IsInStock = true },
                new Book { Title = "Das rotierende Nichts", Description = "Band 128", Pages = 432, Popularity = 8.9, IsInStock = true },
                new Book { Title = "Schaltstelle der Macht ", Description = "Band 127", Pages = 415, Popularity = 2.2, IsInStock = true },
                new Book { Title = "Herr der Ringe", Description = "Band 1", Pages = 415, Popularity = 2.2, IsInStock = true },
                new Book { Title = "Herr der Ringe", Description = "Band 2", Pages = 415, Popularity = 2.2, IsInStock = true },
                new Book { Title = "Herr der Ringe (Spezial Edition)", Description = "Band 2", Pages = 420, Popularity = 2.3, IsInStock = true },
                new Book { Title = "Herr der Ringe", Description = "Band 3", Pages = 415, Popularity = 2.3, IsInStock = true },
                new Book { Title = "Herr der Ringe (mit Goldrand)", Description = "Band 1", Pages = 500, Popularity = 2.2, IsInStock = false },
                new Book { Title = "Herr der Ringe (eng)", Description = "Band 1", Pages = 415, Popularity = 2.2, IsInStock = true }
            };
        }
    }
}
