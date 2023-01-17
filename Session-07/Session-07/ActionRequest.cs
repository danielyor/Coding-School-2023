using System;
using ActionResolverNS;

namespace ActionRequestNS {
    public class ActionRequest {

        // Properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        // Constructor
        public ActionRequest(Guid reqID, string input, ActionEnum action) {
            RequestID = reqID;
            Input = input;
            Action = action;
        }

    }
}
