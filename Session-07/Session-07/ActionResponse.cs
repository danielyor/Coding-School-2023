using System;

namespace Session07 {
    public class ActionResponse : ActionEntity {

        // Properties
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        // Constructors
        public ActionResponse() {
            ResponseID = Guid.NewGuid();
        }

    }
}
