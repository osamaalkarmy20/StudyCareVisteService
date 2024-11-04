using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class VisitExecutor
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public string Signature { get; set; }

     
    }
}
