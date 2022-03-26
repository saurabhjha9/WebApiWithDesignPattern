using Business.Constants;
using Infrastructure.SQL.ResultSets;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Infrastructure.SQL.Respositories
{
    public class ProductSKURepo
    {
        ILog _logger;
        string _connectionString;
        public ProductSKURepo(string connectionString, ILog logger)
        {
            this._connectionString = connectionString;
            this._logger = logger;
        }
        /// <summary>
        /// Fetches Product sku info based on product id and shop id
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="shopID"></param>
        /// <returns></returns>
        public Products GetProductSKUByProductID(double productID, double shopID)
        {
            string queryString = @"SELECT P.PRODUCTID, P.PRODUCTDESC, PSKU.PRODUCTSKUID,PSKU.PRODUCTDESC, PSKU.QUANTITY, PSKU.BATCHID, PSKU.BATCHID "
            + " FROM PRODUCTS P INNER JOIN PRODUCTSKU PSKU ON P.PRODUCTID = PSKU.PRODUCTID"
            + " WHERE PSKU.SHOPID = @SHOPID AND PSKU.PRODUCTID = @PRODUCTID AND PSKU.QUANTITY>0"
            + " AND P.PRODUCTSTATUSID = @PRODUCTSTATUSID AND PSKU.EXPIRYDATE > GETDATE()";

            try
            {
                using (SqlConnection con = new SqlConnection(this._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryString, con);
                    cmd.Parameters.AddWithValue("@PRODUCTID", productID);
                    cmd.Parameters.AddWithValue("@PRODUCTSTATUSID", ProductStatus.ACTIVE);
                    cmd.Parameters.AddWithValue("@SHOPID", shopID);
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        if (sqlDataReader == null)
                        {
                            _logger.Error($"Failed to fetch ProductSKU for ProductID: {productID} and ShopID: {shopID}");
                        }
                        while (sqlDataReader.Read())
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this._logger.Error("Error occured in " + this.GetType().Name + ", Exception : {Exception}", ex);
            }
        }
    }
}
