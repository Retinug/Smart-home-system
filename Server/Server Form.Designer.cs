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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.list_Port = new System.Windows.Forms.ListBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Input
            // 
            this.text_Input.Location = new System.Drawing.Point(16, 414);
            this.text_Input.Margin = new System.Windows.Forms.Padding(4);
            this.text_Input.Name = "text_Input";
            this.text_Input.Size = new System.Drawing.Size(372, 22);
            this.text_Input.TabIndex = 3;
            this.text_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Input_KeyDown);
            // 
            // text_Console
            // 
            this.text_Console.BackColor = System.Drawing.SystemColors.Desktop;
            this.text_Console.ForeColor = System.Drawing.Color.Lime;
            this.text_Console.Location = new System.Drawing.Point(16, 12);
            this.text_Console.Margin = new System.Windows.Forms.Padding(4);
            this.text_Console.Multiline = true;
            this.text_Console.Name = "text_Console";
            this.text_Console.ReadOnly = true;
            this.text_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Console.Size = new System.Drawing.Size(372, 393);
            this.text_Console.TabIndex = 4;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(407, 178);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(160, 28);
            this.button_Refresh.TabIndex = 10;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(407, 143);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(160, 28);
            this.button_Disconnect.TabIndex = 9;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Location = new System.Drawing.Point(407, 107);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(160, 28);
            this.button_Connect.TabIndex = 8;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // list_Port
            // 
            this.list_Port.FormattingEnabled = true;
            this.list_Port.ItemHeight = 16;
            this.list_Port.Location = new System.Drawing.Point(407, 15);
            this.list_Port.Margin = new System.Windows.Forms.Padding(4);
            this.list_Port.Name = "list_Port";
            this.list_Port.Size = new System.Drawing.Size(160, 84);
            this.list_Port.TabIndex = 7;
            this.list_Port.SelectedIndexChanged += new System.EventHandler(this.list_Port_SelectedIndexChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(403, 414);
            this.labelIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(24, 17);
            this.labelIP.TabIndex = 13;
            this.labelIP.Text = "IP:";
            // 
            // Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 444);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.list_Port);
            this.Controls.Add(this.text_Console);
            this.Controls.Add(this.text_Input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Server_Form";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label labelIP;
        public System.Windows.Forms.Button button_Disconnect;
        public System.Windows.Forms.Button button_Connect;
        public System.Windows.Forms.TextBox text_Input;
        public System.Windows.Forms.TextBox text_Console;
        public System.Windows.Forms.ListBox list_Port;
    }
}

