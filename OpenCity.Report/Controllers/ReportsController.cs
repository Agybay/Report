using Microsoft.AspNetCore.Mvc;
using OpenCity.Report.Contracts;
using OpenCity.Report.Infrastructure.Impl.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace OpenCity.Report.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase {



        [HttpPost("/RegistrationNotice")]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestObjectResult), StatusCodes.Status400BadRequest)]
        [SwaggerOperation("Создать документ Извещение о регистрации")]
        public async Task<IActionResult> CreateRegistrationNotice(RegistrationNoticeDto model, CancellationToken cancellationToken) {
            var document = new RegistrationNoticeModel() {
                Date = model.Date,
                ApplicantNameOrOrganizaionName = model.ApplicantNameOrOrganizaionName,
                RegistrationNumber = model.RegistrationNumber
            };

            return new OkObjectResult(new byte[0]);
        }
    }
}
