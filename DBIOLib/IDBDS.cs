namespace DBIOLib
{
    using System.Data;

    /// <summary>
    /// IO DataBase Interface
    /// </summary>
    public interface IDBDS
    {
        /// <summary>
        /// Execute Non Query; Insert,Update,Delete Stetements
        /// </summary>
        /// <param name="sql">Command Stetment</param>
        /// <returns>Rows Number; Effected Rows</returns>
        int ExecuteNonQuery(string sql);

        /// <summary>
        /// Execute Select Qury Stetment;
        /// </summary>
        /// <param name="sql">Command Stetment</param>
        /// <param name="dataTable">OutPut Var; Fill This Var With Returned Rows</param>
        /// <returns></returns>
        bool ExecuteQuery(string sql, out DataTable dataTable);
    }
}