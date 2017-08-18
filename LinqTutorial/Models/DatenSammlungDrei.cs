using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Models
{
    public static class DatenSammlungDrei
    {
        public static List<Animal> HaustierListeAufbauen()
        {
            return new List<Animal>
            {
               new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };
        }

        public static List<Owner> BesitzerListeAufbauen()
        {
            return new List<Owner>
            {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };
        }
    }
}
