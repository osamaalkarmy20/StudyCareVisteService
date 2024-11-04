using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyCareVisteService.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudyCareVists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitNumber = table.Column<int>(type: "int", nullable: false),
                    LastVisitDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CollectionEfforts_ResponsibleForCollection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionEfforts_CollectionEffort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionEfforts_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionEfforts_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    FinancialData_ProjectBudget = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_RevenuesCurrentQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_RevenuesPreviousQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_ExpensesCurrentQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_ExpensesPreviousQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NetCurrentQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NetPreviousQuarter = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NationalityNumbers = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_SaudiMale = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_SaudiFemale = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_SaudiTotal = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NonSaudiMale = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NonSaudiFemale = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_NonSaudiTotal = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_Total = table.Column<long>(type: "bigint", nullable: true),
                    FinancialData_SaudizationPercentage = table.Column<int>(type: "int", nullable: true),
                    ClassifySuccessStory_MeetCriteria = table.Column<bool>(type: "bit", nullable: true),
                    ClassifySuccessStory_PublishSuccessStory = table.Column<bool>(type: "bit", nullable: true),
                    ObservedViolations_TypeViolation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitExecutor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitExecutor_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    VisitExecutor_Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckerRepresentative_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckerRepresentative_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    CheckerRepresentative_Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessOwner_BusinessOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_SponsorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_InsuranceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_IDNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_MobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_SponsorMobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_IsDeductionMade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_AgreementNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_DisbursedPaymentsNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BusinessOwner_ProjectPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_PartnerEntity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_CommercialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_ActivitySection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_DescriptionOfTheActivity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_NationalAddressOfTheEstablishment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_AreaOfTheEstablishment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_CommercialRegistrationNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_LicenseNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_SpecialLicensesNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_ProjectPhase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_UnitNumber = table.Column<long>(type: "bigint", nullable: false),
                    BusinessOwner_SiteOwnership = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_CommercialRegistrationExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessOwner_LicenseExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessOwner_ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessOwner_ProjectStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessOwner_TransferDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollectionData_GracePeriod = table.Column<int>(type: "int", nullable: false),
                    CollectionData_DateFirstInstallment = table.Column<DateOnly>(type: "date", nullable: false),
                    CollectionData_NumberInstallmentsPaid = table.Column<int>(type: "int", nullable: false),
                    CollectionData_DateLastInstallment = table.Column<DateOnly>(type: "date", nullable: false),
                    CollectionData_AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    CollectionData_PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollectionData_PaymentPeriod = table.Column<int>(type: "int", nullable: false),
                    CollectionData_NumberOverdueInstallments = table.Column<int>(type: "int", nullable: false),
                    CollectionData_OverdueAmountNumber = table.Column<int>(type: "int", nullable: false),
                    CollectionData_DaysOverdueNumber = table.Column<int>(type: "int", nullable: false),
                    ConsultingService_CorrectiveConsulting = table.Column<bool>(type: "bit", nullable: false),
                    ConsultingService_ReasonRequestingConsultation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultingService_TypeConsultation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultingService_ConsultationRequestCriteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultingService_NotesVisitEvaluator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultingService_BranchManagementRecommendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultingService_ApprovalVisitReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyCareVists", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudyCareVists");
        }
    }
}
