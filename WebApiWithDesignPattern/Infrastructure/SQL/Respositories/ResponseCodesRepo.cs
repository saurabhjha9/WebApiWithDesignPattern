using Infrastructure.SQL.DataModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Infrastructure.SQL.Respositories
{
    public class ResponseCodesRepo
    {
        private string _connectionString = string.Empty;
        private ILog _logger;
        public ResponseCodesRepo(string connectionString, ILog logger)
        {
            this._connectionString = connectionString;
            this._logger = logger;
        }
        public string GetResponseMessage(double responseCode)
        {
            string responseMessage = string.Empty;
            string queryString = @"SELECT RESPONSECODESDESC FROM RESPONSECODES"+
                " WHERE RESPONSECODEID = @RESPONSECODEID";
            try
            {
                using (SqlConnection con = new SqlConnection(this._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryString, con);
                    cmd.Parameters.AddWithValue("@RESPONSECODEID", responseCode);
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        if (sqlDataReader == null)
                        {
                            _logger.Error($"Failed to fetch ResponseMessage for {responseCode}");
                            return responseMessage;
                        }
                        while (sqlDataReader.Read())
                        {
                            responseMessage = sqlDataReader["shopid"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                _logger.Error("Exception in " + this.GetType().Name + " Exception: {Exception}", ex);
            }
            return string.Empty;
        }
    }
}
