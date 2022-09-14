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
    [RoutePrefix("api/v1/examRequest")]
    [Authorize]
    public class ExamRequestController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public ExamRequestController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]ExamRequestVM model)
        {
            try
            {
                var result = await _wrapper.ExamRequest.CreateExamRequestAsync(model);

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> Get()
        {
            try
            {
               
                var result = await _wrapper.ExamRequest.GetExamRequest();

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }

        [HttpGet]
        [Route("{examRequestId}/examRequestId")]
        public async Task<IHttpActionResult> Get(int examRequestId)
        {
            try
            {

                var result = await _wrapper.ExamRequest.GetExamRequest(examRequestId);

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }

        [HttpPut]
        [Route("{examRequestId}/examRequestId")]
        public async Task<IHttpActionResult> Update([FromBody]ExamRequestVM model, int examRequestId)
        {
            try
            {
                var result = await _wrapper.ExamRequest.UpdateExamRequest(examRequestId, model);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }
        [HttpDelete]
        [Route("{examRequestId}/examRequestId")]
        public async Task<IHttpActionResult> Delete(int examRequestId)
        {
            try
            {
                var result = await _wrapper.ExamRequest.DeleteExamRequest(examRequestId);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }
    }
}



