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
                        bool parseSucceeded = int.TryParse(request.Input, out int dec);
                        if (parseSucceeded) {
                            // convert to binary

                            // log message. Use someString.PadLeft(8, '0'); in response
                        }
                        else {
                            Console.WriteLine("Convert action failed, bad input.");

                            // log error message
                        }
                        break;

                    case ActionEnum.Uppercase:
                        // check if input is string

                        // if there is a space, return the longest word in uppercase

                        // else return string in uppercase
                        break;

                    case ActionEnum.Reverse:
                        Console.WriteLine(Reverse(request.Input));
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

        public string Reverse(string input) {
            string[] str = new string[input.Length];
            int i = 0;

            if ((input == null) || (input.Length <= 1)) {
                str[i] = input;
            }
            else {
                //Console.Write(str[str.Length - 1]);
                str[input.Length - 1] = input;
                Reverse(input.Substring(0, (str.Length - 1)));
            }

            return string.Join("", str);
        }

    }
}
