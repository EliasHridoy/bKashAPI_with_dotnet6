using B2BAPI.Models.Bkash;
using bKashAPI_with_dotnet6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bKashAPI_with_dotnet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bKashController : ControllerBase
    {
        private readonly IbKashService _bKashService;
        public bKashController(IbKashService bKashService)
        {
            _bKashService = bKashService;
        }
        [HttpGet("getGenerateTokenBkash")]
        public async Task<IActionResult> getGenerateTokenBkash()
        {
            try
            {
                var data = await _bKashService.getGenerateTokenBkash();
                return Ok(data);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null) return BadRequest(ex.InnerException.Message);
                else return BadRequest(ex.Message);
            }
        }
        [HttpPost("CreatePayment")]
        public async Task<IActionResult> getPaymentCreateBkash(BkashModel model)
        {
            try
            {
                var data = await _bKashService.getPaymentCreateBkash(model);
                return Ok(data);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null) return BadRequest(ex.InnerException.Message);
                else return BadRequest(ex.Message);
            }
        }
        [HttpPost("ExecutePayment")]
        public async Task<IActionResult> getPaymentExecuteBkash(BkashModel model)
        {
            try
            {
                var data = await _bKashService.getPaymentExecuteBkash(model);
                return Ok(data);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null) return BadRequest(ex.InnerException.Message);
                else return BadRequest(ex.Message);
            }
        }
    }
}
