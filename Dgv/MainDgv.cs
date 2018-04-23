using System;
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
    public partial class MainDgv : Form
    {
        public MainDgv()
        {
            InitializeComponent();
        }

        UserInfoBLL userBll = new UserInfoBLL();

        #region 加载所有数据方法
        public void LoadAllData()
        {
            dataGridView1.DataSource = userBll.LoadGetAllData();
        }
        #endregion

        #region 加载id数据
        public void LoadDataById(int id)
        {
            dataGridView1.DataSource = userBll.LoadGetDataById(id);
        }
        #endregion

        #region 加载性别数据
        public void LoadDataBySex(string sex)
        {
            dataGridView1.DataSource = userBll.LoadGetDataBySex(sex);
        }
        #endregion

        #region 加载年龄数据
        public void LoadDataByAge(int Age)
        {
            dataGridView1.DataSource = userBll.LoadGetDataByAge(Age);
        }
        #endregion

        #region 加载部门数据
        public void LoadDataByDepartment(string department)
        {
            dataGridView1.DataSource = userBll.LoadGetDataByDepartment(department);
        }
        #endregion  

        #region 运行程序加载数据
        private void MainDgv_Load(object sender, EventArgs e)
        {
            LoadAllData();
            cobQuery.SelectedIndex = 0;
            string[] htext = { "编号", "姓名", "性别", "年龄", "部门", "出生日期", "入职时间", "联系号码", "通讯地址" };
            for (int i = 0; i < htext.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = htext[i];
            }
        }
        #endregion

        #region 添加数据
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditDgv editDgv = new EditDgv();
            editDgv.Insert = true;
            editDgv.ShowDialog();
            LoadAllData();
        }
        #endregion

        #region 删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow _Row = dataGridView1.CurrentRow;
            DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;
            if (_Row == null)
            {
                MessageBox.Show("没有数据行,操作无效!");
                return;
            }
            List<long> list = new List<long>();
            foreach (DataGridViewRow singleRow in selectedrows)
            {
                list.Add(Convert.ToInt32(singleRow.Cells["Id"].Value.ToString()));
            }
            if (MessageBox.Show("确定删除此行数据?", "删除信息", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (int s in list)
                {
                    userBll.UserDelete(s);
                }
                MessageBox.Show("删除数据成功!");
                LoadAllData();
            }
        }
        #endregion

        #region 修改数据
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow _Row = dataGridView1.CurrentRow;
            if (_Row == null)
            {
                MessageBox.Show("没有数据行,当前操作无效!");
                return;
            }
            EditDgv editDgv = new EditDgv();
            editDgv.CurrentRow = _Row;
            editDgv.Insert = false;
            editDgv.ShowDialog();
            LoadAllData();
        }
        #endregion

        #region 查询数据
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string Input = textQuery.Text;
            string SelectedText = cobQuery.Text;
            if (SelectedText == "")
            {
                MessageBox.Show("请选择查询条件!");
                return;
            }
            if (Input == "")
            {
                if (SelectedText == "全部")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("请输入查询条件!");
                    return;
                }
            }
            switch (SelectedText)
            {
                case "全部":
                    LoadAllData();
                    break;
                case "编号":
                    LoadDataById(Convert.ToInt32(Input));
                    break;
                case "性别":
                    LoadDataBySex(Input);
                    break;
                case "年龄":
                    LoadDataByAge(Convert.ToInt32(Input));
                    break;
                case "部门":
                    LoadDataByDepartment(Input);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region comboBox更改属性事件
        private void cobQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobQuery.Text == "全部")
            {
                textQuery.Text = "全部";
                textQuery.Enabled = false;
            }
            else
            {
                textQuery.Text = "";
                textQuery.Enabled = true;
            }
        }
        #endregion

    }
}
