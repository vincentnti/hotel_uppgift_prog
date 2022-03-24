namespace hotel {
    class Room {
        public int RoomNu {get; set;}

        public bool RoomAvailable {get; set;} = true;

        public Room (
            int aRoomNu,
            bool aRoomAvailable
           
        ) {
            this.RoomNu = aRoomNu;
            this.RoomAvailable = aRoomAvailable;
        }
    }
}