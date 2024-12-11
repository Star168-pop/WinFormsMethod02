namespace WinFormsMethod02
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
            รูปวงกลม = new GroupBox();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnOutputParameter = new Button();
            txtInput = new TextBox();
            btnRefParameter = new Button();
            txtSize = new Button();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            txtOutput = new TextBox();
            รูปวงกลม.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // รูปวงกลม
            // 
            รูปวงกลม.BackColor = Color.FromArgb(255, 255, 192);
            รูปวงกลม.Controls.Add(btnCircumference);
            รูปวงกลม.Controls.Add(btnCircleArea);
            รูปวงกลม.Controls.Add(txtRadius);
            รูปวงกลม.Controls.Add(lblResult);
            รูปวงกลม.Controls.Add(label1);
            รูปวงกลม.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            รูปวงกลม.Location = new Point(37, 27);
            รูปวงกลม.Name = "รูปวงกลม";
            รูปวงกลม.Size = new Size(628, 215);
            รูปวงกลม.TabIndex = 0;
            รูปวงกลม.TabStop = false;
            รูปวงกลม.Text = "รูปวงกลม";
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(451, 52);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(99, 40);
            btnCircumference.TabIndex = 5;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(301, 52);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(97, 41);
            btnCircleArea.TabIndex = 4;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(120, 52);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 29);
            txtRadius.TabIndex = 3;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.Location = new Point(120, 114);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(376, 83);
            lblResult.TabIndex = 1;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(16, 54);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(btnOutputParameter);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(btnRefParameter);
            groupBox1.Controls.Add(txtSize);
            groupBox1.Controls.Add(txtLetter);
            groupBox1.Controls.Add(btnTriangle01);
            groupBox1.Controls.Add(txtOutput);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(701, 366);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ทดสอบ function";
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(390, 286);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(238, 42);
            btnOutputParameter.TabIndex = 6;
            btnOutputParameter.Text = "ทดสอบ output parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(390, 179);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(238, 29);
            txtInput.TabIndex = 5;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(390, 227);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(238, 42);
            btnRefParameter.TabIndex = 4;
            btnRefParameter.Text = "ทดสอบ reference parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(368, 121);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 32);
            txtSize.TabIndex = 3;
            txtSize.Text = "5";
            txtSize.UseVisualStyleBackColor = true;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(368, 62);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(100, 29);
            txtLetter.TabIndex = 2;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(509, 48);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(119, 54);
            btnTriangle01.TabIndex = 1;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(255, 255, 192);
            txtOutput.Location = new Point(88, 36);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(232, 292);
            txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(groupBox1);
            Controls.Add(รูปวงกลม);
            Name = "Form1";
            Text = "Windows form Method(Function)";
            รูปวงกลม.ResumeLayout(false);
            รูปวงกลม.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox รูปวงกลม;
        private Label lblResult;
        private Label label1;
        private Button btnCircumference;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private GroupBox groupBox1;
        private TextBox txtOutput;
        private Button txtSize;
        private TextBox txtLetter;
        private Button btnTriangle01;
        private Button btnRefParameter;
        private TextBox txtInput;
        private Button btnOutputParameter;
    }
}
