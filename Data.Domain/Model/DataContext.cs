namespace Data.Domain.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<ApprovalStatus> ApprovalStatus { get; set; }
        public virtual DbSet<ExamRequest> ExamRequest { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequest { get; set; }
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<RequestApprovalSetup> RequestApprovalSetup { get; set; }
        public virtual DbSet<RequestApprovalTrail> RequestApprovalTrail { get; set; }
        public virtual DbSet<RequestCategory> RequestCategory { get; set; }
        public virtual DbSet<RequestCondition> RequestCondition { get; set; }
        public virtual DbSet<RequestDescription> RequestDescription { get; set; }
        public virtual DbSet<RequestDocumentUpload> RequestDocumentUpload { get; set; }
        public virtual DbSet<RequestFee> RequestFee { get; set; }
        public virtual DbSet<RequestReason> RequestReason { get; set; }
        public virtual DbSet<RequestType> RequestType { get; set; }
        public virtual DbSet<RequiredFee> RequiredFee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestFee>()
                .Property(e => e.Fee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RequiredFee>()
                .Property(e => e.Fee)
                .HasPrecision(19, 4);
        }
    }
}
