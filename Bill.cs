namespace hotel {
    class Bill {
        public int BillNu {get; set;}
        public string GuestName {get; set;}

        public Bill (
            int aBillNu,
            string aGuestName
        ) {
            this.BillNu = aBillNu;
            this.GuestName = aGuestName;

        }
    }
}