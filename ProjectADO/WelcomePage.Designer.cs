namespace ProjectADO
{
    partial class WelcomePage
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
            label1 = new Label();
            btn_Reg = new Button();
            btn_log = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(252, 25);
            label1.Name = "label1";
            label1.Size = new Size(282, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome Page";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Reg
            // 
            btn_Reg.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_Reg.Location = new Point(123, 238);
            btn_Reg.Name = "btn_Reg";
            btn_Reg.Size = new Size(130, 49);
            btn_Reg.TabIndex = 1;
            btn_Reg.Text = "Register";
            btn_Reg.UseVisualStyleBackColor = true;
            btn_Reg.Click += btn_Reg_Click;
            // 
            // btn_log
            // 
            btn_log.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_log.Location = new Point(524, 238);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(133, 49);
            btn_log.TabIndex = 2;
            btn_log.Text = "Login";
            btn_log.UseVisualStyleBackColor = true;
            btn_log.Click += btn_log_Click_1;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_log);
            Controls.Add(btn_Reg);
            Controls.Add(label1);
            Name = "WelcomePage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Reg;
        private Button btn_log;
    }
}
