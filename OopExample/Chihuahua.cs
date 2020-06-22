using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    public class Chihuahua : Canine {

        public override string Bark() {
            return "Squeek";
        }

        public Chihuahua(string name, string color = "Light Brown") : base() {
            type = "Chihuahua";
            tailLength = "Short";
            furLength = "Hardly any";
            this.color = color;
            this.name = name;
        }
        
    }
}
