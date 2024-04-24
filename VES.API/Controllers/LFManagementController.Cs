using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

using VES.API.Data;
using VES.API.Models.DTO;
using VES.API.Services;
using VES.API.Types.Interfaces;

namespace VES.API.Controllers
{
    [ApiController]
    [Route("/api/v1/lateFees")]
    public class LFManagementController : ControllerBase
    {
        private readonly ILFManagementService _lfService;

        public LFManagementController(ILFManagementService _lfService)
        {
            this._lfService = _lfService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLF([FromQuery] long Id, [FromQuery] long AccountNo)
        {
            try
            {
                List<LFManagementDTO> lfs = await _lfService.GetAllLF(Id,AccountNo);
                if (lfs != null && lfs.Count > 0)
                {
                    return Ok(lfs);
                }
                else
                {
                    return NotFound("LateFees not found with given filter");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPatch("{Id}")]
        public async Task<IActionResult> UpdateLF([FromRoute] int Id, [FromBody] JsonPatchDocument lfModel)
        {
            try
            {
                bool result = await _lfService.UpdateLF(Id, lfModel);
                if (result)
                {
                    return Ok("LateFees successfully updated");
                }
                else
                {
                    return NotFound("LateFees not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
