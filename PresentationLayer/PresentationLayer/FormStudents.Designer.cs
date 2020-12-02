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
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(13, 13);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(871, 355);
            this.listBoxStudents.TabIndex = 0;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(59, 392);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(173, 20);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // labelStudenName
            // 
            this.labelStudenName.AutoSize = true;
            this.labelStudenName.Location = new System.Drawing.Point(26, 395);
            this.labelStudenName.Name = "labelStudenName";
            this.labelStudenName.Size = new System.Drawing.Size(27, 13);
            this.labelStudenName.TabIndex = 2;
            this.labelStudenName.Text = "Ime:";
            // 
            // labelStudentIndexNumber
            // 
            this.labelStudentIndexNumber.AutoSize = true;
            this.labelStudentIndexNumber.Location = new System.Drawing.Point(279, 398);
            this.labelStudentIndexNumber.Name = "labelStudentIndexNumber";
            this.labelStudentIndexNumber.Size = new System.Drawing.Size(68, 13);
            this.labelStudentIndexNumber.TabIndex = 3;
            this.labelStudentIndexNumber.Text = "Broj indeksa:";
            // 
            // textBoxStudentIndexNumber
            // 
            this.textBoxStudentIndexNumber.Location = new System.Drawing.Point(354, 391);
            this.textBoxStudentIndexNumber.Name = "textBoxStudentIndexNumber";
            this.textBoxStudentIndexNumber.Size = new System.Drawing.Size(177, 20);
            this.textBoxStudentIndexNumber.TabIndex = 4;
            // 
            // labelStudentAverageMark
            // 
            this.labelStudentAverageMark.AutoSize = true;
            this.labelStudentAverageMark.Location = new System.Drawing.Point(562, 394);
            this.labelStudentAverageMark.Name = "labelStudentAverageMark";
            this.labelStudentAverageMark.Size = new System.Drawing.Size(88, 13);
            this.labelStudentAverageMark.TabIndex = 5;
            this.labelStudentAverageMark.Text = "Prosečna ocena:";
            // 
            // textBoxStudentAverageMark
            // 
            this.textBoxStudentAverageMark.Location = new System.Drawing.Point(657, 390);
            this.textBoxStudentAverageMark.Name = "textBoxStudentAverageMark";
            this.textBoxStudentAverageMark.Size = new System.Drawing.Size(72, 20);
            this.textBoxStudentAverageMark.TabIndex = 6;
            // 
            // buttonInsertStudent
            // 
            this.buttonInsertStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertStudent.Location = new System.Drawing.Point(59, 450);
            this.buttonInsertStudent.Name = "buttonInsertStudent";
            this.buttonInsertStudent.Size = new System.Drawing.Size(446, 61);
            this.buttonInsertStudent.TabIndex = 7;
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
            this.labelAverageMark.Location = new System.Drawing.Point(578, 450);
            this.labelAverageMark.Name = "labelAverageMark";
            this.labelAverageMark.Size = new System.Drawing.Size(88, 13);
            this.labelAverageMark.TabIndex = 9;
            this.labelAverageMark.Text = "Prosečna ocena:";
            // 
            // textBoxStudentFilterByAverageMark
            // 
            this.textBoxStudentFilterByAverageMark.Location = new System.Drawing.Point(672, 447);
            this.textBoxStudentFilterByAverageMark.Name = "textBoxStudentFilterByAverageMark";
            this.textBoxStudentFilterByAverageMark.Size = new System.Drawing.Size(68, 20);
            this.textBoxStudentFilterByAverageMark.TabIndex = 10;
            // 
            // buttonStudentRefreshListBox
            // 
            this.buttonStudentRefreshListBox.Location = new System.Drawing.Point(581, 487);
            this.buttonStudentRefreshListBox.Name = "buttonStudentRefreshListBox";
            this.buttonStudentRefreshListBox.Size = new System.Drawing.Size(159, 23);
            this.buttonStudentRefreshListBox.TabIndex = 11;
            this.buttonStudentRefreshListBox.Text = "Osveži listu studenata";
            this.buttonStudentRefreshListBox.UseVisualStyleBackColor = true;
            this.buttonStudentRefreshListBox.Click += new System.EventHandler(this.buttonStudentRefreshListBox_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 539);
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
    }
}

