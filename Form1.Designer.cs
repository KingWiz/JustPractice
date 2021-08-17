
namespace PractiseClass
{
    partial class Form1
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
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.stdSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdPhoto_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.lvlName = new System.Windows.Forms.Label();
            this.lvlAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.lvlGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lvlPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdSN,
            this.stdID,
            this.stdName,
            this.stdAddress,
            this.stdPhoto_Path,
            this.stdAction});
            this.dgvStudentList.Location = new System.Drawing.Point(252, 12);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.Size = new System.Drawing.Size(442, 280);
            this.dgvStudentList.TabIndex = 6;
            this.dgvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellClick);
            // 
            // stdSN
            // 
            this.stdSN.HeaderText = "SN";
            this.stdSN.Name = "stdSN";
            this.stdSN.ReadOnly = true;
            // 
            // stdID
            // 
            this.stdID.HeaderText = "ID";
            this.stdID.Name = "stdID";
            this.stdID.ReadOnly = true;
            this.stdID.Visible = false;
            // 
            // stdName
            // 
            this.stdName.HeaderText = "Name";
            this.stdName.Name = "stdName";
            this.stdName.ReadOnly = true;
            // 
            // stdAddress
            // 
            this.stdAddress.HeaderText = "Address";
            this.stdAddress.Name = "stdAddress";
            this.stdAddress.ReadOnly = true;
            // 
            // stdPhoto_Path
            // 
            this.stdPhoto_Path.HeaderText = "Photo_Path";
            this.stdPhoto_Path.Name = "stdPhoto_Path";
            this.stdPhoto_Path.ReadOnly = true;
            // 
            // stdAction
            // 
            this.stdAction.HeaderText = "Action";
            this.stdAction.Name = "stdAction";
            this.stdAction.ReadOnly = true;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(64, 39);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(144, 20);
            this.txtbName.TabIndex = 0;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(64, 79);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(144, 20);
            this.txtbAddress.TabIndex = 1;
            // 
            // lvlName
            // 
            this.lvlName.AutoSize = true;
            this.lvlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlName.Location = new System.Drawing.Point(1, 43);
            this.lvlName.Name = "lvlName";
            this.lvlName.Size = new System.Drawing.Size(45, 16);
            this.lvlName.TabIndex = 4;
            this.lvlName.Text = "Name";
            // 
            // lvlAddress
            // 
            this.lvlAddress.AutoSize = true;
            this.lvlAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddress.Location = new System.Drawing.Point(1, 83);
            this.lvlAddress.Name = "lvlAddress";
            this.lvlAddress.Size = new System.Drawing.Size(59, 16);
            this.lvlAddress.TabIndex = 5;
            this.lvlAddress.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(118, 308);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(118, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(35, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Location = new System.Drawing.Point(125, 15);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(51, 17);
            this.rbtnOther.TabIndex = 11;
            this.rbtnOther.TabStop = true;
            this.rbtnOther.Text = "Other";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // lvlGender
            // 
            this.lvlGender.AutoSize = true;
            this.lvlGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGender.Location = new System.Drawing.Point(1, 131);
            this.lvlGender.Name = "lvlGender";
            this.lvlGender.Size = new System.Drawing.Size(53, 16);
            this.lvlGender.TabIndex = 12;
            this.lvlGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(6, 14);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 13;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(58, 14);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbtnMale);
            this.gbGender.Controls.Add(this.rbtnFemale);
            this.gbGender.Controls.Add(this.rbtnOther);
            this.gbGender.Location = new System.Drawing.Point(58, 117);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(188, 45);
            this.gbGender.TabIndex = 15;
            this.gbGender.TabStop = false;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(58, 180);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 50);
            this.pbPhoto.TabIndex = 16;
            this.pbPhoto.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(171, 207);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Select";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lvlPhoto
            // 
            this.lvlPhoto.AutoSize = true;
            this.lvlPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPhoto.Location = new System.Drawing.Point(4, 196);
            this.lvlPhoto.Name = "lvlPhoto";
            this.lvlPhoto.Size = new System.Drawing.Size(43, 16);
            this.lvlPhoto.TabIndex = 18;
            this.lvlPhoto.Text = "Photo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.lvlPhoto);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lvlGender);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvlAddress);
            this.Controls.Add(this.lvlName);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.dgvStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.Label lvlName;
        private System.Windows.Forms.Label lvlAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.Label lvlGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdPhoto_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdAction;
        private System.Windows.Forms.Label lvlPhoto;
    }
}

