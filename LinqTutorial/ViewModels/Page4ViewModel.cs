using LinqTutorial.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.ViewModels
{
    class Page4ViewModel
    {
        IEnumerable<Animal> animals = DatenSammlungDrei.HaustierListeAufbauen();
        IEnumerable<Owner> owners = DatenSammlungDrei.BesitzerListeAufbauen();
        public ObservableCollection<object> AktuelleAbfrageergebnisse { get; private set; }

        public Page4ViewModel()
        {
            AktuelleAbfrageergebnisse = new ObservableCollection<object>();
            CreateOwnerPetList();
        }

        public void CreateOwnerPetList()
        {
            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals
                on owner.OwnerID
                equals animal.AnimalID
                into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from owner2
                              in ownerGroup
                              orderby owner2.Name
                              select owner2
                };

            foreach(var ownerGroup in groupJoin)
            {
                AktuelleAbfrageergebnisse.Add(ownerGroup);
                foreach(var animal in ownerGroup.Animals)
                {
                    AktuelleAbfrageergebnisse.Add(animal);
                }
            }
        }
    }
}
