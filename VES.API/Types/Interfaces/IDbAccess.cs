using Microsoft.Data.SqlClient;
using VES.API.Models.Domain;

namespace VES.API.Types.Interfaces
{
    public interface IDbAccess
    {
        public List<PastDue> GetPastDuesByLimit(int? page, int? pageSize);
    }
}
