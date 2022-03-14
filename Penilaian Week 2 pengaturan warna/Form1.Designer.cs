namespace Penilaian_Week_2_pengaturan_warna
{
    partial class FormPengaturanWarna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputData = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputData
            // 
            this.lblInputData.AutoSize = true;
            this.lblInputData.Location = new System.Drawing.Point(45, 41);
            this.lblInputData.Name = "lblInputData";
            this.lblInputData.Size = new System.Drawing.Size(105, 25);
            this.lblInputData.TabIndex = 1;
            this.lblInputData.Text = "Input Data :";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(51, 84);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(346, 31);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(51, 155);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(112, 34);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(51, 237);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(130, 38);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "[EMPTY]";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInputData);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputData;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button BtnWarna;
        private System.Windows.Forms.Button btnrestart;
    }
}
