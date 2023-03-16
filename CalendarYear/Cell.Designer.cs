namespace CalendarYear
{
    partial class Cell
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
            this.lblCorrentDay = new System.Windows.Forms.Label();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblSunShine = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCorrentDay
            // 
            this.lblCorrentDay.AutoSize = true;
            this.lblCorrentDay.Location = new System.Drawing.Point(58, 9);
            this.lblCorrentDay.Name = "lblCorrentDay";
            this.lblCorrentDay.Size = new System.Drawing.Size(35, 13);
            this.lblCorrentDay.TabIndex = 3;
            this.lblCorrentDay.Text = "label1";
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Location = new System.Drawing.Point(81, 81);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(35, 13);
            this.lblNight.TabIndex = 16;
            this.lblNight.Text = "label9";
            // 
            // lblSunShine
            // 
            this.lblSunShine.AutoSize = true;
            this.lblSunShine.Location = new System.Drawing.Point(81, 37);
            this.lblSunShine.Name = "lblSunShine";
            this.lblSunShine.Size = new System.Drawing.Size(35, 13);
            this.lblSunShine.TabIndex = 15;
            this.lblSunShine.Text = "label7";
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(81, 59);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(35, 13);
            this.lblSunSet.TabIndex = 14;
            this.lblSunSet.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "נץ החמה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "שקיעה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "צאת הכוכבים";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(13, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(35, 13);
            this.lblDay.TabIndex = 17;
            this.lblDay.Text = "label7";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(17, 46);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "label1";
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.lblSunShine);
            this.Controls.Add(this.lblSunSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCorrentDay);
            this.Controls.Add(this.lblError);
            this.Name = "Cell";
            this.Size = new System.Drawing.Size(125, 101);
            this.DoubleClick += new System.EventHandler(this.Cell_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrentDay;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblSunShine;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblError;
    }
}
