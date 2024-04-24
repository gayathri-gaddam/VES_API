using Microsoft.Data.SqlClient;
using VES.API.Models.DTO;

namespace VES.API.Types.Interfaces
{
    public interface IDbAccess
    {
        public Task<List<PBDTO>> GetPastDuesByLimit(int? page, int? pageSize);
        public Task<List<NoticesDTO>> GetNoticesByLimit();
    }
}
