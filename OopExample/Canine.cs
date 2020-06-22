using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    public class Canine {

        public string name { get; set; } = "A stray";
        public string tailLength { get; set; } = "";
        public string furLength { get; set; } = "";
        public string color { get; set; } = "";
        public string type { get; set; } = "Canine";

        public virtual string Bark() { return "Woof!"; }
        public bool Sit() { return true; }

        public Canine() { }


    }
}
