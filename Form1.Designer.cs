namespace WinFormMethod
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH SarabunPSK", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(693, 94);
            label1.Name = "label1";
            label1.Size = new Size(316, 57);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(182, 470);
            label2.Name = "label2";
            label2.Size = new Size(158, 53);
            label2.TabIndex = 1;
            label2.Text = "น้ำหนัก (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(180, 387);
            label3.Name = "label3";
            label3.Size = new Size(168, 53);
            label3.TabIndex = 2;
            label3.Text = "ส่วนสูง (cm)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(180, 226);
            label4.Name = "label4";
            label4.Size = new Size(159, 53);
            label4.TabIndex = 3;
            label4.Text = "ชื่อ-นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(182, 305);
            label5.Name = "label5";
            label5.Size = new Size(67, 53);
            label5.TabIndex = 4;
            label5.Text = "อายุ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.DeepSkyBlue;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            txtName.ForeColor = Color.DarkBlue;
            txtName.Location = new Point(355, 224);
            txtName.Name = "txtName";
            txtName.Size = new Size(388, 60);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.DeepSkyBlue;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            txtAge.ForeColor = Color.DarkBlue;
            txtAge.Location = new Point(355, 303);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 60);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.DeepSkyBlue;
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            txtHeight.ForeColor = Color.DarkBlue;
            txtHeight.Location = new Point(355, 385);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 60);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.DeepSkyBlue;
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            txtWeight.ForeColor = Color.DarkBlue;
            txtWeight.Location = new Point(355, 468);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 60);
            txtWeight.TabIndex = 4;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.MediumBlue;
            btnBMI.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            btnBMI.ForeColor = Color.Aqua;
            btnBMI.Location = new Point(539, 345);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(194, 109);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.DeepSkyBlue;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold);
            lblResult.ForeColor = Color.DarkBlue;
            lblResult.Location = new Point(802, 224);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(832, 589);
            lblResult.TabIndex = 10;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumBlue;
            btnClear.Font = new Font("TH SarabunPSK", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Aqua;
            btnClear.Location = new Point(540, 470);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(193, 115);
            btnClear.TabIndex = 6;
            btnClear.Text = "เริ่มต้นใหม่";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1696, 845);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CalculateBMI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnBMI;
        private Label lblResult;
        private Button btnClear;
    }
}
