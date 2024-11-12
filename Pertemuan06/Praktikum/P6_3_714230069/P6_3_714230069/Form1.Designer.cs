namespace P6_3_714230069
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txHuruf = new System.Windows.Forms.Label();
            this.txAngka = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txAngka1 = new System.Windows.Forms.Label();
            this.txAngka2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txHuruf
            // 
            this.txHuruf.AutoSize = true;
            this.txHuruf.Location = new System.Drawing.Point(127, 60);
            this.txHuruf.Name = "txHuruf";
            this.txHuruf.Size = new System.Drawing.Size(38, 16);
            this.txHuruf.TabIndex = 0;
            this.txHuruf.Text = "Huruf";
            // 
            // txAngka
            // 
            this.txAngka.AutoSize = true;
            this.txAngka.Location = new System.Drawing.Point(127, 91);
            this.txAngka.Name = "txAngka";
            this.txAngka.Size = new System.Drawing.Size(46, 16);
            this.txAngka.TabIndex = 1;
            this.txAngka.Text = "Angka";
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(130, 123);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(41, 16);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(127, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Angka 1 > Angka 2";
            // 
            // txAngka1
            // 
            this.txAngka1.AutoSize = true;
            this.txAngka1.Location = new System.Drawing.Point(127, 189);
            this.txAngka1.Name = "txAngka1";
            this.txAngka1.Size = new System.Drawing.Size(56, 16);
            this.txAngka1.TabIndex = 4;
            this.txAngka1.Text = "Angka 1";
            // 
            // txAngka2
            // 
            this.txAngka2.AutoSize = true;
            this.txAngka2.Location = new System.Drawing.Point(127, 217);
            this.txAngka2.Name = "txAngka2";
            this.txAngka2.Size = new System.Drawing.Size(56, 16);
            this.txAngka2.TabIndex = 5;
            this.txAngka2.Text = "Angka 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(276, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(276, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txAngka2);
            this.Controls.Add(this.txAngka1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txAngka);
            this.Controls.Add(this.txHuruf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txHuruf;
        private System.Windows.Forms.Label txAngka;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txAngka1;
        private System.Windows.Forms.Label txAngka2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

