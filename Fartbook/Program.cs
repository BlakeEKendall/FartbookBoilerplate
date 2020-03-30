using System;

namespace Fartbook
{
    class Program
    {
        static void Main(string[] args)
        {
            FartTypeRepository fartTypeRepo = new FartTypeRepository();
            FartRepository fartRepo = new FartRepository();
            AppMenu menu = new AppMenu(fartRepo, fartTypeRepo);
            menu.Run();
        }
    }
}
