using System;

namespace MessageNS {
	public class Message {

		// Properties
		public Guid ID { get; set; }
		public DateTime TimeStamp { get; set; }
		public string MessageText { get; set; }

		// Constructor
		public Message(Guid id, DateTime timestamp, string message) {
			ID = id;
			TimeStamp = timestamp;
			MessageText = message;
		}

	}
}
