namespace hotel {
    class Chef {
        public string Name {get; set;}

        public int Id {get; set;}

        public string Location {get; set;}

        public Chef (
            string aName,
            int aId,
            string aLocation
        ) {
            this.Name = aName;
            this.Id = aId;
            this.Location = aLocation;

        }
    }
}