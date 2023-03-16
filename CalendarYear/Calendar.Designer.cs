namespace CalendarYear
{
    partial class Calendar
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
            this.components = new System.ComponentModel.Container();
            this.btmBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmBefore
            // 
            this.btmBefore.Location = new System.Drawing.Point(93, 49);
            this.btmBefore.Name = "btmBefore";
            this.btmBefore.Size = new System.Drawing.Size(75, 23);
            this.btmBefore.TabIndex = 10;
            this.btmBefore.Text = "previous";
            this.btmBefore.UseVisualStyleBackColor = true;
            this.btmBefore.Click += new System.EventHandler(this.btmBefore_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(584, 49);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(75, 23);
            this.btnAfter.TabIndex = 9;
            this.btnAfter.Text = "next";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // pnlUC
            // 
            this.pnlUC.Location = new System.Drawing.Point(57, 110);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(961, 627);
            this.pnlUC.TabIndex = 7;
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCurrentMonth.Location = new System.Drawing.Point(422, 49);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(57, 20);
            this.lblCurrentMonth.TabIndex = 5;
            this.lblCurrentMonth.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "לוח שנה";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.Location = new System.Drawing.Point(42, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 25);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "label3";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(187, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "שעה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmBefore);
            this.Controls.Add(this.btnAfter);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.lblCurrentMonth);
            this.Controls.Add(this.label1);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmBefore;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}