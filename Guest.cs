using System;

namespace hotel {
    class Guest : Person{
        // Params
        public string PhoneNu {get; set;}

        public Room StayingRoom {get; set;}

        public int Balance {get; set;}

        public Guest (
            string aName,
            int aId,
            string aPhoneNu,
            Room aStayingRoom
        ) {
            this.Name = aName;
            this.Id = aId;
            this.PhoneNu = aPhoneNu;
            this.StayingRoom = aStayingRoom;


            Random rnd = new Random();
            this.Balance = rnd.Next(0, 20000); // 2500 blir pris för rum
            
        }

        // Methods
        public void CheckIn(Receptionist aReceptionist) {
            aReceptionist.BookRoom(this);
            Console.WriteLine(this.Name + " checked in! :) into Room " + this.StayingRoom.RoomNu);
            // Något om bill går till receptionist som sedan
            // Eller inte här kanske har ju metod nedan
        }

        public void CheckOut (Receptionist aReceptionist) {
            aReceptionist.CancelRoom(this);
        }
        
        public bool PayBill(int aBill){ // Någon error, när man får för låg balance antar jag iaf vet inte ifall det är här
            if (this.Balance >= aBill) {
                this.Balance -= aBill;
                Console.WriteLine(this.Name + " paid the bill! ;)");
                return true;
            } else {
                return false;
            }
        }
        
        public void OrderFood() {
            if (this.Balance >= 100) {
                this.Balance -= 100;
                Console.WriteLine(this.Name + " ordered food!");
            } else {
                Console.WriteLine(this.Name + " could not afford food! ;(");
            }
        }


        
    }
}