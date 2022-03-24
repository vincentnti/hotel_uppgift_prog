namespace hotel {
    class Manager : Person{
        public string PhoneNu {get; set;}

        public Manager (
            string aName,
            int aId,
            string aPhoneNu,
            string aLocation
        ) {
            this.Name = aName;
            this.Id = aId;
            this.PhoneNu = aPhoneNu;
        }

    }
}