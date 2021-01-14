
namespace advanced_c_chapter_1_Nick_vr
{
    partial class formGrades
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
            this.numericResult = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericResult)).BeginInit();
            this.SuspendLayout();
            // 
            // numericResult
            // 
            this.numericResult.Location = new System.Drawing.Point(28, 46);
            this.numericResult.Name = "numericResult";
            this.numericResult.Size = new System.Drawing.Size(120, 20);
            this.numericResult.TabIndex = 0;
            this.numericResult.ValueChanged += new System.EventHandler(this.numericResult_ValueChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(28, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.Location = new System.Drawing.Point(28, 84);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(120, 23);
            this.btnCheckResult.TabIndex = 2;
            this.btnCheckResult.Text = "Check result";
            this.btnCheckResult.UseVisualStyleBackColor = true;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(186, 65);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(13, 13);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "?";
            // 
            // formGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 153);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numericResult);
            this.Name = "formGrades";
            this.Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)(this.numericResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Label lblGrade;
    }
}

