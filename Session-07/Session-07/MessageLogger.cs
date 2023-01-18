using System;

namespace Session07 {
    public class MessageLogger {

        // Properties
        public Message[] Messages { get; set; }
        private int _messageCounter = 0;

        // Constructor
        public MessageLogger() {
            Messages = new Message[1000];
        }

        // Methods
        public void ReadAll() {
            foreach (Message message in Messages) {
                if (message != null) {
                    Console.WriteLine(message.MessageText);
                }
            }
        }
        public void Clear() {
            Messages = new Message[1000];
            _messageCounter = 0;
        }
        public void Write(Message msg) {
            Messages[_messageCounter] = msg;
            _messageCounter++;
        }

    }
}
