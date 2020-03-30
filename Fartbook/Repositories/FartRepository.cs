using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook
{
    public class FartRepository : IFartRepository
    {
        private List<Fart> _farts = new List<Fart>() 
        {
           new Fart()
           {
               Sound = "Pfffff",
               SmellRating = 8,
               FartID = 3943740
           },
           new Fart()
           {
               Sound = "Smeaaaaa",
               SmellRating = 6,
               FartID = 382720
           }
        };
        public void CreateFart(Fart fartToCreate)
        {
            try
            {
                _farts.Add(fartToCreate);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your fart could not be created");
            }
        }

        public void DeleteFart(Fart fartToDelete)
        {
            _farts.Remove(fartToDelete);
        }

        public List<Fart> ReadAllFarts()
        {
            return _farts;
        }

        public void UpdateFart(Fart fartToUpdate)
        {
            Fart fartEntityToUpdate = _farts.Find(fart => fart.FartID == fartToUpdate.FartID);
            fartEntityToUpdate.SmellRating = fartToUpdate.SmellRating;
            fartEntityToUpdate.Sound = fartToUpdate.Sound;
        }
    }
}
