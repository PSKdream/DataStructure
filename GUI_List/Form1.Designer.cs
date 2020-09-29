namespace GUI_List
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
            this.textName = new System.Windows.Forms.TextBox();
            this.InsertName = new System.Windows.Forms.Button();
            this.FindName = new System.Windows.Forms.Button();
            this.DelName = new System.Windows.Forms.Button();
            this.FindNameIndex = new System.Windows.Forms.Button();
            this.textEdit = new System.Windows.Forms.TextBox();
            this.EditName = new System.Windows.Forms.Button();
            this.ShowListName = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ListName1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(34, 38);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(235, 41);
            this.textName.TabIndex = 0;
            // 
            // InsertName
            // 
            this.InsertName.Location = new System.Drawing.Point(295, 35);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(75, 50);
            this.InsertName.TabIndex = 1;
            this.InsertName.Text = "เพิ่มชื่อ";
            this.InsertName.UseVisualStyleBackColor = true;
            this.InsertName.Click += new System.EventHandler(this.InsertName_Click);
            // 
            // FindName
            // 
            this.FindName.Location = new System.Drawing.Point(384, 35);
            this.FindName.Name = "FindName";
            this.FindName.Size = new System.Drawing.Size(75, 50);
            this.FindName.TabIndex = 2;
            this.FindName.Text = "ค้นหาชื่อ";
            this.FindName.UseVisualStyleBackColor = true;
            this.FindName.Click += new System.EventHandler(this.FindName_Click);
            // 
            // DelName
            // 
            this.DelName.Location = new System.Drawing.Point(477, 35);
            this.DelName.Name = "DelName";
            this.DelName.Size = new System.Drawing.Size(75, 50);
            this.DelName.TabIndex = 3;
            this.DelName.Text = "ลบชื่อ";
            this.DelName.UseVisualStyleBackColor = true;
            this.DelName.Click += new System.EventHandler(this.DelName_Click);
            // 
            // FindNameIndex
            // 
            this.FindNameIndex.Location = new System.Drawing.Point(95, 109);
            this.FindNameIndex.Name = "FindNameIndex";
            this.FindNameIndex.Size = new System.Drawing.Size(130, 50);
            this.FindNameIndex.TabIndex = 5;
            this.FindNameIndex.Text = "ค้นหาชื่อจากลำดับ";
            this.FindNameIndex.UseVisualStyleBackColor = true;
            this.FindNameIndex.Click += new System.EventHandler(this.FindNameIndex_Click);
            // 
            // textEdit
            // 
            this.textEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit.Location = new System.Drawing.Point(240, 115);
            this.textEdit.Name = "textEdit";
            this.textEdit.Size = new System.Drawing.Size(204, 41);
            this.textEdit.TabIndex = 6;
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(468, 109);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(82, 50);
            this.EditName.TabIndex = 7;
            this.EditName.Text = "แก้ไขชื่อ";
            this.EditName.UseMnemonic = false;
            this.EditName.UseVisualStyleBackColor = true;
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // ShowListName
            // 
            this.ShowListName.Location = new System.Drawing.Point(435, 227);
            this.ShowListName.Name = "ShowListName";
            this.ShowListName.Size = new System.Drawing.Size(115, 97);
            this.ShowListName.TabIndex = 9;
            this.ShowListName.Text = "แสดงรายชื่อทั้งหมด";
            this.ShowListName.UseVisualStyleBackColor = true;
            this.ShowListName.Click += new System.EventHandler(this.ShowListName_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(36, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 41);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(431, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "จำนวน 0 คน";
            // 
            // ListName1
            // 
            this.ListName1.Location = new System.Drawing.Point(36, 188);
            this.ListName1.Multiline = true;
            this.ListName1.Name = "ListName1";
            this.ListName1.Size = new System.Drawing.Size(347, 195);
            this.ListName1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 431);
            this.Controls.Add(this.ListName1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ShowListName);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.textEdit);
            this.Controls.Add(this.FindNameIndex);
            this.Controls.Add(this.DelName);
            this.Controls.Add(this.FindName);
            this.Controls.Add(this.InsertName);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button InsertName;
        private System.Windows.Forms.Button FindName;
        private System.Windows.Forms.Button DelName;
        private System.Windows.Forms.Button FindNameIndex;
        private System.Windows.Forms.TextBox textEdit;
        private System.Windows.Forms.Button EditName;
        private System.Windows.Forms.Button ShowListName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListName1;
    }
}

