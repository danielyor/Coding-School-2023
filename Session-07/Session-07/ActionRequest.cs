using System;

namespace Session07 {
    public class ActionRequest : ActionEntity {

        // Properties
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
