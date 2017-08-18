using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
    public class Animal : ModelBase
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
