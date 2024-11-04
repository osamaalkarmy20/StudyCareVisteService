

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class ClassifySuccessStory
    {
        public bool MeetCriteria { get; set; } //Does the establishment meet the criteria for a success story? yes/no
        public bool PublishSuccessStory { get; set; } //Do THE CLIENT want to publish the success story? yes/no


      

      
    }
}
