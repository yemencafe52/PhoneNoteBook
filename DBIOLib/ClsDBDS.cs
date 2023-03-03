namespace DBIOLib
{
    using System.Data;

    /// <summary>
    /// DataBase IO class
    /// </summary>
    public class DBDS : IDBDS
    {
        private readonly string connectionString;

        /// <summary>
        /// DBDS Constrct
        /// </summary>
        /// <param name="connectionString"></param>
        public DBDS(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Execute None Query Stetment;
        /// </summary>
        /// <param name="sql">command stetment</param>
        /// <returns>number of efected rows in database</returns>
        public int ExecuteNonQuery(string sql)
        {
            int res = 0;
            return res;
        }

        /// <summary>
        /// Execte Query 
        /// </summary>
        /// <param name="sql">command stetment</param>
        /// <param name="dataTable">pointer to datatbale to fill it</param>
        /// <returns>true if success else false</returns>
        public bool ExecuteQuery(string sql, out DataTable dataTable)
        {
            bool res = false;
            dataTable = null;
            return res;
        }
    }
}
