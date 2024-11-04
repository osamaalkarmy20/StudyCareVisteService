using StudyCareVisteService.Abstraction.Aggregate;
using StudyCareVisteService.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;


namespace StudyCareVisteService.Model
{
    public class StudyCareVist : Aggregate<Guid>
    {
      
   
        #region user Input -->>> 
        public int VisitNumber { get; set; }
        public DateOnly LastVisitDate { get; set; }
        public CollectionEfforts? CollectionEfforts { get;  set; }
        public FinancialData? FinancialData { get;  set; }
        public ClassifySuccessStory? ClassifySuccessStory { get; set; }
        public ObservedViolations? ObservedViolations { get;  set; }
        public VisitExecutor? VisitExecutor { get;  set; }
        public CheckerRepresentative? CheckerRepresentative { get; set; }
        #endregion

        #region Integration Input -->>> 
        public BusinessOwner BusinessOwner { get; set; }
        public CollectionData CollectionData { get; set; }
        public ConsultingService ConsultingService { get; set; }
        #endregion

    }
}
