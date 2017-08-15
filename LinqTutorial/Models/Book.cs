using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
    public class Book : ModelBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public double Popularity { get; set; }
        public bool IsInStock { get; set; }
    }
}
