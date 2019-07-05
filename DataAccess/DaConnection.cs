
namespace DataAccess
{
    using System.Configuration;

    public class DaConnection
    {
        #region Atributes
        private string connectionString;
        #endregion

        #region Properties
        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
        }
        #endregion

        #region Constructors
        public DaConnection()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultInresorts"].ConnectionString;
        }
        #endregion
    }
}
