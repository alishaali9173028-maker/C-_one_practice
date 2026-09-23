namespace Assignmentone
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentId = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.bttoshowinfo = new System.Windows.Forms.Button();
            this.bttoclear = new System.Windows.Forms.Button();
            this.bttoexit = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textstudentId = new System.Windows.Forms.TextBox();
            this.textdepartement = new System.Windows.Forms.TextBox();
            this.textsemester = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(99, 54);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(198, 23);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblstudentId
            // 
            this.lblstudentId.Location = new System.Drawing.Point(99, 109);
            this.lblstudentId.Name = "lblstudentId";
            this.lblstudentId.Size = new System.Drawing.Size(198, 20);
            this.lblstudentId.TabIndex = 1;
            this.lblstudentId.Text = "Enter the student Id";
            this.lblstudentId.Click += new System.EventHandler(this.lblstudentId_Click);
            // 
            // lbldepartment
            // 
            this.lbldepartment.Location = new System.Drawing.Point(99, 155);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(198, 20);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "Enter the departement";
            this.lbldepartment.Click += new System.EventHandler(this.lbldepartment_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.Location = new System.Drawing.Point(99, 204);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(198, 20);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter the semester";
            this.lblsemester.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(103, 312);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(569, 67);
            this.lbloutput.TabIndex = 4;
            // 
            // bttoshowinfo
            // 
            this.bttoshowinfo.BackColor = System.Drawing.Color.DarkRed;
            this.bttoshowinfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttoshowinfo.Location = new System.Drawing.Point(131, 388);
            this.bttoshowinfo.Name = "bttoshowinfo";
            this.bttoshowinfo.Size = new System.Drawing.Size(139, 50);
            this.bttoshowinfo.TabIndex = 5;
            this.bttoshowinfo.Text = "Show information";
            this.bttoshowinfo.UseVisualStyleBackColor = false;
            this.bttoshowinfo.Click += new System.EventHandler(this.bttoshowinfo_Click);
            // 
            // bttoclear
            // 
            this.bttoclear.BackColor = System.Drawing.Color.DarkRed;
            this.bttoclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttoclear.Location = new System.Drawing.Point(318, 388);
            this.bttoclear.Name = "bttoclear";
            this.bttoclear.Size = new System.Drawing.Size(129, 53);
            this.bttoclear.TabIndex = 6;
            this.bttoclear.Text = "Clear";
            this.bttoclear.UseVisualStyleBackColor = false;
            this.bttoclear.Click += new System.EventHandler(this.bttoclear_Click);
            // 
            // bttoexit
            // 
            this.bttoexit.BackColor = System.Drawing.Color.DarkRed;
            this.bttoexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttoexit.Location = new System.Drawing.Point(501, 388);
            this.bttoexit.Name = "bttoexit";
            this.bttoexit.Size = new System.Drawing.Size(132, 53);
            this.bttoexit.TabIndex = 7;
            this.bttoexit.Text = "Exit";
            this.bttoexit.UseVisualStyleBackColor = false;
            this.bttoexit.Click += new System.EventHandler(this.bttoexit_Click);
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textname.Location = new System.Drawing.Point(389, 38);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(317, 26);
            this.textname.TabIndex = 8;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // textstudentId
            // 
            this.textstudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textstudentId.Location = new System.Drawing.Point(389, 103);
            this.textstudentId.Name = "textstudentId";
            this.textstudentId.Size = new System.Drawing.Size(317, 26);
            this.textstudentId.TabIndex = 9;
            this.textstudentId.TextChanged += new System.EventHandler(this.textstudentId_TextChanged);
            // 
            // textdepartement
            // 
            this.textdepartement.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textdepartement.Location = new System.Drawing.Point(389, 173);
            this.textdepartement.Name = "textdepartement";
            this.textdepartement.Size = new System.Drawing.Size(317, 26);
            this.textdepartement.TabIndex = 10;
            this.textdepartement.TextChanged += new System.EventHandler(this.textdepartement_TextChanged);
            // 
            // textsemester
            // 
            this.textsemester.BackColor = System.Drawing.Color.Indigo;
            this.textsemester.Location = new System.Drawing.Point(389, 240);
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(317, 26);
            this.textsemester.TabIndex = 11;
            this.textsemester.TextChanged += new System.EventHandler(this.textsemester_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textdepartement);
            this.Controls.Add(this.textstudentId);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.bttoexit);
            this.Controls.Add(this.bttoclear);
            this.Controls.Add(this.bttoshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentId);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentId;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button bttoshowinfo;
        private System.Windows.Forms.Button bttoclear;
        private System.Windows.Forms.Button bttoexit;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textstudentId;
        private System.Windows.Forms.TextBox textdepartement;
        private System.Windows.Forms.TextBox textsemester;
    }
}

