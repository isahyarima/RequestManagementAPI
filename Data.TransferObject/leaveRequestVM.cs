


namespace Data.TransferObject.ViewModel
{

public class LeaveRequestVM
{
	public int leaveRequestId { get; set; }
	public int? leaveTypeId { get; set; }
	public int? studentId { get; set; }
	public System.DateTime? startDate { get; set; }
	public System.DateTime? resumptionDate { get; set; }
	public string description { get; set; }
	public System.DateTime? dateCreated { get; set; }
	public int? termId { get; set; }
	public int? academicYearId { get; set; }
}

}

     
