namespace hotel {
    class Rooms {
        public int RoomNu {get; set;}
        public string Location {get; set;}

        public Rooms (
            int aRoomNu,
            string aLocation
        ) {
            this.RoomNu = aRoomNu;
            this.Location = aLocation;
        }
    }
}