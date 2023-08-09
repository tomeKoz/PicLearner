namespace PicLearner
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.answ1button = new System.Windows.Forms.Button();
            this.answ2button = new System.Windows.Forms.Button();
            this.answ3button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(56, 149);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(159, 58);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(297, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sprawdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(144, 379);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 28);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "0/0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(355, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tryb wpisywania";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(355, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Tryb zgadywania";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // answ1button
            // 
            this.answ1button.Location = new System.Drawing.Point(543, 224);
            this.answ1button.Name = "answ1button";
            this.answ1button.Size = new System.Drawing.Size(169, 42);
            this.answ1button.TabIndex = 11;
            this.answ1button.UseVisualStyleBackColor = true;
            this.answ1button.Visible = false;
            this.answ1button.Click += new System.EventHandler(this.answ1button_Click);
            // 
            // answ2button
            // 
            this.answ2button.Location = new System.Drawing.Point(543, 272);
            this.answ2button.Name = "answ2button";
            this.answ2button.Size = new System.Drawing.Size(169, 42);
            this.answ2button.TabIndex = 12;
            this.answ2button.UseVisualStyleBackColor = true;
            this.answ2button.Visible = false;
            this.answ2button.Click += new System.EventHandler(this.answ2button_Click);
            // 
            // answ3button
            // 
            this.answ3button.Location = new System.Drawing.Point(543, 319);
            this.answ3button.Name = "answ3button";
            this.answ3button.Size = new System.Drawing.Size(169, 42);
            this.answ3button.TabIndex = 13;
            this.answ3button.UseVisualStyleBackColor = true;
            this.answ3button.Visible = false;
            this.answ3button.Click += new System.EventHandler(this.answ3button_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(543, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Dalej";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.answ3button);
            this.Controls.Add(this.answ2button);
            this.Controls.Add(this.answ1button);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button startButton;
        private Label label2;
        private Button button2;
        private Label resultLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button answ1button;
        private Button answ2button;
        private Button answ3button;
        private Button button3;
    }
}