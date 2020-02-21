namespace Server
{
    partial class Server_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.list_Connections = new System.Windows.Forms.ListBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.list_Port = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.text_Input = new System.Windows.Forms.TextBox();
            this.text_Console = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(297, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.list_Connections);
            this.tabPage1.Controls.Add(this.button_Refresh);
            this.tabPage1.Controls.Add(this.button_Disconnect);
            this.tabPage1.Controls.Add(this.button_Connect);
            this.tabPage1.Controls.Add(this.list_Port);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(290, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(212, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // list_Connections
            // 
            this.list_Connections.FormattingEnabled = true;
            this.list_Connections.Location = new System.Drawing.Point(167, 5);
            this.list_Connections.Name = "list_Connections";
            this.list_Connections.Size = new System.Drawing.Size(120, 69);
            this.list_Connections.TabIndex = 4;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(5, 138);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(119, 23);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(5, 109);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(119, 23);
            this.button_Disconnect.TabIndex = 2;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Location = new System.Drawing.Point(5, 80);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(119, 23);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // list_Port
            // 
            this.list_Port.FormattingEnabled = true;
            this.list_Port.Location = new System.Drawing.Point(5, 5);
            this.list_Port.Name = "list_Port";
            this.list_Port.Size = new System.Drawing.Size(120, 69);
            this.list_Port.TabIndex = 0;
            this.list_Port.SelectedIndexChanged += new System.EventHandler(this.list_Port_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(290, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text_Input
            // 
            this.text_Input.Location = new System.Drawing.Point(12, 336);
            this.text_Input.Name = "text_Input";
            this.text_Input.Size = new System.Drawing.Size(280, 20);
            this.text_Input.TabIndex = 3;
            this.text_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Input_KeyDown);
            // 
            // text_Console
            // 
            this.text_Console.BackColor = System.Drawing.SystemColors.Desktop;
            this.text_Console.ForeColor = System.Drawing.Color.Lime;
            this.text_Console.Location = new System.Drawing.Point(12, 10);
            this.text_Console.Multiline = true;
            this.text_Console.Name = "text_Console";
            this.text_Console.ReadOnly = true;
            this.text_Console.Size = new System.Drawing.Size(280, 320);
            this.text_Console.TabIndex = 4;
            // 
            // Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 361);
            this.Controls.Add(this.text_Console);
            this.Controls.Add(this.text_Input);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server_Form";
            this.Text = "Server";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ListBox list_Port;
        private System.Windows.Forms.TextBox text_Input;
        private System.Windows.Forms.TextBox text_Console;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ListBox list_Connections;
        private System.Windows.Forms.Button button2;
    }
}

