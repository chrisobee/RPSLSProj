using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Gesture
    {
        public string type;
        public List<string> losesTo;
        
        public Gesture(string type, List<string>losesTo)
        {
            this.type = type;
            this.losesTo = losesTo;
        }
       
    }
}