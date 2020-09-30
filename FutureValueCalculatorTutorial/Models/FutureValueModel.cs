using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace FutureValueCalculatorTutorial.Models {
    public class FutureValueModel {
        [Required(ErrorMessage = "Please enter a monthly investment.")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter an interest rate.")]
        public decimal? YearlyInterestRate { get; set; }
        
        [Required(ErrorMessage = "Please enter the number of years.")]
        public int? Years { get; set; }

        public decimal? Calculate() {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;

            for (int i = 0; i < months; i++) {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}
