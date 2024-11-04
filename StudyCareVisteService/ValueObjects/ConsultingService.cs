using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using static Azure.Core.HttpHeader;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class ConsultingService
    {
        public bool CorrectiveConsulting { get; set; } //Does the establishment need corrective consulting? yes/no
        public string ReasonRequestingConsultation { get; set; } //Reason for requesting consultation
        public string TypeConsultation { get; set; }
        public string ConsultationRequestCriteria { get; set; }
        //[NotMapped]
        //public IFormFile? ExteriorPhotos { get; set; }
        //[NotMapped]
        //public IFormFile? InteriorPhotos { get; set; }
        //[NotMapped]
        //public IFormFile? ProductPhotos { get; set; }
        //[NotMapped]
        //public IFormFile? EmployeesPhotos { get; set; }
        //[NotMapped]
        //public IFormFile? TransportationPhotos { get; set; }
        public string NotesVisitEvaluator { get; set; }
        public string BranchManagementRecommendations { get; set; }
        public string ApprovalVisitReport { get; set; }
    }
}
