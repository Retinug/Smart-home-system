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
            this.text_Input = new System.Windows.Forms.TextBox();
            this.text_Console = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.list_Connections = new System.Windows.Forms.ListBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.list_Port = new System.Windows.Forms.ListBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.text_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Console.Size = new System.Drawing.Size(280, 320);
            this.text_Console.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(431, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // list_Connections
            // 
            this.list_Connections.FormattingEnabled = true;
            this.list_Connections.Location = new System.Drawing.Point(431, 12);
            this.list_Connections.Name = "list_Connections";
            this.list_Connections.Size = new System.Drawing.Size(120, 69);
            this.list_Connections.TabIndex = 11;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(305, 145);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(119, 23);
            this.button_Refresh.TabIndex = 10;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(305, 116);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(119, 23);
            this.button_Disconnect.TabIndex = 9;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Location = new System.Drawing.Point(305, 87);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(119, 23);
            this.button_Connect.TabIndex = 8;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // list_Port
            // 
            this.list_Port.FormattingEnabled = true;
            this.list_Port.Location = new System.Drawing.Point(305, 12);
            this.list_Port.Name = "list_Port";
            this.list_Port.Size = new System.Drawing.Size(120, 69);
            this.list_Port.TabIndex = 7;
            this.list_Port.SelectedIndexChanged += new System.EventHandler(this.list_Port_SelectedIndexChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(302, 336);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 13);
            this.labelIP.TabIndex = 13;
            this.labelIP.Text = "IP:";
            // 
            // Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 361);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list_Connections);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.list_Port);
            this.Controls.Add(this.text_Console);
            this.Controls.Add(this.text_Input);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Server_Form";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox list_Connections;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label labelIP;
        public System.Windows.Forms.Button button_Disconnect;
        public System.Windows.Forms.Button button_Connect;
        public System.Windows.Forms.TextBox text_Input;
        public System.Windows.Forms.TextBox text_Console;
        public System.Windows.Forms.ListBox list_Port;
    }
}

