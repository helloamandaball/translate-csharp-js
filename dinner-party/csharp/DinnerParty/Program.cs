using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        /*
        An app for creating the seating arrangements of historical characters at a dinner party.

        Since we want everyone to have an interesting evening, we want to diversify the guests as much as possible. To that end, we don't want people with the same Occupation to sit at the same table. Your task is to divide the guests into different tables accordingly.
        */

        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }

        public class GuestTable
        {
            // public string TableName { get; set; }
            public List<Guest> TableGuests { get; set; } = new List<Guest>();
        }

        static void Main(string[] args)
        {
            List<Guest> guests = GetAllGuests();

            // Make a list of Guest objects
            List<Guest> GetAllGuests()
            {
                List<Guest> guests = new List<Guest>
                    {
                        new Guest {
                            Name = "Marilyn Monroe",
                            Occupation = "entertainer",
                            Bio ="(1926 - 1962) American actress, singer, model"
                        },
                        new Guest {
                            Name = "Abraham Lincoln",
                            Occupation = "politician",
                            Bio ="(1809 - 1865) US President during American civil war"
                        },
                        new Guest {
                            Name = "Martin Luther King",
                            Occupation = "activist",
                            Bio ="(1929 - 1968)  American civil rights campaigner"
                        },
                        new Guest {
                            Name = "Rosa Parks",
                            Occupation = "activist",
                            Bio ="(1913 - 2005)  American civil rights activist"
                        },
                        new Guest {
                            Name = "Peter Sellers",
                            Occupation = "entertainer",
                            Bio ="(1925 - 1980) British actor and comedian"
                        },
                        new Guest {
                            Name = "Alan Turing",
                            Occupation = "computer scientist",
                            Bio ="(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                        },
                        new Guest {
                            Name = "Admiral Grace Hopper",
                            Occupation = "computer scientist",
                            Bio ="(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                        },
                        new Guest {
                            Name = "Indira Gandhi",
                            Occupation = "politician",
                            Bio ="(1917 - 1984) Prime Minister of India 1966 - 1977"
                        }
                    };
                return guests;
            }

            //Same as: List<GuestTable> Table1 = new List<GuestTable>();
            GuestTable Table1 = new GuestTable();
            GuestTable Table2 = new GuestTable();


            //Example in code review, though there are errors I'm not sure why:
            // guests.ForEach(guest => {
            //     if (!Table1.Any(x => x.Occupation == guest.Occupation)){
            //         Table1.Add(guest);
            //     }
            //     else {
            //         Table2.Add(guest);
            //     }
            // });
            // Table1.ForEach(x => Console.WriteLine($"{x.Occupation} {x.Name}"));
            // Table2.ForEach(x => Console.WriteLine($"{x.Occupation} {x.Name}"));
            

            //use a foreach loop to iterate over a collection, such as a list
            foreach (var guest in guests)
            {
                List<string> table1Occupations = Table1.TableGuests.Select(g => g.Occupation).ToList();

                if (table1Occupations.Contains(guest.Occupation))
                {
                    Table2.TableGuests.Add(guest);
                }
                else
                {
                    Table1.TableGuests.Add(guest);
                }
            }

            Console.WriteLine("TABLE 1:");
            foreach (Guest myGuest in Table1.TableGuests)
            {
                Console.WriteLine($"{myGuest.Name}");
            }
            
            //just to add space between the two table groups:
            Console.WriteLine();

            Console.WriteLine("TABLE 2:");
            foreach (Guest myGuest in Table2.TableGuests)
            {
                Console.WriteLine($"{myGuest.Name}");
            }
        }
    }
}
