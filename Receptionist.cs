using System.Collections.Generic;

namespace hotel {
    class Receptionist {
        public string Name {get; set;}

        public int Id {get; set;}

        public string PhoneNu {get; set;}
        
        public string Location {get; set;}

        /*
        public list<Room> = new list<Room>(){
            //ADD ROOMS TO A LIST FOR ITERATION TO CHECK AVAILABILITY
        }; 
        */

        public Receptionist (
            string aName,
            int aId,
            string aPhoneNu,
            string aLocation
        ) {
            this.Name = aName;
            this.Id = aId;
            this.PhoneNu = aPhoneNu;
            this.Location = aLocation;
        }

    /*
        public Room BookRoom(Guest aGuest) {
            this.CheckRoomAvailability()
            // Get room number here
            //Rooms.Equals???
            //aGuest.RoomNu = 1;
            //Room aRoom = new Room(1, );
        }
        */

        public void CheckRoomAvailability() {

        }
    }
}