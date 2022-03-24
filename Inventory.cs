using System;

namespace hotel {

     class Inventory { // not used for anything, could be expanded upon
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