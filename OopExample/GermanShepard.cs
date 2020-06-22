using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    public class GermanShepard : Canine {
        public override string Bark() {
            return "BARK!";
        }

        public GermanShepard(string name, string color) : base() {
            type = "German Shepard";
            tailLength = "Long";
            furLength = "Long";
            this.color = color;
            this.name = name;
        }
        public GermanShepard(string name) : this(name, "Brown") {

        }
    }
}
