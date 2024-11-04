using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class FinancialData
    {
        public long ProjectBudget { get; set; }
        public long RevenuesCurrentQuarter { get; set; }
        public long RevenuesPreviousQuarter { get; set; }
        public long ExpensesCurrentQuarter { get; set; }
        public long ExpensesPreviousQuarter { get; set; }
        public long NetCurrentQuarter { get; set; }
        public long NetPreviousQuarter { get; set; }
        #region User Input
        public long NationalityNumbers { get; set; }
        public long SaudiMale { get; set; }
        public long SaudiFemale { get; set; }
        public long SaudiTotal { get; set; }
        public long NonSaudiMale { get; set; }
        public long NonSaudiFemale { get; set; }
        public long NonSaudiTotal { get; set; }
        public long Total { get; set; }
        public int SaudizationPercentage { get; set; }
        #endregion
    }
}
