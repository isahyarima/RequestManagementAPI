


namespace Data.TransferObject.ViewModel
{

public class RequestDocumentUploadVM
{
	public int requestUploadId { get; set; }
	public int? documentTypeId { get; set; }
	public string fileName { get; set; }
	public string fileType { get; set; }
	public string fileExtention { get; set; }
	public string fileLink { get; set; }
	public byte[] fileData { get; set; }
	public int? targetId { get; set; }
	public string description { get; set; }
	public System.DateTime? dateCreated { get; set; }
	public string referenceNumber { get; set; }
	public bool? isDocumentVerified { get; set; }
	public int? requestId { get; set; }
}

}

     
