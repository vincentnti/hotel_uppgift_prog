namespace hotel {
    class Room {
        public int RoomNu {get; set;}
        public string Location {get; set;}

        public Room (
            int aRoomNu,
            string aLocation
        ) {
            this.RoomNu = aRoomNu;
            this.Location = aLocation;
        }
    }
}