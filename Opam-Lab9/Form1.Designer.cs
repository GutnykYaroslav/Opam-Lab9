namespace Opam_Lab9
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
            rbEasy = new RadioButton();
            rbMedium = new RadioButton();
            rbHard = new RadioButton();
            cbReadFromFile = new CheckBox();
            btGenerate = new Button();
            txtResult = new TextBox();
            btnViewPasswords = new Button();
            SuspendLayout();
            // 
            // rbEasy
            // 
            rbEasy.AutoSize = true;
            rbEasy.Location = new Point(151, 63);
            rbEasy.Name = "rbEasy";
            rbEasy.Size = new Size(79, 24);
            rbEasy.TabIndex = 0;
            rbEasy.TabStop = true;
            rbEasy.Text = "Легкий";
            rbEasy.UseVisualStyleBackColor = true;
            rbEasy.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(316, 63);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(94, 24);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Text = "Середній";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            rbHard.AutoSize = true;
            rbHard.Location = new Point(482, 63);
            rbHard.Name = "rbHard";
            rbHard.Size = new Size(83, 24);
            rbHard.TabIndex = 2;
            rbHard.TabStop = true;
            rbHard.Text = "Важкий";
            rbHard.UseVisualStyleBackColor = true;
            rbHard.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // cbReadFromFile
            // 
            cbReadFromFile.AutoSize = true;
            cbReadFromFile.Location = new Point(285, 112);
            cbReadFromFile.Name = "cbReadFromFile";
            cbReadFromFile.Size = new Size(201, 24);
            cbReadFromFile.TabIndex = 3;
            cbReadFromFile.Text = "Читати довжину з файлу";
            cbReadFromFile.UseVisualStyleBackColor = true;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(151, 228);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(200, 88);
            btGenerate.TabIndex = 4;
            btGenerate.Text = "Згенерувати";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(344, 195);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 5;
            // 
            // btnViewPasswords
            // 
            btnViewPasswords.Location = new Point(466, 228);
            btnViewPasswords.Name = "btnViewPasswords";
            btnViewPasswords.Size = new Size(200, 88);
            btnViewPasswords.TabIndex = 6;
            btnViewPasswords.Text = "Подивитись паролі";
            btnViewPasswords.UseVisualStyleBackColor = true;
            btnViewPasswords.Click += btnViewPasswords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewPasswords);
            Controls.Add(txtResult);
            Controls.Add(btGenerate);
            Controls.Add(cbReadFromFile);
            Controls.Add(rbHard);
            Controls.Add(rbMedium);
            Controls.Add(rbEasy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbEasy;
        private RadioButton rbMedium;
        private RadioButton rbHard;
        private CheckBox cbReadFromFile;
        private Button btGenerate;
        private TextBox txtResult;
        private Button btnViewPasswords;
    }
}
