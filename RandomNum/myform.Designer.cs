
namespace RandomNum
{
    partial class myform
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.pctOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandom.Location = new System.Drawing.Point(344, 278);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(278, 81);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Generate a number";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOutput.Location = new System.Drawing.Point(403, 189);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(176, 54);
            this.lblOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(407, 147);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(162, 27);
            this.txtInput.TabIndex = 2;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(160, 150);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(239, 20);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Enter the maximum number";
            // 
            // pctOutput
            // 
            this.pctOutput.Location = new System.Drawing.Point(786, 117);
            this.pctOutput.Name = "pctOutput";
            this.pctOutput.Size = new System.Drawing.Size(473, 362);
            this.pctOutput.TabIndex = 4;
            this.pctOutput.TabStop = false;
            // 
            // myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandomNum.Resource1.image2;
            this.ClientSize = new System.Drawing.Size(1380, 714);
            this.Controls.Add(this.pctOutput);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRandom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "myform";
            this.Text = "My New Form";
            ((System.ComponentModel.ISupportInitialize)(this.pctOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.PictureBox pctOutput;
    }
}

