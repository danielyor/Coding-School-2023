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

            Log($"Execution for Action \"{request.Action}\" started.");

            try {
                switch (request.Action) {

                    case ActionEnum.Convert:
                        bool parseSucceeded = int.TryParse(request.Input, out int dec);
                        if (parseSucceeded) {
                            string binary = Convert.ToString(dec, 2);
                            response.Output = binary.PadLeft(8, '0');
                            Log("Execution succeeded.");
                        }
                        else {
                            throw new Exception("Convert action failed, bad input.");
                        }
                        break;

                    case ActionEnum.Uppercase:
                        if (request.Input is string) {
                            response.Output = Uppercase(request.Input);
                            Log("Execution succeeded.");
                        }
                        else {
                            throw new Exception("Uppercase action failed. Input is not string type.");
                        }
                        break;

                    case ActionEnum.Reverse:
                        if (request.Input is string) {
                            response.Output = Reverse(request.Input);
                            Log("Execution succeeded.");
                        }
                        else {
                            throw new Exception("Uppercase action failed. Input is not string type.");
                        }
                        break;

                    default:
                        throw new Exception("Unknown error occured!");
                        break;

                }
            }
            catch (Exception e) {
                Log($"ERROR: {e.Message}");
            }
            finally {
                Log("Ending execution process.");
            }

            return response;
        }

        private void Log(string text) {
            Message message = new Message(text);
            Logger.Write(message);
        }

        public string Uppercase(string input) {
            string[] words = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 1) {
                return words[0].ToUpper();
            }
            else {
                int longest = 0;

                for (int i=0; i<words.Length; i++) {
                    if (words[i].Length > longest) {
                        longest = words[i].Length;
                    }
                }
                for (int i = 0; i < words.Length; i++) {
                    if (words[i].Length == longest) {
                        words[i] = words[i].ToUpper();
                    }
                }
            }

            return string.Join(" ", words);
        }

        public string Reverse(string input) {
            if (input == null || input.Length <= 1) {
                return input;
            }

            return Reverse(input.Substring(1)) + input[0];
        }

    }
}
