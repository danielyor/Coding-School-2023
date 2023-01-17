using System;
using ActionRequestNS;
using ActionResponseNS;
using MessageLoggerNS;

namespace ActionResolverNS {

    public enum ActionEnum {
        Convert,
        Uppercase,
        Reverse
    }

    public class ActionResolver {

        // Properties
        public MessageLogger Logger { get; set; }

        // Constructor
        public ActionResolver() {

        }

        // Methods
        public ActionResponse Execute(ActionRequest request) {

            ActionResponse response = new(Guid.NewGuid(), Guid.NewGuid(), null);

            switch (request.Action) {

                case ActionEnum.Convert:
                    bool binParse = int.TryParse(request.Input, out int bin);
                    if (binParse) {
                        // convert
                        // log message
                    }
                    else {
                        Console.WriteLine("Convert action failed, bad input.");
                        // log error message
                    }
                    break;

                case ActionEnum.Uppercase:
                    // do stuff
                    break;

                case ActionEnum.Reverse:
                    // do stuff
                    break;

                default:
                    Console.WriteLine("Invalid request!");
                    // log error message
                    break;

            }

            return null;
        }


    }
}
