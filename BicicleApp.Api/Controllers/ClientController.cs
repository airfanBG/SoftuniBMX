namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> RegisterClient([FromBody] ClientRegisterDto clientRegisterDto)
        {
            try
            {
                if (clientRegisterDto == null)
                {
                    // The clientRegisterDto object is null, so return a 400 Bad Request response
                    return StatusCode(400);       
                }

                if (!ModelState.IsValid)
                {
                    //Hide the email and password
                    clientRegisterDto.Email = "";
                    clientRegisterDto.Password = "";
                    clientRegisterDto.ConfirmPassword = "";
                    return StatusCode(422, clientRegisterDto);
                }

                //Register
                var httpScheme = Request.Scheme;
                var httpHost = Request.Host.Value;
                bool isRegistered = await clientService.RegisterClientAsync(clientRegisterDto, httpScheme, httpHost);

                if (isRegistered)
                {
                    return Ok();
                }

                //Return bad request if registration has failed
                clientRegisterDto.Email = "";
                clientRegisterDto.Password = "";
                clientRegisterDto.ConfirmPassword = "";
                return StatusCode(400, clientRegisterDto);
            }
            catch (Exception e)
            {
                if (e.Message == $"Client with email: {clientRegisterDto.Email} already exists!")
                {
                    //If the email already exists in the database
                    clientRegisterDto.Email = "";
                    clientRegisterDto.Password = "";
                    clientRegisterDto.ConfirmPassword = "";
                    return StatusCode(409, clientRegisterDto);
                }

                //Other Errors
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ClientReturnDto>> LoginClient([FromBody] ClientLoginDto clientLoginDto)
        {

            try
            {
                if (clientLoginDto == null)
                {
                    // The clientLoginDto object is null, so return a 400 Bad Request response
                    return StatusCode(400);
                }

                if (!ModelState.IsValid)
                {
                    //Hide the email and password
                    clientLoginDto.Email = "";
                    clientLoginDto.Password = "";
                    return StatusCode(422, clientLoginDto);
                }

                //Login
                var responce = await clientService.LoginClientAsync(clientLoginDto);

                if (responce.Result)
                {
                    return Ok(responce);
                }
                else
                {
                    return StatusCode(400, responce);
                }
            }
            catch (Exception)
            {
                //Other Errors
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ClientInfoDto>> GetClientInfo([FromQuery] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return StatusCode(400);
            }

            try
            {
                var dto = await clientService.GetClientInfoAsync(id);

                if (dto == null)
                {
                    return NotFound();
                }

                return Ok(dto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("password")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ChangePassword([FromBody] ClientPasswordChangeDto clientPasswordChangeDto)
        {
            if (clientPasswordChangeDto == null)
            {
                return StatusCode(400);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(422, clientPasswordChangeDto);
            }

            try
            {
                var result = await clientService.ChangeClientPasswordAsync(clientPasswordChangeDto);

                if (result)
                {
                    return StatusCode(StatusCodes.Status202Accepted);
                }
                else
                {
                    return StatusCode(422, clientPasswordChangeDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        [Route("reset")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ResetPassword([FromQuery] string email)
        {
            var result = await clientService.ResetPasswordToDefault(email);

            if (result)
            {
                return Ok();
            }

            return BadRequest();           
        }

        [HttpGet]
        [Route("emailConfirm")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EmailConfirm([FromQuery] string userId, [FromQuery] string code)
        {
            await clientService.ConfirmEmailAsync(userId, code);

            return Ok();
        }

        [HttpGet]
        [Route("bankInfo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ClientBankDto>> GetBankInfo([FromQuery] string clientId)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                return BadRequest();
            }

            try
            {
                var dto = await clientService.GetClientBankInfoAsync(clientId);

                return Ok(dto);
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("bankUpdate")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateClientBankInfo([FromBody] ClientBankDto clientBankInfo)
        {
            if (clientBankInfo == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(clientBankInfo);
            }

            try
            {
                var result = await clientService.UpdateClientBankInfoAsync(clientBankInfo);

                if (result)
                {
                    return StatusCode(204);
                }

                return BadRequest();
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("passChange")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ChangePassword([FromBody] ClientLoginDto clientDto)
        {
            if (clientDto == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(clientDto);
            }

            try
            {
                var result = await clientService.ChangePassword(clientDto);

                if (result)
                {
                    return NoContent();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
