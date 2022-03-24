using System;

namespace hotel {

     class Inventory {
        public string Type {get; set;}

        public int Status {get; set;}

        public Inventory (
            string aType,
            int aStatus
            
        ) {
            this.Type = aType;
            this.Status = aStatus;
        }
    }
}