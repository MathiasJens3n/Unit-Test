using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class PinValidator
    {
        private string correctPIN;

        public PinValidator(string correctPIN)
        {
            correctPIN = correctPIN;
        }
        public bool ValidatePIN(string enteredPIN)
        {
            return correctPIN.Equals(enteredPIN);
        }
    }
}
