using System;

namespace Session07 {

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
            Logger = new MessageLogger();
        }

        // Methods
        public ActionResponse Execute(ActionRequest request) {

            ActionResponse response = new();
            response.ResponseID = Guid.NewGuid();

            // log start


            try {
                switch (request.Action) {

                    case ActionEnum.Convert:
                        bool parseSucceeded = int.TryParse(request.Input, out int bin);
                        if (parseSucceeded) {
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
                        // throw exception
                        break;

                }
            }
            catch {
                // log error msg
            }
            finally {
                // log end
            }

            return response;
        }


    }
}
