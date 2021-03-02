using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Menu
    {
        Guest guest = new Guest();
        MenuOptions options = new MenuOptions();
        //Here is my menu which is printet out to the console.
        public void MenuOptions()
        {
            Console.WriteLine("1. Add a guest");
            
            Console.WriteLine("2. Delete a guest");
            
            Console.WriteLine("3. Show the number of guests");
            
            Console.WriteLine("4. Find a guest");
            
            Console.WriteLine("5. Find all the guests");
            
            Console.WriteLine("6. Exit the menu");
        }

        public void MainMenu()
        {
            while (true)
            {
                MenuOptions();
                int userInput = Convert.ToInt32(Console.ReadLine());

                
                switch (userInput)
                {
                    //Here i add a new user.
                    case 1:

                        Console.WriteLine("Insert the name of your guest");
                        guest.Name = Console.ReadLine();

                        Console.WriteLine("Insert the age of your guest");
                        guest.Age = Convert.ToInt32(Console.ReadLine());

                        options.AddGuests(guest.Name, guest.Age);
                        Console.WriteLine($"Has been added to guest list {guest.Name} {guest.Age}");
                        Console.ReadKey();
                        break;
                    
                    //Here i delete guests.
                    case 2:

                        options.DeleteGuests();
                        Console.ReadKey();
                        break;

                    //Here i wil display the number of guests.
                    case 3:
                    
                        options.NumberOfGuests();
                        Console.ReadKey();
                        break;
                    
                    //Here i find guests by their name.
                    case 4:
                                                
                        Console.Write("Guest name: ");
                        string name = Console.ReadLine();

                        options.FindGuest(name);
                        Console.ReadKey();
                        break;
                   
                    //Here i print out all the names and ages of guests.
                    case 5:

                        options.PrintAmountofGuests();
                        Console.ReadKey();
                        break;
                   
                    //Here is the way you exit.
                    case 6:
                        
                        Environment.Exit(1);
                       
                        break;
                    
                    default:
                       
                        break;
                }
            }
        }

    }
}
