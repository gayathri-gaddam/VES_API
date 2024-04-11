using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VES.API.Data;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API.Types.Interfaces
{
    public interface IPastDueService
    {
        public Task<List<PastDueDto>> GetPastDues(long? entryId, long? invoiceId, long? accountNo);
        public Task<bool> UpdatePastDue(int id, JsonPatchDocument pastDueModel);
    }
}
