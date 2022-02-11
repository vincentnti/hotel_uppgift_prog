using System;

namespace hotel {
    class Guest {
        // Params
        public string Name {get; set;}

        public int Id {get; set;}

        public string PhoneNu {get; set;}

        public string Address {get; set;}

        public int RoomNu {get; set;}

        public Guest (
            string aName,
            int aId,
            string aPhoneNu,
            string aAddress,
            int aRoomNu
        ) {
            this.Name = aName;
            this.Id = aId;
            this.PhoneNu = aPhoneNu;
            this.Address = aAddress;
            this.RoomNu = RoomNu;
        }

        // Methods
        public void CheckIn(Receptionist aReceptionist) {
            aReceptionist.BookRoom(this);
            Console.WriteLine(this.Name + " checked in! :)");
            // Något om bill går till receptionist som sedan
            // fixar rum som guest kan ta del av


        }

        public void CheckOut () {
            Console.WriteLine(this.Name + " checked out! :(");
        }
        
        public void PayBill(){
            Console.WriteLine(this.Name + " paid the bill! $");
        }
        
        public void OrderFood() {
            Console.WriteLine(this.Name + " ordered food!");
        }
    }
}