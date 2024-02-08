namespace C__Nav_Multi_Windows
{
    partial class Form1
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
            BTN_F1 = new Button();
            label1 = new Label();
            button2 = new Button();
            BTN_F2 = new Button();
            BTN_F3 = new Button();
            label2 = new Label();
            BTN_F4 = new Button();
            BTN_F5 = new Button();
            BTN_F6 = new Button();
            SuspendLayout();
            // 
            // BTN_F1
            // 
            BTN_F1.BackColor = Color.DodgerBlue;
            BTN_F1.FlatAppearance.BorderSize = 0;
            BTN_F1.FlatStyle = FlatStyle.Flat;
            BTN_F1.ForeColor = Color.White;
            BTN_F1.Location = new Point(12, 116);
            BTN_F1.Name = "BTN_F1";
            BTN_F1.Size = new Size(135, 38);
            BTN_F1.TabIndex = 0;
            BTN_F1.Text = "Form 1";
            BTN_F1.UseVisualStyleBackColor = false;
            BTN_F1.Click += BTN_F1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 46);
            label1.TabIndex = 1;
            label1.Text = "HOME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(450, 0);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 2;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BTN_F2
            // 
            BTN_F2.BackColor = Color.DeepSkyBlue;
            BTN_F2.FlatAppearance.BorderSize = 0;
            BTN_F2.FlatStyle = FlatStyle.Flat;
            BTN_F2.ForeColor = Color.White;
            BTN_F2.Location = new Point(180, 116);
            BTN_F2.Name = "BTN_F2";
            BTN_F2.Size = new Size(135, 38);
            BTN_F2.TabIndex = 0;
            BTN_F2.Text = "Form 2";
            BTN_F2.UseVisualStyleBackColor = false;
            BTN_F2.Click += BTN_F2_Click;
            // 
            // BTN_F3
            // 
            BTN_F3.BackColor = Color.RoyalBlue;
            BTN_F3.FlatAppearance.BorderSize = 0;
            BTN_F3.FlatStyle = FlatStyle.Flat;
            BTN_F3.ForeColor = Color.White;
            BTN_F3.Location = new Point(348, 116);
            BTN_F3.Name = "BTN_F3";
            BTN_F3.Size = new Size(135, 38);
            BTN_F3.TabIndex = 0;
            BTN_F3.Text = "Form 3";
            BTN_F3.UseVisualStyleBackColor = false;
            BTN_F3.Click += BTN_F3_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(471, 23);
            label2.TabIndex = 3;
            label2.Text = "Naviguer dans les formulaires...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_F4
            // 
            BTN_F4.BackColor = Color.DodgerBlue;
            BTN_F4.FlatAppearance.BorderSize = 0;
            BTN_F4.FlatStyle = FlatStyle.Flat;
            BTN_F4.ForeColor = Color.White;
            BTN_F4.Location = new Point(12, 166);
            BTN_F4.Name = "BTN_F4";
            BTN_F4.Size = new Size(135, 38);
            BTN_F4.TabIndex = 0;
            BTN_F4.Text = "Form 4";
            BTN_F4.UseVisualStyleBackColor = false;
            // 
            // BTN_F5
            // 
            BTN_F5.BackColor = Color.DeepSkyBlue;
            BTN_F5.FlatAppearance.BorderSize = 0;
            BTN_F5.FlatStyle = FlatStyle.Flat;
            BTN_F5.ForeColor = Color.White;
            BTN_F5.Location = new Point(180, 166);
            BTN_F5.Name = "BTN_F5";
            BTN_F5.Size = new Size(135, 38);
            BTN_F5.TabIndex = 0;
            BTN_F5.Text = "Form 5";
            BTN_F5.UseVisualStyleBackColor = false;
            // 
            // BTN_F6
            // 
            BTN_F6.BackColor = Color.RoyalBlue;
            BTN_F6.FlatAppearance.BorderSize = 0;
            BTN_F6.FlatStyle = FlatStyle.Flat;
            BTN_F6.ForeColor = Color.White;
            BTN_F6.Location = new Point(348, 166);
            BTN_F6.Name = "BTN_F6";
            BTN_F6.Size = new Size(135, 38);
            BTN_F6.TabIndex = 0;
            BTN_F6.Text = "Form 6";
            BTN_F6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 220);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(BTN_F6);
            Controls.Add(BTN_F3);
            Controls.Add(BTN_F5);
            Controls.Add(BTN_F4);
            Controls.Add(BTN_F2);
            Controls.Add(BTN_F1);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_F1;
        private Label label1;
        private Button button2;
        private Button BTN_F2;
        private Button BTN_F3;
        private Label label2;
        private Button BTN_F4;
        private Button BTN_F5;
        private Button BTN_F6;
    }
}
