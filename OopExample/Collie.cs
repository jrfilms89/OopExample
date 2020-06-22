using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    public class Collie : Canine {
        public bool isLassie { get; set; } = false;
        
        public override string Bark() { return $"Yip!"; }

        public string Herding() { return "is herding"; }


        public Collie(string name, string color = "Varies") : base() {
            type = "Collie";
            tailLength = "Long";
            furLength = "Long";
            this.color = color;
            this.name = name;
        }
    }
}
