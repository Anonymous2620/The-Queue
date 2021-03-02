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

       
        
        public void AddGuests(string name, int age)
        {
            Console.Clear();
            guests.Enqueue(new Guest() { Age = age, Name = name });
        }
        
        
        public void DeleteGuests()
        {
            Console.Clear();
            Guest guest = guests.Dequeue();
            Console.WriteLine($"Name: {guest.Name} Age:{guest.Age}\n");
        }
        

        public void NumberOfGuests()
        {
            Console.Clear();
            Console.WriteLine($"Total Guests: {guests.Count()}");
        }

        public void PrintAmountofGuests()
        {
            Console.Clear();
            
            foreach (Guest guest in guests)
            {
                Console.WriteLine($"Name: {guest.Name} Age:{guest.Age}\n");
            }
        }

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
