using System;
using Dgv.Model;
using Dgv.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dgv
{
    public partial class EditDgv : Form
    {
        public EditDgv()
        {
            InitializeComponent();
        }

        UserInfoBLL userBll = new UserInfoBLL();
        public bool Insert { get; set; }
        private DataGridViewRow _CurrentRow;
        public DataGridViewRow CurrentRow
        {
            get { return _CurrentRow; }
            set { _CurrentRow = value; }
        }

        #region 保存数据
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.Name = textName.Text;
            user.Sex = radioButton1.Checked ? "男" : "女";
            user.Age = Convert.ToInt32(textAge.Text);
            user.Department = cobDepart.Text;
            user.BirthDay = Convert.ToDateTime(dateBirth.Text);
            user.HireDate = Convert.ToDateTime(dateHire.Text);
            user.Address = textAddress.Text;
            user.TelNum = textTel.Text;
            if (Insert)    //如果添加数据走里面这一段代码
            {
                userBll.UserInsert(user);
                MessageBox.Show("添加成功!");
            }
            else           //否则,修改走里面这一段代码
            {
                user.Id = Convert.ToInt32(_CurrentRow.Cells["Id"].Value.ToString());
                userBll.UserUpdate(user);
                MessageBox.Show("修改成功!");
            }
            this.Close();
        }
        #endregion

        #region 窗体运行加载数据
        private void EditDgv_Load(object sender, EventArgs e)
        {
            cobDepart.SelectedIndex = 0;
            if (Insert)  //增加
            {
                return;
            }
            else     //更改
            {
                textName.Text = _CurrentRow.Cells["Name"].Value.ToString();
                string s = _CurrentRow.Cells["Sex"].Value.ToString();
                if (s == "男")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textAge.Text = _CurrentRow.Cells["Age"].Value.ToString();
                cobDepart.Text = _CurrentRow.Cells["Department"].Value.ToString();
                dateBirth.Text = _CurrentRow.Cells["Birthday"].Value.ToString();
                dateHire.Text = _CurrentRow.Cells["HireDate"].Value.ToString();
                textAddress.Text = _CurrentRow.Cells["Address"].Value.ToString();
                textTel.Text = _CurrentRow.Cells["TelNum"].Value.ToString();
            }
        }
        #endregion
    }
}
