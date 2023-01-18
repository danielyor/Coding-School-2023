using System;

namespace Session07 {
    public class ActionResponse {

        // Properties
        public Guid ResponseID { get; set; }
        public Guid RequestID { get; set; }
        public string Output { get; set; }

        // Constructors
        public ActionResponse() {
            ResponseID = Guid.NewGuid();
        }

    }
}
