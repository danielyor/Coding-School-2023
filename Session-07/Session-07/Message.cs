using System;

namespace Session07 {
	public class Message {

		// Properties
		public Guid ID { get; set; }
		public DateTime TimeStamp { get; set; }
		public string MessageText { get; set; }

        // Constructors
        public Message() {
            ID = Guid.NewGuid();
        }

        public Message(string message) {
			ID = Guid.NewGuid();
			TimeStamp = DateTime.Now;
			MessageText = message;
		}

	}
}
