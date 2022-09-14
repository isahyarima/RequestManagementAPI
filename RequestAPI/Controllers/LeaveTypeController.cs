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
    [RoutePrefix("api/v1/leaveType")]
    [Authorize]
    public class LeaveTypeController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public LeaveTypeController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]LeaveTypeVM model)
        {
            try
            {
              
                var result = await _wrapper.LeaveType.CreateLeaveTypeAsync(model);

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
            
                var result = await _wrapper.LeaveType.GetLeaveType();

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
        [Route("{leaveTypeId}/leaveTypeId")]
        public async Task<IHttpActionResult> Get(int leaveTypeId)
        {
            try
            {   
              
                var result = await _wrapper.LeaveType.GetLeaveType(leaveTypeId);

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
		[Route("{leaveTypeId}/leaveTypeId")]
        public async Task<IHttpActionResult> Update([FromBody]LeaveTypeVM model, int leaveTypeId)
        {
            try
            {
                var result = await _wrapper.LeaveType.UpdateLeaveType(leaveTypeId, model);

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
		[Route("{leaveTypeId}/leaveTypeId")]
        public async Task<IHttpActionResult> Delete(int leaveTypeId)
        {
            try
            {
                var result = await _wrapper.LeaveType.DeleteLeaveType(leaveTypeId);

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


     
