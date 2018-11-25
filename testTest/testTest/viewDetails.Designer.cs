namespace testTest
{
    partial class viewDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.position = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.slary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.table1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(68, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.table1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 448);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee List";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(16, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(240, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fname);
            this.groupBox2.Controls.Add(this.slary);
            this.groupBox2.Controls.Add(this.telephone);
            this.groupBox2.Controls.Add(this.position);
            this.groupBox2.Controls.Add(this.nic);
            this.groupBox2.Controls.Add(this.lname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(592, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 437);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nic Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Salary";
            // 
            // lname
            // 
            this.lname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.Blue;
            this.lname.LineIdleColor = System.Drawing.Color.Gray;
            this.lname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(148, 97);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.MaxLength = 32767;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(137, 33);
            this.lname.TabIndex = 7;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nic
            // 
            this.nic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nic.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nic.HintForeColor = System.Drawing.Color.Empty;
            this.nic.HintText = "";
            this.nic.isPassword = false;
            this.nic.LineFocusedColor = System.Drawing.Color.Blue;
            this.nic.LineIdleColor = System.Drawing.Color.Gray;
            this.nic.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nic.LineThickness = 3;
            this.nic.Location = new System.Drawing.Point(148, 151);
            this.nic.Margin = new System.Windows.Forms.Padding(4);
            this.nic.MaxLength = 32767;
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(137, 33);
            this.nic.TabIndex = 8;
            this.nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // position
            // 
            this.position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.position.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.position.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.position.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.position.HintForeColor = System.Drawing.Color.Empty;
            this.position.HintText = "";
            this.position.isPassword = false;
            this.position.LineFocusedColor = System.Drawing.Color.Blue;
            this.position.LineIdleColor = System.Drawing.Color.Gray;
            this.position.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.position.LineThickness = 3;
            this.position.Location = new System.Drawing.Point(148, 205);
            this.position.Margin = new System.Windows.Forms.Padding(4);
            this.position.MaxLength = 32767;
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(137, 33);
            this.position.TabIndex = 9;
            this.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telephone
            // 
            this.telephone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.telephone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.telephone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telephone.HintForeColor = System.Drawing.Color.Empty;
            this.telephone.HintText = "";
            this.telephone.isPassword = false;
            this.telephone.LineFocusedColor = System.Drawing.Color.Blue;
            this.telephone.LineIdleColor = System.Drawing.Color.Gray;
            this.telephone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.telephone.LineThickness = 3;
            this.telephone.Location = new System.Drawing.Point(148, 255);
            this.telephone.Margin = new System.Windows.Forms.Padding(4);
            this.telephone.MaxLength = 32767;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(137, 33);
            this.telephone.TabIndex = 10;
            this.telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // slary
            // 
            this.slary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.slary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.slary.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.slary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.slary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.slary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slary.HintForeColor = System.Drawing.Color.Empty;
            this.slary.HintText = "";
            this.slary.isPassword = false;
            this.slary.LineFocusedColor = System.Drawing.Color.Blue;
            this.slary.LineIdleColor = System.Drawing.Color.Gray;
            this.slary.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.slary.LineThickness = 3;
            this.slary.Location = new System.Drawing.Point(148, 315);
            this.slary.Margin = new System.Windows.Forms.Padding(4);
            this.slary.MaxLength = 32767;
            this.slary.Name = "slary";
            this.slary.Size = new System.Drawing.Size(137, 33);
            this.slary.TabIndex = 11;
            this.slary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // table1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.table1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.table1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.table1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.DoubleBuffered = true;
            this.table1.EnableHeadersVisualStyles = false;
            this.table1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.table1.HeaderForeColor = System.Drawing.Color.Black;
            this.table1.Location = new System.Drawing.Point(16, 30);
            this.table1.Margin = new System.Windows.Forms.Padding(4);
            this.table1.Name = "table1";
            this.table1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table1.Size = new System.Drawing.Size(458, 243);
            this.table1.TabIndex = 31;
            this.table1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table1_CellContentClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fname
            // 
            this.fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.Blue;
            this.fname.LineIdleColor = System.Drawing.Color.Gray;
            this.fname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(148, 48);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.MaxLength = 32767;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(137, 33);
            this.fname.TabIndex = 12;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // viewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "viewDetails";
            this.Size = new System.Drawing.Size(999, 658);
            this.Load += new System.EventHandler(this.viewDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox slary;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox position;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
    }
}
