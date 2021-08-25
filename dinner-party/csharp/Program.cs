using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
            public Guest(string name, string occupation, string bio)
            {
                this.Name = name;
                this.Occupation = occupation;
                this.Bio = bio;
            }
        }
        public class Table 
        {
            public string Name { get; set; }
            public List<Guest> GuestList { get; set; }

            public Table(string name)
            {
                this.Name = name;
                this.GuestList = new List<Guest>();
            }

            public void AddGuest(Guest guest)
            {
                GuestList.Add(guest);
            }
    
        }
        static void Main(string[] args)
        {
            List<Guest> guests = GetGuests();

            Table tableOne = new Table("Table One");
            Table tableTwo = new Table("Table Two");

            foreach (Guest guest in guests)
            {
                List<string> Table1Occupations = tableOne.GuestList.Select(guest => guest.Occupation).ToList();
                if (Table1Occupations.Contains(guest.Occupation))
                {
                    tableTwo.AddGuest(guest);
                }
                else
                {
                    tableOne.AddGuest(guest);
                }
            }

            Console.WriteLine(tableOne.Name);
            foreach (Guest guest in tableOne.GuestList) 
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        
            Console.WriteLine(tableTwo.Name);
            foreach (Guest guest in tableTwo.GuestList)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }

            
            List<Guest> GetGuests()
            {
                List<Guest> guests = new List<Guest>();
                
                guests.Add(new Guest(
                    "Marilyn Monroe",
                    "entertainer",
                    "(1926 - 1962) American actress, singer, model"
                ));
                guests.Add(new Guest(
                    "Abraham Lincoln",
                    "politician",
                    "(1809 - 1865) US President during American civil war"
                ));
                guests.Add(new Guest(
                    "Martin Luther King",
                    "activist",
                    "(1929 - 1968)  American civil rights campaigner"
                ));
                guests.Add(new Guest(
                    "Rosa Parks",
                    "activist",
                    "(1913 - 2005)  American civil rights activist"
                ));
                guests.Add(new Guest(
                    "Peter Sellers",
                    "entertainer",
                    "(1925 - 1980) British actor and comedian"
                ));
                guests.Add(new Guest(
                    "Alan Turing",
                    "computer scientist",
                    "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                ));
                guests.Add(new Guest(
                    "Admiral Grace Hopper",
                    "computer scientist",
                    "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                ));
                guests.Add(new Guest(
                    "Indira Gandhi",
                    "politician",
                    "(1917 - 1984) Prime Minister of India 1966 - 1977"
                ));

                return guests;
            }
        }
        
    }
}
