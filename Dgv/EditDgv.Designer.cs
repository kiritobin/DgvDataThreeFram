namespace Dgv
{
    partial class EditDgv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labSex = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labDepart = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.cobDepart = new System.Windows.Forms.ComboBox();
            this.labBirth = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.labHire = new System.Windows.Forms.Label();
            this.dateHire = new System.Windows.Forms.DateTimePicker();
            this.labAddress = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(58, 22);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 1;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(12, 98);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(29, 12);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性别";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(12, 61);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(29, 12);
            this.labAge.TabIndex = 4;
            this.labAge.Text = "年龄";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(58, 58);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 21);
            this.textAge.TabIndex = 5;
            // 
            // labDepart
            // 
            this.labDepart.AutoSize = true;
            this.labDepart.Location = new System.Drawing.Point(323, 19);
            this.labDepart.Name = "labDepart";
            this.labDepart.Size = new System.Drawing.Size(53, 12);
            this.labDepart.TabIndex = 6;
            this.labDepart.Text = "开发部门";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(88, 199);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 21);
            this.textAddress.TabIndex = 7;
            // 
            // cobDepart
            // 
            this.cobDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDepart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobDepart.FormattingEnabled = true;
            this.cobDepart.Items.AddRange(new object[] {
            "C#开发",
            "Java开发",
            "Web前端",
            "IOS开发",
            "C++开发"});
            this.cobDepart.Location = new System.Drawing.Point(405, 19);
            this.cobDepart.Name = "cobDepart";
            this.cobDepart.Size = new System.Drawing.Size(121, 20);
            this.cobDepart.TabIndex = 8;
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(334, 81);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(29, 12);
            this.labBirth.TabIndex = 9;
            this.labBirth.Text = "生日";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(405, 75);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(125, 21);
            this.dateBirth.TabIndex = 10;
            // 
            // labHire
            // 
            this.labHire.AutoSize = true;
            this.labHire.Location = new System.Drawing.Point(323, 128);
            this.labHire.Name = "labHire";
            this.labHire.Size = new System.Drawing.Size(53, 12);
            this.labHire.TabIndex = 11;
            this.labHire.Text = "入职时间";
            // 
            // dateHire
            // 
            this.dateHire.Location = new System.Drawing.Point(405, 128);
            this.dateHire.Name = "dateHire";
            this.dateHire.Size = new System.Drawing.Size(125, 21);
            this.dateHire.TabIndex = 12;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(12, 199);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(53, 12);
            this.labAddress.TabIndex = 13;
            this.labAddress.Text = "通讯地址";
            // 
            // labTel
            // 
            this.labTel.AutoSize = true;
            this.labTel.Location = new System.Drawing.Point(12, 149);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(53, 12);
            this.labTel.TabIndex = 14;
            this.labTel.Text = "联系电话";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(88, 146);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 21);
            this.textTel.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 96);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EditDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.labTel);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.dateHire);
            this.Controls.Add(this.labHire);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.labBirth);
            this.Controls.Add(this.cobDepart);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labDepart);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDgv";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.EditDgv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label labDepart;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox cobDepart;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label labHire;
        private System.Windows.Forms.DateTimePicker dateHire;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}