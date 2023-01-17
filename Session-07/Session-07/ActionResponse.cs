using System;

namespace ActionResponseNS {
    public class ActionResponse {

        // Properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        // Constructors
        public ActionResponse(Guid reqID, Guid resID, string output) {
            RequestID = reqID;
            ResponseID = resID;
            Output = output;
        }
        public ActionResponse() {

        }
    }
}
