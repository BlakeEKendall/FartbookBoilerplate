using Fartbook.Interfaces;
using Fartbook.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook
{
    class AppMenu
    {
        private IFartRepository _fartRepository;
        private UserInputHelper _userInputHelper;
        private IFartTypeRepository _fartTypeRepository;
        public AppMenu(IFartRepository fartRepo, IFartTypeRepository fartTypeRepo)
        {
            _fartTypeRepository = fartTypeRepo;
            _fartRepository = fartRepo;
        }
        public void Run()
        {
            bool fartbookIsRunning = true;
            while (fartbookIsRunning)
            {
                Console.WriteLine("Welcome to fartbook: select a number\n" +
                                "1: Read all farts\n" +
                                "2: Create a fart\n" +
                                "3: Update a fart\n" +
                                "4: Delete a fart\n" +
                                "5: Exit\n" +
                                "6: Create a fart type\n" +
                                "7: See most popular fart types\n" +
                                "8: Delete a fart type by title");
                string userInput = Console.ReadLine();
                switch (Convert.ToInt32(userInput))
                {
                    case 1:
                        foreach (Fart fart in _fartRepository.ReadAllFarts())
                        {
                            Console.WriteLine(fart.Sound);
                            Console.WriteLine(fart.SmellRating);
                        }
                        break;
                    case 2:
                        _userInputHelper = new UserInputHelper();
                        Fart fartToAdd = _userInputHelper.GetFartFromUser();
                        _fartRepository.CreateFart(fartToAdd);
                        if (fartToAdd != null)
                        {
                        Console.WriteLine("Your fart has been added");
                        }
                        break;
                    case 3:
                        List<Fart> currentFarts = _fartRepository.ReadAllFarts();
                        for (int i = 0; i < currentFarts.Count - 1; i++)
                        {
                            Console.WriteLine($"{i} {currentFarts[i].Sound} {currentFarts[i].SmellRating} \n");
                        }
                        int fartToUpdateIndex = Convert.ToInt32(Console.ReadLine());
                        _userInputHelper = new UserInputHelper();
                        Fart fartToUpdate = _userInputHelper.GetUpdatedFartFromUser();
                        fartToUpdate.FartID = currentFarts[fartToUpdateIndex].FartID;
                        _fartRepository.UpdateFart(fartToUpdate);
                        break;
                    case 4:
                        List<Fart> currentFarts1 = _fartRepository.ReadAllFarts();
                        for (int i = 0; i < currentFarts1.Count - 1; i++)
                        {
                            Console.WriteLine($"{i} {currentFarts1[i].Sound} {currentFarts1[i].SmellRating} \n");
                        }
                        int fartToDeleteIndex = Convert.ToInt32(Console.ReadLine());
                        Fart fartToDelete = currentFarts1[fartToDeleteIndex];
                        _fartRepository.DeleteFart(fartToDelete);
                        break;
                    case 5:
                        fartbookIsRunning = false;
                        break;
                    case 6:
                        _userInputHelper = new UserInputHelper();
                        FartType fartTypeToCreate = _userInputHelper.GetNewFartTypeFromUser();
                        _fartTypeRepository.CreateFartType(fartTypeToCreate);
                         //_fartTypeRepository.GetMostPopularFartTypes();
                        break;
                    case 7:
                        _userInputHelper = new UserInputHelper();
                        _userInputHelper.DisplayPopularFartTypes(_fartTypeRepository.GetMostPopularFartTypes());
                        break;
                    case 8:
                        _userInputHelper = new UserInputHelper();
                        String titleToDelete = _userInputHelper.GetTitleOfFartTypeToDelete();
                        _fartTypeRepository.DeleteFartType(titleToDelete);
                        break;
                }
            }
        }
    }
}
