namespace ArduinoRemoteCar
{
    partial class tb_clear_data
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
            this.tb_serial_data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_NL = new System.Windows.Forms.CheckBox();
            this.cb_CR = new System.Windows.Forms.CheckBox();
            this.lb_send_txt = new System.Windows.Forms.Label();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_serial_data
            // 
            this.tb_serial_data.Location = new System.Drawing.Point(12, 88);
            this.tb_serial_data.Multiline = true;
            this.tb_serial_data.Name = "tb_serial_data";
            this.tb_serial_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_serial_data.Size = new System.Drawing.Size(460, 264);
            this.tb_serial_data.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(409, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb_NL
            // 
            this.cb_NL.AutoSize = true;
            this.cb_NL.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_NL.Location = new System.Drawing.Point(367, 9);
            this.cb_NL.Name = "cb_NL";
            this.cb_NL.Size = new System.Drawing.Size(39, 20);
            this.cb_NL.TabIndex = 2;
            this.cb_NL.Text = "\\n";
            this.cb_NL.UseVisualStyleBackColor = true;
            // 
            // cb_CR
            // 
            this.cb_CR.AutoSize = true;
            this.cb_CR.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_CR.Location = new System.Drawing.Point(367, 28);
            this.cb_CR.Name = "cb_CR";
            this.cb_CR.Size = new System.Drawing.Size(36, 20);
            this.cb_CR.TabIndex = 3;
            this.cb_CR.Text = "\\r";
            this.cb_CR.UseVisualStyleBackColor = true;
            // 
            // lb_send_txt
            // 
            this.lb_send_txt.AutoSize = true;
            this.lb_send_txt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_send_txt.Location = new System.Drawing.Point(9, 20);
            this.lb_send_txt.Name = "lb_send_txt";
            this.lb_send_txt.Size = new System.Drawing.Size(64, 16);
            this.lb_send_txt.TabIndex = 4;
            this.lb_send_txt.Text = "Send text:";
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(77, 18);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(281, 22);
            this.tb_command.TabIndex = 5;
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_save.Location = new System.Drawing.Point(12, 59);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(110, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save to file";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(409, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb_clear_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tb_command);
            this.Controls.Add(this.lb_send_txt);
            this.Controls.Add(this.cb_CR);
            this.Controls.Add(this.cb_NL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_serial_data);
            this.Name = "tb_clear_data";
            this.Text = "Serial Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_serial_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_NL;
        private System.Windows.Forms.CheckBox cb_CR;
        private System.Windows.Forms.Label lb_send_txt;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button button2;
    }
}