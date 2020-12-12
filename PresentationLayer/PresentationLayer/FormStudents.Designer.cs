namespace PresentationLayer
{
    partial class FormStudents
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
			this.listBoxStudents = new System.Windows.Forms.ListBox();
			this.textBoxStudentName = new System.Windows.Forms.TextBox();
			this.labelStudenName = new System.Windows.Forms.Label();
			this.labelStudentIndexNumber = new System.Windows.Forms.Label();
			this.textBoxStudentIndexNumber = new System.Windows.Forms.TextBox();
			this.labelStudentAverageMark = new System.Windows.Forms.Label();
			this.textBoxStudentAverageMark = new System.Windows.Forms.TextBox();
			this.buttonInsertStudent = new System.Windows.Forms.Button();
			this.labelMessages = new System.Windows.Forms.Label();
			this.labelAverageMark = new System.Windows.Forms.Label();
			this.textBoxStudentFilterByAverageMark = new System.Windows.Forms.TextBox();
			this.buttonStudentRefreshListBox = new System.Windows.Forms.Button();
			this.textBoxStudentEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelErrorName = new System.Windows.Forms.Label();
			this.labelErrorIndex = new System.Windows.Forms.Label();
			this.labelErrorGrade = new System.Windows.Forms.Label();
			this.labelErrorEmail = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBoxStudents
			// 
			this.listBoxStudents.FormattingEnabled = true;
			this.listBoxStudents.Location = new System.Drawing.Point(13, 13);
			this.listBoxStudents.Name = "listBoxStudents";
			this.listBoxStudents.Size = new System.Drawing.Size(342, 355);
			this.listBoxStudents.TabIndex = 0;
			// 
			// textBoxStudentName
			// 
			this.textBoxStudentName.Location = new System.Drawing.Point(464, 13);
			this.textBoxStudentName.Name = "textBoxStudentName";
			this.textBoxStudentName.Size = new System.Drawing.Size(177, 20);
			this.textBoxStudentName.TabIndex = 1;
			// 
			// labelStudenName
			// 
			this.labelStudenName.AutoSize = true;
			this.labelStudenName.Location = new System.Drawing.Point(370, 16);
			this.labelStudenName.Name = "labelStudenName";
			this.labelStudenName.Size = new System.Drawing.Size(27, 13);
			this.labelStudenName.TabIndex = 0;
			this.labelStudenName.Text = "Ime:";
			// 
			// labelStudentIndexNumber
			// 
			this.labelStudentIndexNumber.AutoSize = true;
			this.labelStudentIndexNumber.Location = new System.Drawing.Point(370, 97);
			this.labelStudentIndexNumber.Name = "labelStudentIndexNumber";
			this.labelStudentIndexNumber.Size = new System.Drawing.Size(68, 13);
			this.labelStudentIndexNumber.TabIndex = 0;
			this.labelStudentIndexNumber.Text = "Broj indeksa:";
			// 
			// textBoxStudentIndexNumber
			// 
			this.textBoxStudentIndexNumber.Location = new System.Drawing.Point(464, 94);
			this.textBoxStudentIndexNumber.Name = "textBoxStudentIndexNumber";
			this.textBoxStudentIndexNumber.Size = new System.Drawing.Size(177, 20);
			this.textBoxStudentIndexNumber.TabIndex = 2;
			// 
			// labelStudentAverageMark
			// 
			this.labelStudentAverageMark.AutoSize = true;
			this.labelStudentAverageMark.Location = new System.Drawing.Point(370, 178);
			this.labelStudentAverageMark.Name = "labelStudentAverageMark";
			this.labelStudentAverageMark.Size = new System.Drawing.Size(88, 13);
			this.labelStudentAverageMark.TabIndex = 0;
			this.labelStudentAverageMark.Text = "Prosečna ocena:";
			// 
			// textBoxStudentAverageMark
			// 
			this.textBoxStudentAverageMark.Location = new System.Drawing.Point(464, 175);
			this.textBoxStudentAverageMark.Name = "textBoxStudentAverageMark";
			this.textBoxStudentAverageMark.Size = new System.Drawing.Size(177, 20);
			this.textBoxStudentAverageMark.TabIndex = 3;
			// 
			// buttonInsertStudent
			// 
			this.buttonInsertStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertStudent.Location = new System.Drawing.Point(373, 307);
			this.buttonInsertStudent.Name = "buttonInsertStudent";
			this.buttonInsertStudent.Size = new System.Drawing.Size(268, 61);
			this.buttonInsertStudent.TabIndex = 5;
			this.buttonInsertStudent.Text = "UNESI PODATKE O STUDENTU";
			this.buttonInsertStudent.UseVisualStyleBackColor = true;
			this.buttonInsertStudent.Click += new System.EventHandler(this.buttonInsertStudent_Click);
			// 
			// labelMessages
			// 
			this.labelMessages.AutoSize = true;
			this.labelMessages.Location = new System.Drawing.Point(238, 514);
			this.labelMessages.Name = "labelMessages";
			this.labelMessages.Size = new System.Drawing.Size(0, 13);
			this.labelMessages.TabIndex = 8;
			// 
			// labelAverageMark
			// 
			this.labelAverageMark.AutoSize = true;
			this.labelAverageMark.Location = new System.Drawing.Point(95, 377);
			this.labelAverageMark.Name = "labelAverageMark";
			this.labelAverageMark.Size = new System.Drawing.Size(88, 13);
			this.labelAverageMark.TabIndex = 0;
			this.labelAverageMark.Text = "Prosečna ocena:";
			// 
			// textBoxStudentFilterByAverageMark
			// 
			this.textBoxStudentFilterByAverageMark.Location = new System.Drawing.Point(189, 374);
			this.textBoxStudentFilterByAverageMark.Name = "textBoxStudentFilterByAverageMark";
			this.textBoxStudentFilterByAverageMark.Size = new System.Drawing.Size(68, 20);
			this.textBoxStudentFilterByAverageMark.TabIndex = 6;
			// 
			// buttonStudentRefreshListBox
			// 
			this.buttonStudentRefreshListBox.Location = new System.Drawing.Point(98, 414);
			this.buttonStudentRefreshListBox.Name = "buttonStudentRefreshListBox";
			this.buttonStudentRefreshListBox.Size = new System.Drawing.Size(159, 23);
			this.buttonStudentRefreshListBox.TabIndex = 7;
			this.buttonStudentRefreshListBox.Text = "Osveži listu studenata";
			this.buttonStudentRefreshListBox.UseVisualStyleBackColor = true;
			this.buttonStudentRefreshListBox.Click += new System.EventHandler(this.buttonStudentRefreshListBox_Click);
			// 
			// textBoxStudentEmail
			// 
			this.textBoxStudentEmail.Location = new System.Drawing.Point(464, 256);
			this.textBoxStudentEmail.Name = "textBoxStudentEmail";
			this.textBoxStudentEmail.Size = new System.Drawing.Size(177, 20);
			this.textBoxStudentEmail.TabIndex = 4;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(370, 259);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(35, 13);
			this.labelEmail.TabIndex = 0;
			this.labelEmail.Text = "Email:";
			// 
			// labelErrorName
			// 
			this.labelErrorName.Location = new System.Drawing.Point(464, 36);
			this.labelErrorName.Name = "labelErrorName";
			this.labelErrorName.Size = new System.Drawing.Size(177, 13);
			this.labelErrorName.TabIndex = 0;
			this.labelErrorName.Text = "Ovo polje je obavezno";
			this.labelErrorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelErrorName.Visible = false;
			// 
			// labelErrorIndex
			// 
			this.labelErrorIndex.Location = new System.Drawing.Point(464, 117);
			this.labelErrorIndex.Name = "labelErrorIndex";
			this.labelErrorIndex.Size = new System.Drawing.Size(177, 13);
			this.labelErrorIndex.TabIndex = 0;
			this.labelErrorIndex.Text = "Ovo polje je obavezno";
			this.labelErrorIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelErrorIndex.Visible = false;
			// 
			// labelErrorGrade
			// 
			this.labelErrorGrade.Location = new System.Drawing.Point(464, 198);
			this.labelErrorGrade.Name = "labelErrorGrade";
			this.labelErrorGrade.Size = new System.Drawing.Size(177, 13);
			this.labelErrorGrade.TabIndex = 0;
			this.labelErrorGrade.Text = "Ovo polje je obavezno";
			this.labelErrorGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelErrorGrade.Visible = false;
			// 
			// labelErrorEmail
			// 
			this.labelErrorEmail.Location = new System.Drawing.Point(464, 279);
			this.labelErrorEmail.Name = "labelErrorEmail";
			this.labelErrorEmail.Size = new System.Drawing.Size(177, 13);
			this.labelErrorEmail.TabIndex = 0;
			this.labelErrorEmail.Text = "Ovo polje je obavezno";
			this.labelErrorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelErrorEmail.Visible = false;
			// 
			// FormStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 451);
			this.Controls.Add(this.labelErrorEmail);
			this.Controls.Add(this.labelErrorGrade);
			this.Controls.Add(this.labelErrorIndex);
			this.Controls.Add(this.labelErrorName);
			this.Controls.Add(this.textBoxStudentEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.buttonStudentRefreshListBox);
			this.Controls.Add(this.textBoxStudentFilterByAverageMark);
			this.Controls.Add(this.labelAverageMark);
			this.Controls.Add(this.labelMessages);
			this.Controls.Add(this.buttonInsertStudent);
			this.Controls.Add(this.textBoxStudentAverageMark);
			this.Controls.Add(this.labelStudentAverageMark);
			this.Controls.Add(this.textBoxStudentIndexNumber);
			this.Controls.Add(this.labelStudentIndexNumber);
			this.Controls.Add(this.labelStudenName);
			this.Controls.Add(this.textBoxStudentName);
			this.Controls.Add(this.listBoxStudents);
			this.Name = "FormStudents";
			this.Text = "Studenti";
			this.Load += new System.EventHandler(this.FormStudents_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelStudenName;
        private System.Windows.Forms.Label labelStudentIndexNumber;
        private System.Windows.Forms.TextBox textBoxStudentIndexNumber;
        private System.Windows.Forms.Label labelStudentAverageMark;
        private System.Windows.Forms.TextBox textBoxStudentAverageMark;
        private System.Windows.Forms.Button buttonInsertStudent;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.Label labelAverageMark;
        private System.Windows.Forms.TextBox textBoxStudentFilterByAverageMark;
        private System.Windows.Forms.Button buttonStudentRefreshListBox;
		private System.Windows.Forms.TextBox textBoxStudentEmail;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelErrorName;
		private System.Windows.Forms.Label labelErrorIndex;
		private System.Windows.Forms.Label labelErrorGrade;
		private System.Windows.Forms.Label labelErrorEmail;
	}
}

