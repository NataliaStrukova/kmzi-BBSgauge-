namespace BBSgauge
{
    partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userGenerationButton = new System.Windows.Forms.Button();
            this.textBoxUserGeneration = new System.Windows.Forms.TextBox();
            this.labelUserGeneration = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Autogeneration";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Generation by user";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(6, 74);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(63, 26);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userGenerationButton);
            this.groupBox1.Controls.Add(this.textBoxUserGeneration);
            this.groupBox1.Controls.Add(this.labelUserGeneration);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.goButton);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial settings ";
            // 
            // userGenerationButton
            // 
            this.userGenerationButton.Location = new System.Drawing.Point(149, 74);
            this.userGenerationButton.Name = "userGenerationButton";
            this.userGenerationButton.Size = new System.Drawing.Size(63, 26);
            this.userGenerationButton.TabIndex = 5;
            this.userGenerationButton.Text = "Generate";
            this.userGenerationButton.UseVisualStyleBackColor = true;
            this.userGenerationButton.Visible = false;
            this.userGenerationButton.Click += new System.EventHandler(this.userGenerationButton_Click);
            // 
            // textBoxUserGeneration
            // 
            this.textBoxUserGeneration.Location = new System.Drawing.Point(149, 51);
            this.textBoxUserGeneration.Name = "textBoxUserGeneration";
            this.textBoxUserGeneration.Size = new System.Drawing.Size(93, 20);
            this.textBoxUserGeneration.TabIndex = 4;
            this.textBoxUserGeneration.Visible = false;
            // 
            // labelUserGeneration
            // 
            this.labelUserGeneration.AutoSize = true;
            this.labelUserGeneration.Location = new System.Drawing.Point(146, 28);
            this.labelUserGeneration.Name = "labelUserGeneration";
            this.labelUserGeneration.Size = new System.Drawing.Size(96, 13);
            this.labelUserGeneration.TabIndex = 3;
            this.labelUserGeneration.Text = "Enter start number:";
            this.labelUserGeneration.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "More options";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 166);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(287, 184);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Algorithm Blum — Blum — Shub";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button userGenerationButton;
        private System.Windows.Forms.TextBox textBoxUserGeneration;
        private System.Windows.Forms.Label labelUserGeneration;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

