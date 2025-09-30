using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devopswebapp.Models
{
    public class Calculator
    {
        [Display( Name = "First Number" )]
        public double NumberA { get; set; }

        [Display( Name = "Second Number" )]
        public double NumberB { get; set; }

        [Display( Name = "Total Value" )]
        public double Total { get; set; }
    }

    public class Calculation
    {
        Calculator calcModel;
        public Calculation()
        {
            calcModel = new Calculator();
        }

        public double AddTwoValues(double valOne, double valTwo)
        {
            return valOne + valTwo;
        }
    }
}