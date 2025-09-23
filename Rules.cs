using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolUnoProject
{
    public class Rules
    {
        public bool StackP2Card;
        public bool StackP4Card;
        public Rules(string ruleset) 
        { 
            if (ruleset=="Classic")
            {
                StackP2Card = false;
                StackP4Card = false;
            }
        }


    }
}
