using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook
{
    public interface IFartRepository
    {
        void CreateFart(Fart fartToCreate);
        List<Fart> ReadAllFarts();
        void UpdateFart(Fart fartToUpdate);
        void DeleteFart(Fart fartToDelete);
    }
}
