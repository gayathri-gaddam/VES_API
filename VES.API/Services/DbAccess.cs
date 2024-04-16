using Microsoft.Data.SqlClient;
using VES.API.Models.Domain;
using VES.API.Types.Interfaces;


namespace VES.API.Services
{
    public class DbAccess:IDbAccess
    {
        private readonly string _connectionString;
        public DbAccess(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<PastDue> GetPastDuesByLimit(int? page, int? pageSize)
        {
            List<PastDue> UserList = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT top 10 vi.SiteID AS[siteId],vi.InvoiceID AS[invoiceId],vi.[PostingDate] AS[postingDate],
                vi.[CurrentAmount] AS[currentAmount],vi.[PriorBalance] AS[priorBalance],vi.[InvoiceDate] AS[invoiceDate],
                vn.ImpactDate AS[impactDate],vn.NoticeDate AS[noticeDate],vn.ImpactAmount AS[impactAmount] 
                FROM OneSitePMC.vesInvoice as vi INNER JOIN OneSitePMC.vesNotice as vn on vi.CDSPMCID = vn.CDSPMCID 
                ORDER BY vi.InvoiceID" ;
                SqlCommand command = new(query, connection);
                /*command.Parameters.AddWithValue("@Page", page);
                command.Parameters.AddWithValue("@PageSize", pageSize);*/
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    UserList = GetPastDuesFromReader(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error getting PastDues from database", ex);
                }
            }
            return UserList;
        }


        private List<PastDue> GetPastDuesFromReader(SqlDataReader reader)
        {
            List<PastDue> pastDues = new List<PastDue>();

            while (reader.Read())
            {
                PastDue pastDue = new PastDue();

                if (reader["siteId"] != DBNull.Value)
                {
                    pastDue.siteId = Convert.ToInt32(reader["siteId"]);
                }

                if (reader["invoiceId"] != DBNull.Value)
                {
                    pastDue.invoiceId = Convert.ToInt32(reader["invoiceId"]);
                }

                if (reader["postingDate"] != DBNull.Value)
                {
                    pastDue.postingDate = reader["postingDate"].ToString();
                }

                if (reader["currentAmount"] != DBNull.Value)
                {
                    pastDue.currentAmount = Convert.ToInt32(reader["currentAmount"]);
                }

                if (reader["priorBalance"] != DBNull.Value)
                {
                    pastDue.priorBalance = Convert.ToInt32(reader["priorBalance"]);
                }

                if (reader["invoiceDate"] != DBNull.Value)
                {
                    pastDue.invoiceDate = reader["invoiceDate"].ToString();
                }

                if (reader["noticeDate"] != DBNull.Value)
                {
                    pastDue.noticeDate = reader["noticeDate"].ToString();
                }

                if (reader["impactDate"] != DBNull.Value)
                {
                    pastDue.impactDate = reader["impactDate"].ToString();
                }

                if (reader["impactAmount"] != DBNull.Value)
                {
                    pastDue.impactAmount = Convert.ToInt32(reader["impactAmount"]);
                }

                pastDues.Add(pastDue);
            }

            return pastDues;
        }

    }
}
