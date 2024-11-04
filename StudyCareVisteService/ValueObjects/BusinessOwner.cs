
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCareVisteService.ValueObjects
{
    [Owned]

    public class BusinessOwner
    {
        public string BusinessOwnerName { get; set; } 
        public string Email { get; set; }
        public string SponsorName { get; set; }
        public string InsuranceType { get; set; }
        public long IDNumber { get; set; }
        public string MobileNumber { get; set; }
        public string SponsorMobileNumber { get; set; }
        public bool IsDeductionMade { get; set; }
        public long AgreementNumber { get; set; }
        public decimal DisbursedPaymentsNumber { get; set; }
        public string ProjectPath { get; set; }
        public string PartnerEntity { get; set; }
        public string CommercialName { get; set; }
        public string ActivitySection { get; set; }
        public string DescriptionOfTheActivity { get; set; }
        public string NationalAddressOfTheEstablishment { get; set; }
        public string AreaOfTheEstablishment { get; set; }
        public long CommercialRegistrationNumber { get; set; }
        public long LicenseNumber { get; set; }

        public long SpecialLicensesNumber { get; set; }
        public string ProjectPhase { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string StreetName { get; set; }
        public long UnitNumber { get; set; }
        public string SiteOwnership { get; set; }
        public DateOnly CommercialRegistrationExpiryDate { get; set; }
        public DateOnly LicenseExpiryDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string ProjectStatus { get; set; }
        public DateOnly TransferDate { get; set; }


       
      
    }

  
}
