using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
    public class Owner : ModelBase
    {
        public int OwnerID { get; set; }
        public string Name { get; set; }
    }
}
