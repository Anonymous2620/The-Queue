using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class MenuOptions
    {
        Queue<Guest> guests = new Queue<Guest>();

       
        //Here is where you can add a new guest and input the name and age.
        public void AddGuests(string name, int age)
        {
            Console.Clear();
            guests.Enqueue(new Guest() { Age = age, Name = name });
        }
        
        //This is where you can emove a guest from the queue if needed.
        public void DeleteGuests()
        {
            Console.Clear();
            Guest guest = guests.Dequeue();
            Console.WriteLine($"Name: {guest.Name} Age:{guest.Age}\n");
        }
        
        //Here you will be presentet with the number of guests that are currently in queue.
        public void NumberOfGuests()
        {
            Console.Clear();
            Console.WriteLine($"Total Guests: {guests.Count()}");
        }

        //Here you will be presentet with the full list of guests displaying both their names and ages.
        public void PrintAmountofGuests()
        {
            Console.Clear();
            
            foreach (Guest guest in guests)
            {
                Console.WriteLine($"Name: {guest.Name} Age:{guest.Age}\n");
            }
        }

        //Here you can find any guest by typing in their name.
        public void FindGuest(string str)
        {
            Console.Clear();
            foreach (Guest guest in guests)
            {
                if(guest.Name == str)
                {
                    Console.WriteLine($"Name: {guest.Name}");
                    Console.WriteLine($"Age: {guest.Age}");
                }
            }
        }
        
    }
}
