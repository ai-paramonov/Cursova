using System.Windows.Forms;

namespace Cursova
{
    public partial class Form1 : Form
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
            this.Startbutton = new System.Windows.Forms.Button();
            this.radioCaesar = new System.Windows.Forms.RadioButton();
            this.radioAtbush = new System.Windows.Forms.RadioButton();
            this.radioVigenere = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.Choosebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.Enabled = false;
            this.Startbutton.Location = new System.Drawing.Point(349, 327);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(94, 29);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // radioCaesar
            // 
            this.radioCaesar.AutoSize = true;
            this.radioCaesar.Location = new System.Drawing.Point(23, 64);
            this.radioCaesar.Name = "radioCaesar";
            this.radioCaesar.Size = new System.Drawing.Size(74, 24);
            this.radioCaesar.TabIndex = 1;
            this.radioCaesar.Text = "Caesar";
            this.radioCaesar.UseVisualStyleBackColor = true;
            this.radioCaesar.CheckedChanged += new System.EventHandler(this.radioCaesar_CheckedChanged);
            // 
            // radioAtbush
            // 
            this.radioAtbush.AutoSize = true;
            this.radioAtbush.Checked = true;
            this.radioAtbush.Location = new System.Drawing.Point(23, 32);
            this.radioAtbush.Name = "radioAtbush";
            this.radioAtbush.Size = new System.Drawing.Size(76, 24);
            this.radioAtbush.TabIndex = 2;
            this.radioAtbush.TabStop = true;
            this.radioAtbush.Text = "Atbush";
            this.radioAtbush.UseVisualStyleBackColor = true;
            this.radioAtbush.CheckedChanged += new System.EventHandler(this.radioAtbush_CheckedChanged);
            // 
            // radioVigenere
            // 
            this.radioVigenere.AutoSize = true;
            this.radioVigenere.Location = new System.Drawing.Point(23, 95);
            this.radioVigenere.Name = "radioVigenere";
            this.radioVigenere.Size = new System.Drawing.Size(89, 24);
            this.radioVigenere.TabIndex = 3;
            this.radioVigenere.Text = "Vigenere";
            this.radioVigenere.UseVisualStyleBackColor = true;
            this.radioVigenere.CheckedChanged += new System.EventHandler(this.radioVigenere_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(339, 233);
            this.textBox1.MaxLength = 33;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Checked = true;
            this.radioEncrypt.Location = new System.Drawing.Point(22, 43);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(79, 24);
            this.radioEncrypt.TabIndex = 6;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            this.radioEncrypt.CheckedChanged += new System.EventHandler(this.radioEncrypt_CheckedChanged);
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(22, 73);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(82, 24);
            this.radioDecrypt.TabIndex = 7;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            this.radioDecrypt.CheckedChanged += new System.EventHandler(this.radioDecrypt_CheckedChanged);
            // 
            // Choosebutton
            // 
            this.Choosebutton.Location = new System.Drawing.Point(349, 124);
            this.Choosebutton.Name = "Choosebutton";
            this.Choosebutton.Size = new System.Drawing.Size(94, 29);
            this.Choosebutton.TabIndex = 8;
            this.Choosebutton.Text = "Choose File";
            this.Choosebutton.UseVisualStyleBackColor = true;
            this.Choosebutton.Click += new System.EventHandler(this.Choosebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCaesar);
            this.groupBox1.Controls.Add(this.radioAtbush);
            this.groupBox1.Controls.Add(this.radioVigenere);
            this.groupBox1.Location = new System.Drawing.Point(59, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEncrypt);
            this.groupBox2.Controls.Add(this.radioDecrypt);
            this.groupBox2.Location = new System.Drawing.Point(487, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(12, 406);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(85, 32);
            this.HelpButton.TabIndex = 13;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Choosebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Startbutton);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Startbutton;
        private RadioButton radioCaesar;
        private RadioButton radioAtbush;
        private RadioButton radioVigenere;
        private TextBox textBox1;
        private Label label1;
        private RadioButton radioEncrypt;
        private RadioButton radioDecrypt;
        private Button Choosebutton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button HelpButton;
    }
}

