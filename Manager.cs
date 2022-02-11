namespace hotel {
    class Manager {
        public string Name {get; set;}
        public int Id {get; set;}

        public string PhoneNu {get; set;}

        public string Location {get; set;}

        public Manager (
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

    }
}