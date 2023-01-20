namespace LibUniversity {
    public class Person {

        // Properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructors
        public Person() {
            ID = Guid.NewGuid();
        }

        // Methods
        public void GetName() {

        }
        public void SetName(string name) {
            Name = name;
        }
    }
}
