namespace AttributeFormApp
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
            nameBox = new TextBox();
            departmentBox = new TextBox();
            surnameBox = new TextBox();
            dateOfBirthBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(239, 37);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Screen";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 11F);
            nameBox.Location = new Point(376, 102);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(126, 27);
            nameBox.TabIndex = 1;
            // 
            // departmentBox
            // 
            departmentBox.Font = new Font("Segoe UI", 11F);
            departmentBox.Location = new Point(376, 191);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(126, 27);
            departmentBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 11F);
            surnameBox.Location = new Point(376, 150);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(126, 27);
            surnameBox.TabIndex = 3;
            // 
            // dateOfBirthBox
            // 
            dateOfBirthBox.Font = new Font("Segoe UI", 11F);
            dateOfBirthBox.Location = new Point(376, 239);
            dateOfBirthBox.Name = "dateOfBirthBox";
            dateOfBirthBox.Size = new Size(126, 27);
            dateOfBirthBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(264, 108);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(264, 156);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 6;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(264, 197);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 7;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(264, 245);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(396, 311);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateOfBirthBox);
            Controls.Add(surnameBox);
            Controls.Add(departmentBox);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private TextBox departmentBox;
        private TextBox surnameBox;
        private TextBox dateOfBirthBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
