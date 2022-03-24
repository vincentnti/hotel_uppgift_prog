using System;
using System.Collections.Generic;
using System.Linq;

namespace hotel {
    class Receptionist {
        public string Name {get; set;}

        public int Id {get; set;}

        public string PhoneNu {get; set;}
        
        public List<Room> Rooms {get; set;} = new List<Room>();

        public Receptionist (
            string aName,
            int aId,
            string aPhoneNu
        ) {
            this.Name = aName;
            this.Id = aId;
            this.PhoneNu = aPhoneNu;

            // Generate 10 rooms
            for (int i = 0; i < 11; i++) {
                this.Rooms.Add(new Room(
                    i,
                    true
                ));
            }
        }

        public void BookRoom(Guest aGuest) { // Sets the staying room for a guest by using GetAvailableRoom
            Room room = this.GetAvailabeRoom();
            if (room != null) {
                aGuest.StayingRoom = room;
                room.RoomAvailable = false;
            } else {
                Console.WriteLine("Sorry " + aGuest.Name + " there are no available rooms.");
            }
        }

        public void WriteBill(Guest aGuest) {
            Console.WriteLine(this.Name + " writes a bill of 2500");
            bool paidBill = aGuest.PayBill(2500);
            if (!paidBill) {
                Console.WriteLine(aGuest.StayingRoom);
                this.CancelRoom(aGuest);
            }
        }

        public Room GetAvailabeRoom() {
            // Find available room and return it
            // No room found? Send null.
           return this.Rooms.FirstOrDefault(room => room.RoomAvailable == true);
        }
        
        public void CancelRoom(Guest aGuest) {
            if (aGuest.StayingRoom != null) {
                Room room = aGuest.StayingRoom;
                aGuest.StayingRoom = null;
                room.RoomAvailable = true;
                Console.WriteLine(aGuest.Name + " checked out! :(");
            }
        }
    }
}