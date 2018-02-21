namespace Accountig
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl TabControl;
            this.ShowClients = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddClient = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpdateClinet = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ClientByName = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            TabControl = new System.Windows.Forms.TabControl();
            TabControl.SuspendLayout();
            this.ShowClients.SuspendLayout();
            this.AddClient.SuspendLayout();
            this.UpdateClinet.SuspendLayout();
            this.Delete.SuspendLayout();
            this.ClientByName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(this.ShowClients);
            TabControl.Controls.Add(this.AddClient);
            TabControl.Controls.Add(this.UpdateClinet);
            TabControl.Controls.Add(this.Delete);
            TabControl.Controls.Add(this.ClientByName);
            TabControl.Location = new System.Drawing.Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(578, 327);
            TabControl.TabIndex = 0;
            // 
            // ShowClients
            // 
            this.ShowClients.Controls.Add(this.listBox2);
            this.ShowClients.Controls.Add(this.listBox1);
            this.ShowClients.Location = new System.Drawing.Point(4, 22);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Padding = new System.Windows.Forms.Padding(3);
            this.ShowClients.Size = new System.Drawing.Size(570, 301);
            this.ShowClients.TabIndex = 0;
            this.ShowClients.Text = "Clients";
            this.ShowClients.UseVisualStyleBackColor = true;
            this.ShowClients.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(412, 132);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(128, 30);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            // 
            // AddClient
            // 
            this.AddClient.Controls.Add(this.label6);
            this.AddClient.Controls.Add(this.button1);
            this.AddClient.Controls.Add(this.label2);
            this.AddClient.Controls.Add(this.label1);
            this.AddClient.Controls.Add(this.textBox2);
            this.AddClient.Controls.Add(this.textBox1);
            this.AddClient.Location = new System.Drawing.Point(4, 22);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(3);
            this.AddClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddClient.Size = new System.Drawing.Size(570, 301);
            this.AddClient.TabIndex = 1;
            this.AddClient.Text = "Add";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(210, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // UpdateClinet
            // 
            this.UpdateClinet.Controls.Add(this.label8);
            this.UpdateClinet.Controls.Add(this.label5);
            this.UpdateClinet.Controls.Add(this.textBox5);
            this.UpdateClinet.Controls.Add(this.button2);
            this.UpdateClinet.Controls.Add(this.label3);
            this.UpdateClinet.Controls.Add(this.label4);
            this.UpdateClinet.Controls.Add(this.textBox3);
            this.UpdateClinet.Controls.Add(this.textBox4);
            this.UpdateClinet.Location = new System.Drawing.Point(4, 22);
            this.UpdateClinet.Name = "UpdateClinet";
            this.UpdateClinet.Size = new System.Drawing.Size(570, 301);
            this.UpdateClinet.TabIndex = 2;
            this.UpdateClinet.Text = "Update";
            this.UpdateClinet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 42);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(234, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.label9);
            this.Delete.Controls.Add(this.button4);
            this.Delete.Controls.Add(this.label7);
            this.Delete.Controls.Add(this.textBox8);
            this.Delete.Location = new System.Drawing.Point(4, 22);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(570, 301);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "labe9";
            this.label9.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(229, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 6;
            // 
            // ClientByName
            // 
            this.ClientByName.Controls.Add(this.listBox3);
            this.ClientByName.Controls.Add(this.button3);
            this.ClientByName.Controls.Add(this.textBox6);
            this.ClientByName.Location = new System.Drawing.Point(4, 22);
            this.ClientByName.Name = "ClientByName";
            this.ClientByName.Size = new System.Drawing.Size(570, 301);
            this.ClientByName.TabIndex = 3;
            this.ClientByName.Text = "Client by Name";
            this.ClientByName.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(8, 8);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(554, 95);
            this.listBox3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(164, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 327);
            this.Controls.Add(TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Accounting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            TabControl.ResumeLayout(false);
            this.ShowClients.ResumeLayout(false);
            this.AddClient.ResumeLayout(false);
            this.AddClient.PerformLayout();
            this.UpdateClinet.ResumeLayout(false);
            this.UpdateClinet.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            this.ClientByName.ResumeLayout(false);
            this.ClientByName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage ShowClients;
        private System.Windows.Forms.TabPage AddClient;
        private System.Windows.Forms.TabPage UpdateClinet;
        private System.Windows.Forms.TabPage ClientByName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox3;
    }
}

