using Data.TransferObject.ViewModel;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Wrapper.Admin;

namespace careapi.Controllers
{
    [RoutePrefix("api/v1/requestDocumentUpload")]
    [Authorize]
    public class RequestDocumentUploadController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public RequestDocumentUploadController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]RequestDocumentUploadVM model)
        {
            try
            {
               
                var result = await _wrapper.RequestDocumentUpload.CreateRequestDocumentUploadAsync(model);

                if (result != null)
                {
                     return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }

        [HttpGet]
        [Route("")]
        public async  Task<IHttpActionResult> Get()
        {
            try
            {
               
                var result = await _wrapper.RequestDocumentUpload.GetRequestDocumentUpload();

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }


		
        [HttpGet]
        [Route("{requestDocumentUploadId}/requestDocumentUploadId")]
        public async Task<IHttpActionResult> Get(int requestDocumentUploadId)
        {
            try
            {   
              
                var result = await _wrapper.RequestDocumentUpload.GetRequestDocumentUpload(requestDocumentUploadId);

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }

        [HttpPut]
		[Route("{requestDocumentUploadId}/requestDocumentUploadId")]
        public async Task<IHttpActionResult> Update([FromBody]RequestDocumentUploadVM model, int requestDocumentUploadId)
        {
            try
            {
                var result = await _wrapper.RequestDocumentUpload.UpdateRequestDocumentUpload(requestDocumentUploadId, model);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }
        [HttpDelete]
		[Route("{requestDocumentUploadId}/requestDocumentUploadId")]
        public async Task<IHttpActionResult> Delete(int requestDocumentUploadId)
        {
            try
            {
                var result = await _wrapper.RequestDocumentUpload.DeleteRequestDocumentUpload(requestDocumentUploadId);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }
    }
}


     
