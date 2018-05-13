using Dgv.DBHelper;
using Dgv.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgv.DAL
{
    public class UserInfoDAL
    {
        SQLHelper sqlhelp = new SQLHelper();
        private UserInfo ToUserInfo(DataRow row)
        {
            UserInfo user = new UserInfo();
            user.Id = (int)row["Id"];
            user.Name = (string)row["Name"];
            user.Sex = (string)row["Sex"];
            user.Age = (int)row["Age"];
            user.Department = (string)row["Department"];
            user.BirthDay = (DateTime?)(row["BirthDay"]);
            user.HireDate = (DateTime?)(row["HireDate"]);
            user.TelNum = (string)row["TelNum"];
            user.Address = (string)row["Address"];
            return user;
        }
        #region 加载所有信息
        public UserInfo[] GetAllData()
        {
            DataTable table = sqlhelp.ExecuteDataTable("select * from T_UserInfo");
            UserInfo[] user = new UserInfo[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                user[i] = ToUserInfo(row);
            }
            return customers;
        }
        #endregion

        #region 添加用户信息
        public void UserInsert(UserInfo user)
        {
            sqlhelp.ExecuteNonQuery(@"INSERT INTO [T_UserInfo]
                       ([Name],[Sex],[Age],[Department]
                       ,[BirthDay],[HireDate],[Address],[TelNum])                                 
                        VALUES
                       (@Name,@Sex,@Age,@Department,@BirthDay,@HireDate,@Address,@TelNum)",
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@Sex", user.Sex),
                new SqlParameter("@Age", user.Age),
                new SqlParameter("@Department", user.Department),
                new SqlParameter("@BirthDay", user.BirthDay),
                new SqlParameter("@HireDate", user.HireDate),
                new SqlParameter("@Address", user.Address),
                new SqlParameter("@TelNum", user.TelNum));
        }
        #endregion

        #region 修改用户信息
        public void UserUpdate(UserInfo user)
        {
            sqlhelp.ExecuteNonQuery(@"UPDATE [T_UserInfo]
                        SET [Name]=@Name
                           ,[Sex]=@Sex
                           ,[Age]=@Age
                           ,[Department]=@Department
                           ,[BirthDay] = @BirthDay
                           ,[HireDate]=@HireDate
                           ,[Address] = @Address
                           ,[TelNum] = @TelNum        
                            WHERE Id=@Id",
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@Sex", user.Sex),
                new SqlParameter("@Age", user.Age),
                new SqlParameter("@Department", user.Department),
                new SqlParameter("@BirthDay", user.BirthDay),
                new SqlParameter("@HireDate", user.HireDate),
                new SqlParameter("@Address", user.Address),
                new SqlParameter("@TelNum", user.TelNum),
                new SqlParameter("@Id", user.Id));
        }
        #endregion

        #region 删除用户信息
        public void DeleteById(int id)
        {
            sqlhelp.ExecuteNonQuery("delete from T_UserInfo where Id=@Id",
                new SqlParameter("@Id", id));
        }
        #endregion

        #region id查找
        public UserInfo[] GetDataById(int id)
        {
            DataTable dt = sqlhelp.ExecuteDataTable("select * from T_UserInfo where Id=@Id",
                new SqlParameter("@Id", id));
            UserInfo[] user = new UserInfo[dt.Rows.Count];
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception("严重错误，查出多条数据！");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    user[i] = ToUserInfo(row);
                }
            }
            return user;
        }
        #endregion

        #region 性别查找
        public UserInfo[] GetDataBySex(string Sex)
        {
            DataTable dt = sqlhelp.ExecuteDataTable("select * from T_UserInfo where Sex=@Sex",
                new SqlParameter("@Sex", Sex));
            UserInfo[] user = new UserInfo[dt.Rows.Count];
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    user[i] = ToUserInfo(row);
                }
            }
            return user;
        }
        #endregion

        #region 年龄查找
        public UserInfo[] GetDataByAge(int Age)
        {
            DataTable dt = sqlhelp.ExecuteDataTable("select * from T_UserInfo where Age=@Age",
                new SqlParameter("@Age", Age));
            UserInfo[] user = new UserInfo[dt.Rows.Count];
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    user[i] = ToUserInfo(row);
                }
            }
            return user;
        }
        #endregion

        #region 部门查找
        public UserInfo[] GetDataByDepartment(string Department)
        {
            DataTable dt = sqlhelp.ExecuteDataTable("select * from T_UserInfo where Department LIKE @Department",
                new SqlParameter("@Department", "%"+Department+"%"));
            UserInfo[] user = new UserInfo[dt.Rows.Count];
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    user[i] = ToUserInfo(row);
                }
            }
            return user;
        }
        #endregion
    }
}
