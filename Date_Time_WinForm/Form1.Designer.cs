namespace Date_Time_WinForm
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
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.btnCompare = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(64, 37);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(26, 13);
            this.lbFirst.TabIndex = 0;
            this.lbFirst.Text = "First";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(64, 91);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(44, 13);
            this.lbSecond.TabIndex = 1;
            this.lbSecond.Text = "Second";
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Location = new System.Drawing.Point(215, 37);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFirst.TabIndex = 2;
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Location = new System.Drawing.Point(215, 91);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSecond.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(441, 119);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(45, 148);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(392, 101);
            this.textBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dateTimePickerSecond);
            this.Controls.Add(this.dateTimePickerFirst);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox textBox;
    }
}

