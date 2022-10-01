namespace assignment4_yevhenii
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.input_num = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a positive integer to calculate a factorial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_calc.Location = new System.Drawing.Point(25, 96);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(347, 36);
            this.btn_calc.TabIndex = 1;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // input_num
            // 
            this.input_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_num.Location = new System.Drawing.Point(25, 54);
            this.input_num.Name = "input_num";
            this.input_num.Size = new System.Drawing.Size(347, 26);
            this.input_num.TabIndex = 2;
            this.input_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_result
            // 
            this.label_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_result.Location = new System.Drawing.Point(25, 146);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(347, 27);
            this.label_result.TabIndex = 3;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.input_num);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.Label label_result;
    }
}

