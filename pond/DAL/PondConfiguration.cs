using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Pond.Web.DAL
{
    public class PondConfiguration : DbConfiguration
    {
        public PondConfiguration ()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}