using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class ObservedViolations
    {
        public string TypeViolation { get; set; }


    }
}
