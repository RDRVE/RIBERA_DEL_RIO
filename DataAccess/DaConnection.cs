using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
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
            this.connectionString = "";
        }
        #endregion
    }
}
