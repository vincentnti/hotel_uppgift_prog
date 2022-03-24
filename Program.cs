using System;
using System.Collections.Generic;

namespace hotel
{
    class Program
    {
        static void Main(string[] args) // Program Entry
        {
           var program = new Program(); 
        }
        public List<Guest> Guests {get; set;} = new List<Guest>();

        public Receptionist TheReceptionist {get;} = new Receptionist (
            "Olof",
            2,
            "072322455"
        );

        public Guest chosenGuest {get; set;} // Selector

        public Program() {
            SystemName();
            CreateGuest();
            CommandLine();
        }

        public void SystemName() {
            Console.WriteLine("########################");
            Console.WriteLine("#     Hotel System     #");
            Console.WriteLine("########################");
        }

        public void CommandLine() { // Command Line interface for actions, simplifies the process, simply check for commands and call the methods accordingly
            while(true) {
                Console.WriteLine("\nWelcome to the Hotel System CLI! Type \"help\" for help");
                string command = Console.ReadLine(); // Command input!
                if (command == "help") {
                    // Prints available commands
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("create, select, do, quit");
                } else if (command == "create") {
                    CreateGuest();
                } else if (command == "select") {
                    SelectGuest();
                } else if (command == "do") {
                    MethodGuest();
                } else if (command == "quit") {
                    break; // escapes infinite loop 
                } else {
                    Console.WriteLine("Command not recognized!");
                    // Tips could be added here for user convenience;
                }
            }
        }

        public void CreateGuest() { // User interface for creating a new guest
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone Number: ");
            string phonenu = Console.ReadLine();

            this.Guests.Add(
                new Guest(
                    name,
                    id,
                    phonenu,
                    null
                )
            );
        }

        public void SelectGuest() {
            Console.WriteLine("Guests: ");
            foreach(Guest guest in this.Guests) {
                Console.WriteLine(guest.Name);
            }
            Console.WriteLine("Name to search for: ");
            var searchName = Console.ReadLine();

            foreach(Guest guest in Guests) {
                if (guest.Name == searchName) {
                    this.chosenGuest = guest;   
                } else {
                    Console.WriteLine("Guest not found!");
                }            
            }
        }

        public void MethodGuest() { // Command line interface for guest actions, simply checks for actions and calls methods accordingly 
            if(this.chosenGuest == null) { // Prevent use when no guest is chosen. 
                Console.WriteLine("Please select a guest first!");
                return;
            }

            while(true) {
                Console.WriteLine("\nWrite an action you want a Guest to perform!");
                Console.WriteLine("Type \"actions\" for available actions, and quit to stop.");
                string command = Console.ReadLine();

                if (command == "actions") {
                    //Prints available actions
                    Console.WriteLine("Available actions:");
                    Console.WriteLine("checkin, checkout, balance, paybill, orderfood, quit");
                } else if (command == "checkin") {
                    chosenGuest.CheckIn(this.TheReceptionist);
                } else if (command == "checkout") {
                    chosenGuest.CheckOut(this.TheReceptionist);
                } else if (command == "balance") {
                    Console.WriteLine(chosenGuest.Name + " Balance: " + chosenGuest.Balance);
                } else if (command == "paybill") {
                    this.TheReceptionist.WriteBill(chosenGuest); 
                } else if (command == "orderfood") {
                    chosenGuest.OrderFood();
                } else if (command == "quit") {
                    break; // escapes infinite loop 
                } else {
                    Console.WriteLine("Command not recognized!");
                }
            }
        }
    }
} 