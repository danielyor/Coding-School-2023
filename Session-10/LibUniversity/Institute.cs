﻿namespace LibUniversity {
    public class Institute {

        // Properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        // Constructors
        public Institute() {
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