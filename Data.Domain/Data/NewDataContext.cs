using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Domain.Data
{
    public partial class NewDataContext : DbContext
    {
        public NewDataContext()
            : base("name=NewDataContext")
        {
        }

        public virtual DbSet<Academic_AssessmentTool> Academic_AssessmentTool { get; set; }
        public virtual DbSet<Academic_Calendar> Academic_Calendar { get; set; }
        public virtual DbSet<Academic_CourseAssessmentPercentage> Academic_CourseAssessmentPercentage { get; set; }
        public virtual DbSet<Academic_CourseAssessmentTypeSetting> Academic_CourseAssessmentTypeSetting { get; set; }
        public virtual DbSet<Academic_CourseDefinition> Academic_CourseDefinition { get; set; }
        public virtual DbSet<Academic_CourseRegistration> Academic_CourseRegistration { get; set; }
        public virtual DbSet<Academic_CourseSchedule> Academic_CourseSchedule { get; set; }
        public virtual DbSet<Academic_Curriculum> Academic_Curriculum { get; set; }
        public virtual DbSet<Academic_DegreeProgramme> Academic_DegreeProgramme { get; set; }
        public virtual DbSet<Academic_DegreeType> Academic_DegreeType { get; set; }
        public virtual DbSet<Academic_Department> Academic_Department { get; set; }
        public virtual DbSet<Academic_Faculty> Academic_Faculty { get; set; }
        public virtual DbSet<Academic_Grade> Academic_Grade { get; set; }
        public virtual DbSet<Academic_GradePointAverage> Academic_GradePointAverage { get; set; }
        public virtual DbSet<Academic_GraduationPlan> Academic_GraduationPlan { get; set; }
        public virtual DbSet<Academic_Level> Academic_Level { get; set; }
        public virtual DbSet<Academic_OLevelSubject> Academic_OLevelSubject { get; set; }
        public virtual DbSet<Academic_PaymentChannel> Academic_PaymentChannel { get; set; }
        public virtual DbSet<Academic_PaymentType> Academic_PaymentType { get; set; }
        public virtual DbSet<Academic_ResultPosting> Academic_ResultPosting { get; set; }
        public virtual DbSet<Academic_Semester> Academic_Semester { get; set; }
        public virtual DbSet<Academic_Session> Academic_Session { get; set; }
        public virtual DbSet<Academic_TeachingMethod> Academic_TeachingMethod { get; set; }
        public virtual DbSet<AcademicActiveSemesterMaster> AcademicActiveSemesterMaster { get; set; }
        public virtual DbSet<AcademicActivitiesCalendarMaster> AcademicActivitiesCalendarMaster { get; set; }
        public virtual DbSet<AcademicActivityType> AcademicActivityType { get; set; }
        public virtual DbSet<AcademicYearCalendarMaster> AcademicYearCalendarMaster { get; set; }
        public virtual DbSet<Admin_DocumentType> Admin_DocumentType { get; set; }
        public virtual DbSet<Admin_DocumentUpload> Admin_DocumentUpload { get; set; }
        public virtual DbSet<Admin_LoginActivity> Admin_LoginActivity { get; set; }
        public virtual DbSet<Admin_Operation> Admin_Operation { get; set; }
        public virtual DbSet<Admin_Role> Admin_Role { get; set; }
        public virtual DbSet<Admin_Tenant> Admin_Tenant { get; set; }
        public virtual DbSet<Admission_Agent> Admission_Agent { get; set; }
        public virtual DbSet<Admission_RequireDocument> Admission_RequireDocument { get; set; }
        public virtual DbSet<Admission_Requirement> Admission_Requirement { get; set; }
        public virtual DbSet<Admission_SubjectCombinationRequirement> Admission_SubjectCombinationRequirement { get; set; }
        public virtual DbSet<AdmissionCalendarMaster> AdmissionCalendarMaster { get; set; }
        public virtual DbSet<Application_CoursePriority> Application_CoursePriority { get; set; }
        public virtual DbSet<Application_Declaration> Application_Declaration { get; set; }
        public virtual DbSet<Application_DocumentUpload> Application_DocumentUpload { get; set; }
        public virtual DbSet<Application_IJMB> Application_IJMB { get; set; }
        public virtual DbSet<Application_JAMB> Application_JAMB { get; set; }
        public virtual DbSet<Application_MeansOfIdentification> Application_MeansOfIdentification { get; set; }
        public virtual DbSet<Application_MediaSource> Application_MediaSource { get; set; }
        public virtual DbSet<Application_Olevel> Application_Olevel { get; set; }
        public virtual DbSet<Application_ProgrammeChoise> Application_ProgrammeChoise { get; set; }
        public virtual DbSet<Application_Step> Application_Step { get; set; }
        public virtual DbSet<Application_Student> Application_Student { get; set; }
        public virtual DbSet<Application_StudentAddress> Application_StudentAddress { get; set; }
        public virtual DbSet<Application_StudentContact> Application_StudentContact { get; set; }
        public virtual DbSet<Application_TOC> Application_TOC { get; set; }
        public virtual DbSet<Application_Undergraduate> Application_Undergraduate { get; set; }
        public virtual DbSet<HR_Designation> HR_Designation { get; set; }
        public virtual DbSet<HR_Employee> HR_Employee { get; set; }
        public virtual DbSet<HR_EmployeeAcademicRecord> HR_EmployeeAcademicRecord { get; set; }
        public virtual DbSet<HR_EmployeeAward> HR_EmployeeAward { get; set; }
        public virtual DbSet<HR_EmployeeBank> HR_EmployeeBank { get; set; }
        public virtual DbSet<HR_EmployeeContact> HR_EmployeeContact { get; set; }
        public virtual DbSet<HR_EmployeeCrimeRecord> HR_EmployeeCrimeRecord { get; set; }
        public virtual DbSet<HR_EmployeeDepartment> HR_EmployeeDepartment { get; set; }
        public virtual DbSet<HR_EmployeeExperience> HR_EmployeeExperience { get; set; }
        public virtual DbSet<HR_EmployeeFather> HR_EmployeeFather { get; set; }
        public virtual DbSet<HR_EmployeeFitness> HR_EmployeeFitness { get; set; }
        public virtual DbSet<HR_EmployeeHealthInsurance> HR_EmployeeHealthInsurance { get; set; }
        public virtual DbSet<HR_EmployeeIdentification> HR_EmployeeIdentification { get; set; }
        public virtual DbSet<HR_EmployeeMother> HR_EmployeeMother { get; set; }
        public virtual DbSet<HR_EmployeeNextOfKin> HR_EmployeeNextOfKin { get; set; }
        public virtual DbSet<HR_EmployeePassport> HR_EmployeePassport { get; set; }
        public virtual DbSet<HR_EmployeeReferees> HR_EmployeeReferees { get; set; }
        public virtual DbSet<HR_EmployeeSpouse> HR_EmployeeSpouse { get; set; }
        public virtual DbSet<HR_EmployeeSupervisor> HR_EmployeeSupervisor { get; set; }
        public virtual DbSet<HR_EmployeeTeam> HR_EmployeeTeam { get; set; }
        public virtual DbSet<HR_EmployeeType> HR_EmployeeType { get; set; }
        public virtual DbSet<HR_HealthInsurancePlan> HR_HealthInsurancePlan { get; set; }
        public virtual DbSet<HR_Identification> HR_Identification { get; set; }
        public virtual DbSet<HR_IdentificationType> HR_IdentificationType { get; set; }
        public virtual DbSet<HR_InsuranceCompany> HR_InsuranceCompany { get; set; }
        public virtual DbSet<HR_LeaveAnnualPlan> HR_LeaveAnnualPlan { get; set; }
        public virtual DbSet<HR_LeaveBook> HR_LeaveBook { get; set; }
        public virtual DbSet<HR_LeaveDays> HR_LeaveDays { get; set; }
        public virtual DbSet<HR_LeaveHandOver> HR_LeaveHandOver { get; set; }
        public virtual DbSet<HR_LeaveType> HR_LeaveType { get; set; }
        public virtual DbSet<HR_MembershipAndClub> HR_MembershipAndClub { get; set; }
        public virtual DbSet<HR_MilitaryService> HR_MilitaryService { get; set; }
        public virtual DbSet<HR_NationalYouthService> HR_NationalYouthService { get; set; }
        public virtual DbSet<HR_PensionAdministrator> HR_PensionAdministrator { get; set; }
        public virtual DbSet<HR_Relationship> HR_Relationship { get; set; }
        public virtual DbSet<HR_SalaryAdvance> HR_SalaryAdvance { get; set; }
        public virtual DbSet<HR_SalaryAllowance> HR_SalaryAllowance { get; set; }
        public virtual DbSet<HR_SalaryDeduction> HR_SalaryDeduction { get; set; }
        public virtual DbSet<HR_SalaryGradeMapping> HR_SalaryGradeMapping { get; set; }
        public virtual DbSet<HR_SalaryPayment> HR_SalaryPayment { get; set; }
        public virtual DbSet<HR_SalaryTemplate> HR_SalaryTemplate { get; set; }
        public virtual DbSet<HR_Team> HR_Team { get; set; }
        public virtual DbSet<MIS_Fitness> MIS_Fitness { get; set; }
        public virtual DbSet<MIS_Identification> MIS_Identification { get; set; }
        public virtual DbSet<MIS_Student> MIS_Student { get; set; }
        public virtual DbSet<MIS_StudentAddress> MIS_StudentAddress { get; set; }
        public virtual DbSet<MIS_StudentAdmission> MIS_StudentAdmission { get; set; }
        public virtual DbSet<MIS_StudentAdmissionNumber> MIS_StudentAdmissionNumber { get; set; }
        public virtual DbSet<MIS_StudentContact> MIS_StudentContact { get; set; }
        public virtual DbSet<MIS_StudentEnrolment> MIS_StudentEnrolment { get; set; }
        public virtual DbSet<MIS_StudentGuardian> MIS_StudentGuardian { get; set; }
        public virtual DbSet<MIS_StudentParent> MIS_StudentParent { get; set; }
        public virtual DbSet<Payroll_Grade> Payroll_Grade { get; set; }
        public virtual DbSet<Payroll_GradeLevel> Payroll_GradeLevel { get; set; }
        public virtual DbSet<Setup_BloodGroup> Setup_BloodGroup { get; set; }
        public virtual DbSet<Setup_Certification> Setup_Certification { get; set; }
        public virtual DbSet<Setup_ChartOfAccount> Setup_ChartOfAccount { get; set; }
        public virtual DbSet<Setup_Country> Setup_Country { get; set; }
        public virtual DbSet<Setup_Department> Setup_Department { get; set; }
        public virtual DbSet<Setup_DepartmentUnit> Setup_DepartmentUnit { get; set; }
        public virtual DbSet<Setup_GeneralLedger> Setup_GeneralLedger { get; set; }
        public virtual DbSet<Setup_GeneralLedgerSub> Setup_GeneralLedgerSub { get; set; }
        public virtual DbSet<Setup_LocalGovt> Setup_LocalGovt { get; set; }
        public virtual DbSet<Setup_MeansOfIdentification> Setup_MeansOfIdentification { get; set; }
        public virtual DbSet<Setup_MediaSource> Setup_MediaSource { get; set; }
        public virtual DbSet<Setup_State> Setup_State { get; set; }
        public virtual DbSet<Academic_CourseCategory> Academic_CourseCategory { get; set; }
        public virtual DbSet<Academic_GraduationPlanTemplate> Academic_GraduationPlanTemplate { get; set; }
        public virtual DbSet<Academic_PaymentTransaction> Academic_PaymentTransaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HR_EmployeeAward>()
                .Property(e => e.CashPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_EmployeeNextOfKin>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<HR_HealthInsurancePlan>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryAdvance>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryAllowance>()
                .Property(e => e.Allowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryDeduction>()
                .Property(e => e.Deduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.GrossWage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.TotalDeduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.OvertimeRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.TotalOvertimeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryPayment>()
                .Property(e => e.NetWage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryTemplate>()
                .Property(e => e.BasicSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HR_SalaryTemplate>()
                .Property(e => e.Overtime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Setup_GeneralLedgerSub>()
                .Property(e => e.ServiceCost)
                .HasPrecision(19, 4);
        }
    }
}
