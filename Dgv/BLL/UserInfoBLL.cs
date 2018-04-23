using Dgv.Model;
using Dgv.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgv.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL userDal = new UserInfoDAL();

        #region 加载所有数据
        public object LoadGetAllData()
        {
            object all = userDal.GetAllData();
            return all;
        }
        #endregion

        #region 插入数据
        public void UserInsert(UserInfo user)
        {
            userDal.UserInsert(user);
        }
        #endregion

        #region 更改数据
        public void UserUpdate(UserInfo user)
        {
            userDal.UserUpdate(user);
        }
        #endregion

        #region 删除数据
        public void UserDelete(int id)
        {
            userDal.DeleteById(id);
        }
        #endregion

        #region id查询
        public object LoadGetDataById(int id)
        {
            object _id = userDal.GetDataById(id);
            return _id;
        }
        #endregion

        #region 性别查询
        public object LoadGetDataBySex(string sex)
        {
            object _sex = userDal.GetDataBySex(sex);
            return _sex;
        }
        #endregion

        #region 年龄查询
        public object LoadGetDataByAge(int age)
        {
            object _age = userDal.GetDataByAge(age);
            return _age;
        }
        #endregion

        #region 部门查询
        public object LoadGetDataByDepartment(string department)
        {
            object _dep = userDal.GetDataByDepartment(department);
            return _dep;
        }
        #endregion
    }
}
