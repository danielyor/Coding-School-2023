using System;

namespace InstituteNS {
    public class Institute {

        // Properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        // Constructors
        public Institute(Guid id, string name, int years) {
            ID = id;
            Name = name;
            YearsInService = years;
        }

        // Methods
        public void GetName() {

        }
        public void SetName(string name) {
            Name = name;
        }

    }
}
