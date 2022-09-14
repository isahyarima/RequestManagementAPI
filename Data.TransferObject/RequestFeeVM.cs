


namespace Data.TransferObject.ViewModel
{

public class RequestFeeVM
{
	public int requestFeeId { get; set; }
	public int? requestTypeId { get; set; }
	public decimal? fee { get; set; }
	public System.DateTime? dateCreated { get; set; }
	public bool? isApproved { get; set; }
	public int? termId { get; set; }
	public int? academicYearId { get; set; }
}

}

     
