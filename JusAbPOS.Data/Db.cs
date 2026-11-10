using System;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace JusAbPOS.Data
{
    /// <summary>LINQ-to-SQL context from the tutorial (step 8.1). The starter code calls stored procedures
    /// directly, so this is here for future typed .dbml reporting queries.</summary>
    public sealed class PosDataContext : DataContext
    {
        public PosDataContext(string connectionString) : base(connectionString)
        {
            ObjectTrackingEnabled = true;
            DeferredLoadingEnabled = false;
        }
    }

    public static class Db
    {
        public const string ConnectionName = "JusAbPOS";

        public static string ConnectionString
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings[ConnectionName];
                if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                    throw new InvalidOperationException("Connection string '" + ConnectionName + "' is missing from App.config.");
                return cs.ConnectionString;
            }
        }

        public static SqlConnection Open()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static SqlCommand Proc(SqlConnection connection, string name)
        {
            return new SqlCommand(name, connection) { CommandType = CommandType.StoredProcedure };
        }

        /// <summary>Adds a typed parameter. Never concatenate user input into SQL (tutorial 8.3).</summary>
        public static SqlParameter AddParam(SqlCommand cmd, string name, SqlDbType type, object value, int size = 0)
        {
            var p = size != 0 ? cmd.Parameters.Add(name, type, size) : cmd.Parameters.Add(name, type);
            if (type == SqlDbType.Decimal) { p.Precision = 18; p.Scale = 2; }   // DECIMAL(18,2) - avoids silent rounding
            p.Value = value ?? DBNull.Value;
            return p;
        }

        /// <summary>True for errors that are meaningful to the user (duplicate SKU, product not found...).</summary>
        public static bool IsBusinessError(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627: case 2601: case 547: case 50001: case 50010: case 50011:
                case 50020: case 50021: case 50022: case 50023: case 50024: case 50025:
                case 50030: case 50031: case 50032: case 50033: return true;
                default: return false;
            }
        }

        public static Exception Translate(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return new InvalidOperationException("A product with the same SKU or barcode already exists.", ex);
                case 547:
                    return new InvalidOperationException("The value breaks a database rule (unknown category or a negative amount).", ex);
                default:
                    return new InvalidOperationException(ex.Message, ex);   // THROW 50001 / 50010 / 50011 from our procedures
            }
        }
    }
}
