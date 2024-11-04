

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class CollectionData
    {
        public int GracePeriod { get; set; }//MONTHS
        public DateOnly DateFirstInstallment { get; set; }
        public int NumberInstallmentsPaid { get; set; }
        public DateOnly DateLastInstallment { get; set; }
        public long AmountPaid { get; set; }
        public string PaymentStatus { get; set; }
        public int PaymentPeriod { get; set; } //MONTHS
        public int NumberOverdueInstallments { get; set; }
        public int OverdueAmountNumber { get; set; }
        public int DaysOverdueNumber { get; set; }

   
      
    }
}
