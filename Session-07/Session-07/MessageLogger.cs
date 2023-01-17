using System;
using MessageNS;

namespace MessageLoggerNS {
    public class MessageLogger {

        // Properties
        public Message[] Messages { get; set; }

        // Constructor
        public MessageLogger() {
             
        }

        // Methods
        public void ReadAll() {
            // print all messages
        }
        public void Clear() {
            // clear Messages
        }
        public void Write(Message msg) {
            // push msg to Messages array
        }

    }
}
