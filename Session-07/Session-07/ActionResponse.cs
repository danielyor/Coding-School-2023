using System;

namespace Session07 {
    public class ActionResponse {

        // Properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        // Constructors
        public ActionResponse() {
            RequestID = Guid.NewGuid();
        }

    }
}
