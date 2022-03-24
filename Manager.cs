namespace hotel {
    class Manager : Person{ // Not used for anything at the moment, could be used to expand the scope of the project in the future.
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