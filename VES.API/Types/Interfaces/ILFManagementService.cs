
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Types.Interfaces
{
    public interface ILFManagementService
    {
        Task<List<LFManagementDTO>> GetAllLF(long Id,long AccountNo);
        Task<bool> UpdateLF(int Id, JsonPatchDocument lfModel);
    }
}
