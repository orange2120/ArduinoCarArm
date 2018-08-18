namespace ArduinoRemoteCar
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.bt_monitor = new System.Windows.Forms.Button();
            this.bt_rescan = new System.Windows.Forms.Button();
            this.bt_disc = new System.Windows.Forms.Button();
            this.bt_conn = new System.Windows.Forms.Button();
            this.cb_baud = new System.Windows.Forms.ComboBox();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.lb_baud = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.gb_dir_cmd = new System.Windows.Forms.GroupBox();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_forward = new System.Windows.Forms.Button();
            this.gb_state = new System.Windows.Forms.GroupBox();
            this.tb_received = new System.Windows.Forms.TextBox();
            this.lb_conn_state = new System.Windows.Forms.Label();
            this.lb_motB_PWM = new System.Windows.Forms.Label();
            this.lb_motA_PWM = new System.Windows.Forms.Label();
            this.lb_motB = new System.Windows.Forms.Label();
            this.lb_motA = new System.Windows.Forms.Label();
            this.gb_SPD = new System.Windows.Forms.GroupBox();
            this.cb_mt_sync = new System.Windows.Forms.CheckBox();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.tbar_motB = new System.Windows.Forms.TrackBar();
            this.tbar_motA = new System.Windows.Forms.TrackBar();
            this.gb_arm = new System.Windows.Forms.GroupBox();
            this.lb_arm_pos_z = new System.Windows.Forms.Label();
            this.lb_arm_pos_y = new System.Windows.Forms.Label();
            this.lb_arm_pos_x = new System.Windows.Forms.Label();
            this.lb_arm_pos_z_tag = new System.Windows.Forms.Label();
            this.lb_arm_pos_y_tag = new System.Windows.Forms.Label();
            this.lb_arm_pos_x_tag = new System.Windows.Forms.Label();
            this.bt_homing = new System.Windows.Forms.Button();
            this.tbar_servo4 = new System.Windows.Forms.TrackBar();
            this.tbar_servo3 = new System.Windows.Forms.TrackBar();
            this.tbar_servo2 = new System.Windows.Forms.TrackBar();
            this.tbar_servo1 = new System.Windows.Forms.TrackBar();
            this.lb_sv4_deg = new System.Windows.Forms.Label();
            this.lb_sv3_deg = new System.Windows.Forms.Label();
            this.lb_sv2_deg = new System.Windows.Forms.Label();
            this.lb_sv1_deg = new System.Windows.Forms.Label();
            this.lb_sv_tag = new System.Windows.Forms.Label();
            this.bt_arm_down = new System.Windows.Forms.Button();
            this.bt_arm_up = new System.Windows.Forms.Button();
            this.bt_arm_grasp = new System.Windows.Forms.Button();
            this.bt_arm_right = new System.Windows.Forms.Button();
            this.bt_arm_back = new System.Windows.Forms.Button();
            this.bt_arm_left = new System.Windows.Forms.Button();
            this.bt_arm_fw = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_1.SuspendLayout();
            this.gb_dir_cmd.SuspendLayout();
            this.gb_state.SuspendLayout();
            this.gb_SPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_motB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_motA)).BeginInit();
            this.gb_arm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.bt_monitor);
            this.gb_1.Controls.Add(this.bt_rescan);
            this.gb_1.Controls.Add(this.bt_disc);
            this.gb_1.Controls.Add(this.bt_conn);
            this.gb_1.Controls.Add(this.cb_baud);
            this.gb_1.Controls.Add(this.cb_port);
            this.gb_1.Controls.Add(this.lb_baud);
            this.gb_1.Controls.Add(this.lb_port);
            resources.ApplyResources(this.gb_1, "gb_1");
            this.gb_1.Name = "gb_1";
            this.gb_1.TabStop = false;
            // 
            // bt_monitor
            // 
            resources.ApplyResources(this.bt_monitor, "bt_monitor");
            this.bt_monitor.Name = "bt_monitor";
            this.bt_monitor.UseVisualStyleBackColor = true;
            this.bt_monitor.Click += new System.EventHandler(this.bt_monitor_Click);
            // 
            // bt_rescan
            // 
            resources.ApplyResources(this.bt_rescan, "bt_rescan");
            this.bt_rescan.Name = "bt_rescan";
            this.bt_rescan.UseVisualStyleBackColor = true;
            this.bt_rescan.Click += new System.EventHandler(this.bt_rescan_Click);
            // 
            // bt_disc
            // 
            resources.ApplyResources(this.bt_disc, "bt_disc");
            this.bt_disc.Name = "bt_disc";
            this.bt_disc.UseVisualStyleBackColor = true;
            this.bt_disc.Click += new System.EventHandler(this.bt_disc_Click);
            // 
            // bt_conn
            // 
            resources.ApplyResources(this.bt_conn, "bt_conn");
            this.bt_conn.Name = "bt_conn";
            this.bt_conn.UseVisualStyleBackColor = true;
            this.bt_conn.Click += new System.EventHandler(this.bt_conn_Click);
            // 
            // cb_baud
            // 
            this.cb_baud.FormattingEnabled = true;
            resources.ApplyResources(this.cb_baud, "cb_baud");
            this.cb_baud.Name = "cb_baud";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            resources.ApplyResources(this.cb_port, "cb_port");
            this.cb_port.Name = "cb_port";
            // 
            // lb_baud
            // 
            resources.ApplyResources(this.lb_baud, "lb_baud");
            this.lb_baud.Name = "lb_baud";
            // 
            // lb_port
            // 
            resources.ApplyResources(this.lb_port, "lb_port");
            this.lb_port.Name = "lb_port";
            // 
            // gb_dir_cmd
            // 
            this.gb_dir_cmd.Controls.Add(this.bt_stop);
            this.gb_dir_cmd.Controls.Add(this.bt_right);
            this.gb_dir_cmd.Controls.Add(this.bt_back);
            this.gb_dir_cmd.Controls.Add(this.bt_left);
            this.gb_dir_cmd.Controls.Add(this.bt_forward);
            resources.ApplyResources(this.gb_dir_cmd, "gb_dir_cmd");
            this.gb_dir_cmd.Name = "gb_dir_cmd";
            this.gb_dir_cmd.TabStop = false;
            // 
            // bt_stop
            // 
            this.bt_stop.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.bt_stop, "bt_stop");
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.UseVisualStyleBackColor = false;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_right
            // 
            resources.ApplyResources(this.bt_right, "bt_right");
            this.bt_right.Name = "bt_right";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_right_MouseDown);
            this.bt_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_right_MouseUp);
            // 
            // bt_back
            // 
            resources.ApplyResources(this.bt_back, "bt_back");
            this.bt_back.Name = "bt_back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_back_MouseDown);
            this.bt_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_back_MouseUp);
            // 
            // bt_left
            // 
            resources.ApplyResources(this.bt_left, "bt_left");
            this.bt_left.Name = "bt_left";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_left_MouseDown);
            this.bt_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_left_MouseUp);
            // 
            // bt_forward
            // 
            resources.ApplyResources(this.bt_forward, "bt_forward");
            this.bt_forward.Name = "bt_forward";
            this.bt_forward.UseVisualStyleBackColor = true;
            this.bt_forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_forward_MouseDown);
            this.bt_forward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_forward_MouseUp);
            // 
            // gb_state
            // 
            this.gb_state.Controls.Add(this.tb_received);
            this.gb_state.Controls.Add(this.lb_conn_state);
            resources.ApplyResources(this.gb_state, "gb_state");
            this.gb_state.Name = "gb_state";
            this.gb_state.TabStop = false;
            // 
            // tb_received
            // 
            resources.ApplyResources(this.tb_received, "tb_received");
            this.tb_received.Name = "tb_received";
            // 
            // lb_conn_state
            // 
            resources.ApplyResources(this.lb_conn_state, "lb_conn_state");
            this.lb_conn_state.ForeColor = System.Drawing.Color.Red;
            this.lb_conn_state.Name = "lb_conn_state";
            // 
            // lb_motB_PWM
            // 
            resources.ApplyResources(this.lb_motB_PWM, "lb_motB_PWM");
            this.lb_motB_PWM.Name = "lb_motB_PWM";
            // 
            // lb_motA_PWM
            // 
            resources.ApplyResources(this.lb_motA_PWM, "lb_motA_PWM");
            this.lb_motA_PWM.Name = "lb_motA_PWM";
            // 
            // lb_motB
            // 
            resources.ApplyResources(this.lb_motB, "lb_motB");
            this.lb_motB.Name = "lb_motB";
            // 
            // lb_motA
            // 
            resources.ApplyResources(this.lb_motA, "lb_motA");
            this.lb_motA.Name = "lb_motA";
            // 
            // gb_SPD
            // 
            this.gb_SPD.Controls.Add(this.cb_mt_sync);
            this.gb_SPD.Controls.Add(this.lb_B);
            this.gb_SPD.Controls.Add(this.lb_motB_PWM);
            this.gb_SPD.Controls.Add(this.lb_A);
            this.gb_SPD.Controls.Add(this.tbar_motB);
            this.gb_SPD.Controls.Add(this.lb_motA_PWM);
            this.gb_SPD.Controls.Add(this.tbar_motA);
            this.gb_SPD.Controls.Add(this.lb_motA);
            this.gb_SPD.Controls.Add(this.lb_motB);
            resources.ApplyResources(this.gb_SPD, "gb_SPD");
            this.gb_SPD.Name = "gb_SPD";
            this.gb_SPD.TabStop = false;
            // 
            // cb_mt_sync
            // 
            resources.ApplyResources(this.cb_mt_sync, "cb_mt_sync");
            this.cb_mt_sync.Name = "cb_mt_sync";
            this.cb_mt_sync.UseVisualStyleBackColor = true;
            this.cb_mt_sync.CheckedChanged += new System.EventHandler(this.cb_mt_sync_CheckedChanged);
            // 
            // lb_B
            // 
            resources.ApplyResources(this.lb_B, "lb_B");
            this.lb_B.Name = "lb_B";
            // 
            // lb_A
            // 
            resources.ApplyResources(this.lb_A, "lb_A");
            this.lb_A.Name = "lb_A";
            // 
            // tbar_motB
            // 
            resources.ApplyResources(this.tbar_motB, "tbar_motB");
            this.tbar_motB.Maximum = 255;
            this.tbar_motB.Name = "tbar_motB";
            this.tbar_motB.TickFrequency = 10;
            this.tbar_motB.Value = 100;
            this.tbar_motB.Scroll += new System.EventHandler(this.tbar_motB_Scroll);
            // 
            // tbar_motA
            // 
            resources.ApplyResources(this.tbar_motA, "tbar_motA");
            this.tbar_motA.Maximum = 255;
            this.tbar_motA.Name = "tbar_motA";
            this.tbar_motA.TickFrequency = 10;
            this.tbar_motA.Value = 100;
            this.tbar_motA.Scroll += new System.EventHandler(this.tbar_motA_Scroll);
            // 
            // gb_arm
            // 
            this.gb_arm.Controls.Add(this.lb_arm_pos_z);
            this.gb_arm.Controls.Add(this.lb_arm_pos_y);
            this.gb_arm.Controls.Add(this.lb_arm_pos_x);
            this.gb_arm.Controls.Add(this.lb_arm_pos_z_tag);
            this.gb_arm.Controls.Add(this.lb_arm_pos_y_tag);
            this.gb_arm.Controls.Add(this.lb_arm_pos_x_tag);
            this.gb_arm.Controls.Add(this.bt_homing);
            this.gb_arm.Controls.Add(this.tbar_servo4);
            this.gb_arm.Controls.Add(this.tbar_servo3);
            this.gb_arm.Controls.Add(this.tbar_servo2);
            this.gb_arm.Controls.Add(this.tbar_servo1);
            this.gb_arm.Controls.Add(this.lb_sv4_deg);
            this.gb_arm.Controls.Add(this.lb_sv3_deg);
            this.gb_arm.Controls.Add(this.lb_sv2_deg);
            this.gb_arm.Controls.Add(this.lb_sv1_deg);
            this.gb_arm.Controls.Add(this.lb_sv_tag);
            this.gb_arm.Controls.Add(this.bt_arm_down);
            this.gb_arm.Controls.Add(this.bt_arm_up);
            this.gb_arm.Controls.Add(this.bt_arm_grasp);
            this.gb_arm.Controls.Add(this.bt_arm_right);
            this.gb_arm.Controls.Add(this.bt_arm_back);
            this.gb_arm.Controls.Add(this.bt_arm_left);
            this.gb_arm.Controls.Add(this.bt_arm_fw);
            resources.ApplyResources(this.gb_arm, "gb_arm");
            this.gb_arm.Name = "gb_arm";
            this.gb_arm.TabStop = false;
            // 
            // lb_arm_pos_z
            // 
            resources.ApplyResources(this.lb_arm_pos_z, "lb_arm_pos_z");
            this.lb_arm_pos_z.Name = "lb_arm_pos_z";
            // 
            // lb_arm_pos_y
            // 
            resources.ApplyResources(this.lb_arm_pos_y, "lb_arm_pos_y");
            this.lb_arm_pos_y.Name = "lb_arm_pos_y";
            // 
            // lb_arm_pos_x
            // 
            resources.ApplyResources(this.lb_arm_pos_x, "lb_arm_pos_x");
            this.lb_arm_pos_x.Name = "lb_arm_pos_x";
            // 
            // lb_arm_pos_z_tag
            // 
            resources.ApplyResources(this.lb_arm_pos_z_tag, "lb_arm_pos_z_tag");
            this.lb_arm_pos_z_tag.Name = "lb_arm_pos_z_tag";
            // 
            // lb_arm_pos_y_tag
            // 
            resources.ApplyResources(this.lb_arm_pos_y_tag, "lb_arm_pos_y_tag");
            this.lb_arm_pos_y_tag.Name = "lb_arm_pos_y_tag";
            // 
            // lb_arm_pos_x_tag
            // 
            resources.ApplyResources(this.lb_arm_pos_x_tag, "lb_arm_pos_x_tag");
            this.lb_arm_pos_x_tag.Name = "lb_arm_pos_x_tag";
            // 
            // bt_homing
            // 
            resources.ApplyResources(this.bt_homing, "bt_homing");
            this.bt_homing.Name = "bt_homing";
            this.bt_homing.UseVisualStyleBackColor = true;
            this.bt_homing.Click += new System.EventHandler(this.bt_homing_Click);
            // 
            // tbar_servo4
            // 
            resources.ApplyResources(this.tbar_servo4, "tbar_servo4");
            this.tbar_servo4.Maximum = 180;
            this.tbar_servo4.Name = "tbar_servo4";
            this.tbar_servo4.TickFrequency = 10;
            this.tbar_servo4.Value = 100;
            this.tbar_servo4.Scroll += new System.EventHandler(this.tbar_servo4_Scroll);
            // 
            // tbar_servo3
            // 
            resources.ApplyResources(this.tbar_servo3, "tbar_servo3");
            this.tbar_servo3.Maximum = 180;
            this.tbar_servo3.Name = "tbar_servo3";
            this.tbar_servo3.TickFrequency = 10;
            this.tbar_servo3.Value = 100;
            this.tbar_servo3.Scroll += new System.EventHandler(this.tbar_servo3_Scroll);
            // 
            // tbar_servo2
            // 
            resources.ApplyResources(this.tbar_servo2, "tbar_servo2");
            this.tbar_servo2.Maximum = 180;
            this.tbar_servo2.Name = "tbar_servo2";
            this.tbar_servo2.TickFrequency = 10;
            this.tbar_servo2.Value = 100;
            this.tbar_servo2.Scroll += new System.EventHandler(this.tbar_servo2_Scroll);
            // 
            // tbar_servo1
            // 
            resources.ApplyResources(this.tbar_servo1, "tbar_servo1");
            this.tbar_servo1.Maximum = 180;
            this.tbar_servo1.Name = "tbar_servo1";
            this.tbar_servo1.TickFrequency = 10;
            this.tbar_servo1.Value = 100;
            this.tbar_servo1.Scroll += new System.EventHandler(this.tbar_servo1_Scroll);
            // 
            // lb_sv4_deg
            // 
            resources.ApplyResources(this.lb_sv4_deg, "lb_sv4_deg");
            this.lb_sv4_deg.Name = "lb_sv4_deg";
            // 
            // lb_sv3_deg
            // 
            resources.ApplyResources(this.lb_sv3_deg, "lb_sv3_deg");
            this.lb_sv3_deg.Name = "lb_sv3_deg";
            // 
            // lb_sv2_deg
            // 
            resources.ApplyResources(this.lb_sv2_deg, "lb_sv2_deg");
            this.lb_sv2_deg.Name = "lb_sv2_deg";
            // 
            // lb_sv1_deg
            // 
            resources.ApplyResources(this.lb_sv1_deg, "lb_sv1_deg");
            this.lb_sv1_deg.Name = "lb_sv1_deg";
            // 
            // lb_sv_tag
            // 
            resources.ApplyResources(this.lb_sv_tag, "lb_sv_tag");
            this.lb_sv_tag.Name = "lb_sv_tag";
            // 
            // bt_arm_down
            // 
            resources.ApplyResources(this.bt_arm_down, "bt_arm_down");
            this.bt_arm_down.Name = "bt_arm_down";
            this.bt_arm_down.UseVisualStyleBackColor = true;
            this.bt_arm_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_down_MouseDown);
            this.bt_arm_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_down_MouseUp);
            // 
            // bt_arm_up
            // 
            resources.ApplyResources(this.bt_arm_up, "bt_arm_up");
            this.bt_arm_up.Name = "bt_arm_up";
            this.bt_arm_up.UseVisualStyleBackColor = true;
            this.bt_arm_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_up_MouseDown);
            this.bt_arm_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_up_MouseUp);
            // 
            // bt_arm_grasp
            // 
            this.bt_arm_grasp.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.bt_arm_grasp, "bt_arm_grasp");
            this.bt_arm_grasp.Name = "bt_arm_grasp";
            this.bt_arm_grasp.UseVisualStyleBackColor = false;
            // 
            // bt_arm_right
            // 
            resources.ApplyResources(this.bt_arm_right, "bt_arm_right");
            this.bt_arm_right.Name = "bt_arm_right";
            this.bt_arm_right.UseVisualStyleBackColor = true;
            this.bt_arm_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_right_MouseDown);
            this.bt_arm_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_right_MouseUp);
            // 
            // bt_arm_back
            // 
            resources.ApplyResources(this.bt_arm_back, "bt_arm_back");
            this.bt_arm_back.Name = "bt_arm_back";
            this.bt_arm_back.UseVisualStyleBackColor = true;
            this.bt_arm_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_back_MouseDown);
            this.bt_arm_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_back_MouseUp);
            // 
            // bt_arm_left
            // 
            resources.ApplyResources(this.bt_arm_left, "bt_arm_left");
            this.bt_arm_left.Name = "bt_arm_left";
            this.bt_arm_left.UseVisualStyleBackColor = true;
            this.bt_arm_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_left_MouseDown);
            this.bt_arm_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_left_MouseUp);
            // 
            // bt_arm_fw
            // 
            resources.ApplyResources(this.bt_arm_fw, "bt_arm_fw");
            this.bt_arm_fw.Name = "bt_arm_fw";
            this.bt_arm_fw.UseVisualStyleBackColor = true;
            this.bt_arm_fw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_arm_fw_MouseDown);
            this.bt_arm_fw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_arm_fw_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_arm);
            this.Controls.Add(this.gb_SPD);
            this.Controls.Add(this.gb_state);
            this.Controls.Add(this.gb_dir_cmd);
            this.Controls.Add(this.gb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.gb_dir_cmd.ResumeLayout(false);
            this.gb_state.ResumeLayout(false);
            this.gb_state.PerformLayout();
            this.gb_SPD.ResumeLayout(false);
            this.gb_SPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_motB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_motA)).EndInit();
            this.gb_arm.ResumeLayout(false);
            this.gb_arm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_servo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Button bt_rescan;
        private System.Windows.Forms.Button bt_disc;
        private System.Windows.Forms.Button bt_conn;
        private System.Windows.Forms.ComboBox cb_baud;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label lb_baud;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.GroupBox gb_dir_cmd;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_forward;
        private System.Windows.Forms.GroupBox gb_state;
        private System.Windows.Forms.Label lb_motB;
        private System.Windows.Forms.Label lb_motA;
        private System.Windows.Forms.Label lb_conn_state;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label lb_motB_PWM;
        private System.Windows.Forms.Label lb_motA_PWM;
        private System.Windows.Forms.GroupBox gb_SPD;
        private System.Windows.Forms.TrackBar tbar_motA;
        private System.Windows.Forms.TrackBar tbar_motB;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.TextBox tb_received;
        private System.Windows.Forms.GroupBox gb_arm;
        private System.Windows.Forms.Button bt_arm_down;
        private System.Windows.Forms.Button bt_arm_up;
        private System.Windows.Forms.Button bt_arm_grasp;
        private System.Windows.Forms.Button bt_arm_right;
        private System.Windows.Forms.Button bt_arm_back;
        private System.Windows.Forms.Button bt_arm_left;
        private System.Windows.Forms.Button bt_arm_fw;
        private System.Windows.Forms.Label lb_sv4_deg;
        private System.Windows.Forms.Label lb_sv3_deg;
        private System.Windows.Forms.Label lb_sv2_deg;
        private System.Windows.Forms.Label lb_sv1_deg;
        private System.Windows.Forms.Label lb_sv_tag;
        private System.Windows.Forms.TrackBar tbar_servo4;
        private System.Windows.Forms.TrackBar tbar_servo3;
        private System.Windows.Forms.TrackBar tbar_servo2;
        private System.Windows.Forms.TrackBar tbar_servo1;
        private System.Windows.Forms.Button bt_homing;
        private System.Windows.Forms.Button bt_monitor;
        private System.Windows.Forms.CheckBox cb_mt_sync;
        private System.Windows.Forms.Label lb_arm_pos_z_tag;
        private System.Windows.Forms.Label lb_arm_pos_y_tag;
        private System.Windows.Forms.Label lb_arm_pos_x_tag;
        private System.Windows.Forms.Label lb_arm_pos_z;
        private System.Windows.Forms.Label lb_arm_pos_y;
        private System.Windows.Forms.Label lb_arm_pos_x;
        private System.Windows.Forms.Timer timer1;
    }
}

