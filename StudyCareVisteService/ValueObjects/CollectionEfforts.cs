using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class CollectionEfforts
    {
        public string ResponsibleForCollection { get; set; }
        public string CollectionEffort { get; set; }
        public string Type { get; set; }
        public DateOnly Date { get; set; }


    }
}
