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
    [RoutePrefix("api/v1/requestType")]
    [Authorize]
    public class RequestTypeController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public RequestTypeController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]RequestTypeVM model)
        {
            try
            {
              
                var result = await _wrapper.RequestType.CreateRequestTypeAsync(model);

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
             
                var result = await _wrapper.RequestType.GetRequestType();

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
        [Route("{requestTypeId}/requestTypeId")]
        public async Task<IHttpActionResult> Get(int requestTypeId)
        {
            try
            {   
                                   var tokenIdentity = new ClaimsIdentity(HttpContext.Current.User.Identity);
                var decryptedToken = tokenIdentity.Claims;

                var tenant = decryptedToken.FirstOrDefault(st => st.Type == "tenantId").Value;

                int tenantId = 0;

                if (tenant != null)
                    tenantId = Convert.ToInt32(tenant);

                var result = await _wrapper.RequestType.GetRequestType(requestTypeId);

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
		[Route("{requestTypeId}/requestTypeId")]
        public async Task<IHttpActionResult> Update([FromBody]RequestTypeVM model, int requestTypeId)
        {
            try
            {
                var result = await _wrapper.RequestType.UpdateRequestType(requestTypeId, model);

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
		[Route("{requestTypeId}/requestTypeId")]
        public async Task<IHttpActionResult> Delete(int requestTypeId)
        {
            try
            {
                var result = await _wrapper.RequestType.DeleteRequestType(requestTypeId);

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


     
