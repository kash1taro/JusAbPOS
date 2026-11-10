using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using JusAbPOS.Domain;

namespace JusAbPOS.Data
{
    /// <summary>User administration (Admin only - enforced in UserService). Password hashes are never read back.</summary>
    public sealed class UserAdminRepository
    {
        public List<UserAccount> GetAll()
        {
            var list = new List<UserAccount>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_User_List"))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(new UserAccount
                    {
                        Id = Convert.ToInt32(r["UserId"]),
                        Username = Convert.ToString(r["Username"]),
                        FullName = Convert.ToString(r["FullName"]),
                        RoleId = Convert.ToInt32(r["RoleId"]),
                        RoleName = Convert.ToString(r["RoleName"]),
                        IsActive = Convert.ToBoolean(r["IsActive"]),
                        LastLoginAt = r["LastLoginAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["LastLoginAt"])
                    });
            return list;
        }

        public List<RoleItem> GetRoles()
        {
            var list = new List<RoleItem>();
            using (var c = Db.Open())
            using (var cmd = Db.Proc(c, "dbo.usp_Role_List"))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(new RoleItem { Id = Convert.ToInt32(r["RoleId"]), Name = Convert.ToString(r["RoleName"]) });
            return list;
        }

        public int Create(string username, string fullName, int roleId, string password)
        {
            var salt = PasswordHasher.NewSalt();
            var hash = PasswordHasher.Hash(salt, password);
            return Run(() =>
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_User_Create"))
                {
                    Db.AddParam(cmd, "@Username", SqlDbType.NVarChar, username, 50);
                    Db.AddParam(cmd, "@PasswordHash", SqlDbType.VarChar, hash, 64);
                    Db.AddParam(cmd, "@Salt", SqlDbType.VarChar, salt, 32);
                    Db.AddParam(cmd, "@FullName", SqlDbType.NVarChar, fullName, 100);
                    Db.AddParam(cmd, "@RoleId", SqlDbType.Int, roleId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            });
        }

        public void Update(int userId, string fullName, int roleId)
        {
            Run(() =>
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_User_Update"))
                {
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    Db.AddParam(cmd, "@FullName", SqlDbType.NVarChar, fullName, 100);
                    Db.AddParam(cmd, "@RoleId", SqlDbType.Int, roleId);
                    cmd.ExecuteNonQuery();
                }
                return 0;
            });
        }

        public void SetActive(int userId, bool active)
        {
            Run(() =>
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_User_SetActive"))
                {
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    Db.AddParam(cmd, "@IsActive", SqlDbType.Bit, active);
                    cmd.ExecuteNonQuery();
                }
                return 0;
            });
        }

        public void ResetPassword(int userId, string password)
        {
            var salt = PasswordHasher.NewSalt();
            var hash = PasswordHasher.Hash(salt, password);
            Run(() =>
            {
                using (var c = Db.Open())
                using (var cmd = Db.Proc(c, "dbo.usp_User_ResetPassword"))
                {
                    Db.AddParam(cmd, "@UserId", SqlDbType.Int, userId);
                    Db.AddParam(cmd, "@PasswordHash", SqlDbType.VarChar, hash, 64);
                    Db.AddParam(cmd, "@Salt", SqlDbType.VarChar, salt, 32);
                    cmd.ExecuteNonQuery();
                }
                return 0;
            });
        }

        private static int Run(Func<int> action)
        {
            try { return action(); }
            catch (SqlException ex)
            {
                if (!Db.IsBusinessError(ex)) throw;
                throw Db.Translate(ex);
            }
        }
    }
}
