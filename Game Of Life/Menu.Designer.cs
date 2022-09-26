namespace Game_Of_Life
{
    partial class Menu
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
            this.randomFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blueOption = new System.Windows.Forms.RadioButton();
            this.grayOption = new System.Windows.Forms.RadioButton();
            this.blackOption = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.whiteOption = new System.Windows.Forms.RadioButton();
            this.greenOption = new System.Windows.Forms.RadioButton();
            this.redOption = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pinkOption = new System.Windows.Forms.RadioButton();
            this.yellowOption = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.randomLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // randomFactor
            // 
            this.randomFactor.Location = new System.Drawing.Point(655, 12);
            this.randomFactor.Name = "randomFactor";
            this.randomFactor.Size = new System.Drawing.Size(200, 39);
            this.randomFactor.TabIndex = 0;
            this.randomFactor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Random Factor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bacground Color:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blueOption);
            this.panel1.Controls.Add(this.grayOption);
            this.panel1.Controls.Add(this.blackOption);
            this.panel1.Location = new System.Drawing.Point(10, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 187);
            this.panel1.TabIndex = 4;
            // 
            // blueOption
            // 
            this.blueOption.AutoSize = true;
            this.blueOption.Location = new System.Drawing.Point(14, 123);
            this.blueOption.Name = "blueOption";
            this.blueOption.Size = new System.Drawing.Size(92, 36);
            this.blueOption.TabIndex = 2;
            this.blueOption.TabStop = true;
            this.blueOption.Text = "Blue";
            this.blueOption.UseVisualStyleBackColor = true;
            // 
            // grayOption
            // 
            this.grayOption.AutoSize = true;
            this.grayOption.Location = new System.Drawing.Point(14, 71);
            this.grayOption.Name = "grayOption";
            this.grayOption.Size = new System.Drawing.Size(93, 36);
            this.grayOption.TabIndex = 1;
            this.grayOption.TabStop = true;
            this.grayOption.Text = "Gray";
            this.grayOption.UseVisualStyleBackColor = true;
            // 
            // blackOption
            // 
            this.blackOption.AutoSize = true;
            this.blackOption.Checked = true;
            this.blackOption.Location = new System.Drawing.Point(14, 17);
            this.blackOption.Name = "blackOption";
            this.blackOption.Size = new System.Drawing.Size(100, 36);
            this.blackOption.TabIndex = 0;
            this.blackOption.TabStop = true;
            this.blackOption.Text = "Black";
            this.blackOption.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cell Color:";
            // 
            // whiteOption
            // 
            this.whiteOption.AutoSize = true;
            this.whiteOption.Checked = true;
            this.whiteOption.Location = new System.Drawing.Point(23, 19);
            this.whiteOption.Name = "whiteOption";
            this.whiteOption.Size = new System.Drawing.Size(108, 36);
            this.whiteOption.TabIndex = 0;
            this.whiteOption.TabStop = true;
            this.whiteOption.Text = "White";
            this.whiteOption.UseVisualStyleBackColor = true;
            // 
            // greenOption
            // 
            this.greenOption.AutoSize = true;
            this.greenOption.Location = new System.Drawing.Point(23, 76);
            this.greenOption.Name = "greenOption";
            this.greenOption.Size = new System.Drawing.Size(109, 36);
            this.greenOption.TabIndex = 1;
            this.greenOption.TabStop = true;
            this.greenOption.Text = "Green";
            this.greenOption.UseVisualStyleBackColor = true;
            // 
            // redOption
            // 
            this.redOption.AutoSize = true;
            this.redOption.Location = new System.Drawing.Point(23, 131);
            this.redOption.Name = "redOption";
            this.redOption.Size = new System.Drawing.Size(85, 36);
            this.redOption.TabIndex = 2;
            this.redOption.TabStop = true;
            this.redOption.Text = "Red";
            this.redOption.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pinkOption);
            this.panel2.Controls.Add(this.yellowOption);
            this.panel2.Controls.Add(this.redOption);
            this.panel2.Controls.Add(this.greenOption);
            this.panel2.Controls.Add(this.whiteOption);
            this.panel2.Location = new System.Drawing.Point(457, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 334);
            this.panel2.TabIndex = 6;
            // 
            // pinkOption
            // 
            this.pinkOption.AutoSize = true;
            this.pinkOption.Location = new System.Drawing.Point(23, 253);
            this.pinkOption.Name = "pinkOption";
            this.pinkOption.Size = new System.Drawing.Size(90, 36);
            this.pinkOption.TabIndex = 4;
            this.pinkOption.TabStop = true;
            this.pinkOption.Text = "Pink";
            this.pinkOption.UseVisualStyleBackColor = true;
            // 
            // yellowOption
            // 
            this.yellowOption.AutoSize = true;
            this.yellowOption.Location = new System.Drawing.Point(23, 189);
            this.yellowOption.Name = "yellowOption";
            this.yellowOption.Size = new System.Drawing.Size(112, 36);
            this.yellowOption.TabIndex = 3;
            this.yellowOption.TabStop = true;
            this.yellowOption.Text = "Yellow";
            this.yellowOption.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.Location = new System.Drawing.Point(10, 9);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(0, 32);
            this.randomLabel.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear Board";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomFactor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox randomFactor;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private RadioButton blueOption;
        private RadioButton grayOption;
        private RadioButton blackOption;
        private Label label3;
        private RadioButton whiteOption;
        private RadioButton greenOption;
        private RadioButton redOption;
        private Panel panel2;
        private RadioButton pinkOption;
        private RadioButton yellowOption;
        private Button button1;
        private Label randomLabel;
        private Button button2;
    }
}