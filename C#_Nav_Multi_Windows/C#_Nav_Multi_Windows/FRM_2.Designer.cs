namespace C__Nav_Multi_Windows
{
    partial class FRM_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_2));
            label2 = new Label();
            BTN_back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(472, 99);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BTN_back
            // 
            BTN_back.BackColor = SystemColors.Control;
            BTN_back.FlatAppearance.BorderSize = 0;
            BTN_back.FlatStyle = FlatStyle.Flat;
            BTN_back.ForeColor = Color.DeepSkyBlue;
            BTN_back.Location = new Point(12, 15);
            BTN_back.Name = "BTN_back";
            BTN_back.Size = new Size(75, 46);
            BTN_back.TabIndex = 6;
            BTN_back.Text = "<< Back";
            BTN_back.UseVisualStyleBackColor = false;
            BTN_back.Click += BTN_back_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(472, 46);
            label1.TabIndex = 5;
            label1.Text = "FORMULAIRE 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FRM_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 220);
            Controls.Add(label2);
            Controls.Add(BTN_back);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_2";
            Text = "FRM_2";
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button BTN_back;
        private Label label1;
    }
}