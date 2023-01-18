using System;

namespace Session07 {
	public class Message {

		// Properties
		public Guid ID { get; set; }
		public DateTime TimeStamp { get; set; }
		public string MessageText { get; set; }

		// Constructor
		public Message(DateTime timestamp, string message) {
			ID = Guid.NewGuid();
			TimeStamp = timestamp;
			MessageText = message;
		}

	}
}
