using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
  public class Comic : ModelBase
        {
            public string Name { get; set; }
            public int Folge { get; set; }
        }
}
