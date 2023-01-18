using System;

namespace Session07 {
    public class ActionRequest {

        // Properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        // Constructor
        public ActionRequest(string input, ActionEnum action) {
            RequestID = Guid.NewGuid();
            Input = input;
            Action = action;
        }

    }
}
