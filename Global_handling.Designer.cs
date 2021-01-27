namespace Test_ASCOM_form
{
    partial class Global_handling
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Global_handling));
            this.focuser_choose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.In = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.OutOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.error_char = new System.Windows.Forms.Label();
            this.focuser_temp = new System.Windows.Forms.Label();
            this.Disconnect_focuser = new System.Windows.Forms.Button();
            this.Go_position = new System.Windows.Forms.Button();
            this.current_focuser_value = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Focuser_value = new System.Windows.Forms.TextBox();
            this.focuser_temp_worker = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.current_position = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filter_select = new System.Windows.Forms.ComboBox();
            this.filter_wheel_choose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.capture = new System.Windows.Forms.Button();
            this.count_exposure = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.exposure_time = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Binning = new System.Windows.Forms.ComboBox();
            this.Cooling_assistant = new System.Windows.Forms.Button();
            this.disconnect_camera = new System.Windows.Forms.Button();
            this.ccd_temp = new System.Windows.Forms.Label();
            this.camera_choose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eregristrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeTutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ccd_temp_worker = new System.ComponentModel.BackgroundWorker();
            this.ccd_capture_worker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_exposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_time)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // focuser_choose
            // 
            this.focuser_choose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.focuser_choose.Location = new System.Drawing.Point(201, 24);
            this.focuser_choose.Name = "focuser_choose";
            this.focuser_choose.Size = new System.Drawing.Size(88, 23);
            this.focuser_choose.TabIndex = 0;
            this.focuser_choose.Text = "Focuser";
            this.focuser_choose.UseVisualStyleBackColor = false;
            this.focuser_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your device :";
            // 
            // InIn
            // 
            this.InIn.Location = new System.Drawing.Point(62, 96);
            this.InIn.Name = "InIn";
            this.InIn.Size = new System.Drawing.Size(41, 23);
            this.InIn.TabIndex = 2;
            this.InIn.Text = "<<";
            this.InIn.UseVisualStyleBackColor = true;
            this.InIn.Click += new System.EventHandler(this.InIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "In :";
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(109, 96);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(41, 23);
            this.In.TabIndex = 4;
            this.In.Text = "<";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(201, 96);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(41, 23);
            this.Out.TabIndex = 5;
            this.Out.Text = ">";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // OutOut
            // 
            this.OutOut.Location = new System.Drawing.Point(248, 96);
            this.OutOut.Name = "OutOut";
            this.OutOut.Size = new System.Drawing.Size(41, 23);
            this.OutOut.TabIndex = 6;
            this.OutOut.Text = ">>";
            this.OutOut.UseVisualStyleBackColor = true;
            this.OutOut.Click += new System.EventHandler(this.OutOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = ": Out";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.error_char);
            this.groupBox1.Controls.Add(this.focuser_temp);
            this.groupBox1.Controls.Add(this.Disconnect_focuser);
            this.groupBox1.Controls.Add(this.Go_position);
            this.groupBox1.Controls.Add(this.current_focuser_value);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Focuser_value);
            this.groupBox1.Controls.Add(this.focuser_choose);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutOut);
            this.groupBox1.Controls.Add(this.InIn);
            this.groupBox1.Controls.Add(this.Out);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.In);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Focuser";
            // 
            // error_char
            // 
            this.error_char.AutoSize = true;
            this.error_char.Location = new System.Drawing.Point(210, 127);
            this.error_char.Name = "error_char";
            this.error_char.Size = new System.Drawing.Size(164, 17);
            this.error_char.TabIndex = 14;
            this.error_char.Text = "Error select a valid value";
            this.error_char.Visible = false;
            // 
            // focuser_temp
            // 
            this.focuser_temp.AutoSize = true;
            this.focuser_temp.Location = new System.Drawing.Point(305, 27);
            this.focuser_temp.Name = "focuser_temp";
            this.focuser_temp.Size = new System.Drawing.Size(31, 17);
            this.focuser_temp.TabIndex = 13;
            this.focuser_temp.Text = "0°C";
            // 
            // Disconnect_focuser
            // 
            this.Disconnect_focuser.Enabled = false;
            this.Disconnect_focuser.Location = new System.Drawing.Point(356, 178);
            this.Disconnect_focuser.Name = "Disconnect_focuser";
            this.Disconnect_focuser.Size = new System.Drawing.Size(96, 23);
            this.Disconnect_focuser.TabIndex = 12;
            this.Disconnect_focuser.Text = "Disconnect";
            this.Disconnect_focuser.UseVisualStyleBackColor = true;
            this.Disconnect_focuser.Click += new System.EventHandler(this.Disconnect_focuser_Click);
            // 
            // Go_position
            // 
            this.Go_position.Location = new System.Drawing.Point(146, 124);
            this.Go_position.Name = "Go_position";
            this.Go_position.Size = new System.Drawing.Size(58, 23);
            this.Go_position.TabIndex = 11;
            this.Go_position.Text = "Go to";
            this.Go_position.UseVisualStyleBackColor = true;
            this.Go_position.Click += new System.EventHandler(this.Go_position_Click);
            // 
            // current_focuser_value
            // 
            this.current_focuser_value.AutoSize = true;
            this.current_focuser_value.Location = new System.Drawing.Point(198, 61);
            this.current_focuser_value.Name = "current_focuser_value";
            this.current_focuser_value.Size = new System.Drawing.Size(16, 17);
            this.current_focuser_value.TabIndex = 10;
            this.current_focuser_value.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current position :";
            // 
            // Focuser_value
            // 
            this.Focuser_value.Location = new System.Drawing.Point(156, 96);
            this.Focuser_value.Name = "Focuser_value";
            this.Focuser_value.Size = new System.Drawing.Size(39, 22);
            this.Focuser_value.TabIndex = 8;
            // 
            // focuser_temp_worker
            // 
            this.focuser_temp_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.focuser_temp_worker_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.current_position);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.filter_select);
            this.groupBox2.Controls.Add(this.filter_wheel_choose);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.capture);
            this.groupBox2.Controls.Add(this.count_exposure);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.exposure_time);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Binning);
            this.groupBox2.Controls.Add(this.Cooling_assistant);
            this.groupBox2.Controls.Add(this.disconnect_camera);
            this.groupBox2.Controls.Add(this.ccd_temp);
            this.groupBox2.Controls.Add(this.camera_choose);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera and Filter Wheel";
            // 
            // current_position
            // 
            this.current_position.AutoSize = true;
            this.current_position.Location = new System.Drawing.Point(309, 56);
            this.current_position.Name = "current_position";
            this.current_position.Size = new System.Drawing.Size(16, 17);
            this.current_position.TabIndex = 29;
            this.current_position.Text = "L";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Select filter :";
            // 
            // filter_select
            // 
            this.filter_select.FormattingEnabled = true;
            this.filter_select.Location = new System.Drawing.Point(179, 86);
            this.filter_select.Name = "filter_select";
            this.filter_select.Size = new System.Drawing.Size(62, 24);
            this.filter_select.TabIndex = 27;
            // 
            // filter_wheel_choose
            // 
            this.filter_wheel_choose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filter_wheel_choose.Location = new System.Drawing.Point(200, 53);
            this.filter_wheel_choose.Name = "filter_wheel_choose";
            this.filter_wheel_choose.Size = new System.Drawing.Size(88, 23);
            this.filter_wheel_choose.TabIndex = 25;
            this.filter_wheel_choose.Text = "Filter wheel";
            this.filter_wheel_choose.UseVisualStyleBackColor = false;
            this.filter_wheel_choose.Click += new System.EventHandler(this.filter_wheel_choose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Select your device :";
            // 
            // capture
            // 
            this.capture.Enabled = false;
            this.capture.Location = new System.Drawing.Point(298, 142);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(75, 32);
            this.capture.TabIndex = 24;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // count_exposure
            // 
            this.count_exposure.Location = new System.Drawing.Point(180, 178);
            this.count_exposure.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.count_exposure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_exposure.Name = "count_exposure";
            this.count_exposure.Size = new System.Drawing.Size(61, 22);
            this.count_exposure.TabIndex = 23;
            this.count_exposure.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select count :";
            // 
            // exposure_time
            // 
            this.exposure_time.Location = new System.Drawing.Point(180, 148);
            this.exposure_time.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.exposure_time.Name = "exposure_time";
            this.exposure_time.Size = new System.Drawing.Size(61, 22);
            this.exposure_time.TabIndex = 21;
            this.exposure_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select exposure time (s) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select binning :";
            // 
            // Binning
            // 
            this.Binning.FormattingEnabled = true;
            this.Binning.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4"});
            this.Binning.Location = new System.Drawing.Point(179, 117);
            this.Binning.Name = "Binning";
            this.Binning.Size = new System.Drawing.Size(62, 24);
            this.Binning.TabIndex = 17;
            this.Binning.Text = "1x1";
            // 
            // Cooling_assistant
            // 
            this.Cooling_assistant.Enabled = false;
            this.Cooling_assistant.Location = new System.Drawing.Point(355, 21);
            this.Cooling_assistant.Name = "Cooling_assistant";
            this.Cooling_assistant.Size = new System.Drawing.Size(75, 31);
            this.Cooling_assistant.TabIndex = 16;
            this.Cooling_assistant.Text = "Cooling";
            this.Cooling_assistant.UseVisualStyleBackColor = true;
            this.Cooling_assistant.Click += new System.EventHandler(this.Cooling_assistant_Click);
            // 
            // disconnect_camera
            // 
            this.disconnect_camera.Enabled = false;
            this.disconnect_camera.Location = new System.Drawing.Point(355, 209);
            this.disconnect_camera.Name = "disconnect_camera";
            this.disconnect_camera.Size = new System.Drawing.Size(96, 23);
            this.disconnect_camera.TabIndex = 15;
            this.disconnect_camera.Text = "Disconnect";
            this.disconnect_camera.UseVisualStyleBackColor = true;
            this.disconnect_camera.Click += new System.EventHandler(this.disconnect_camera_Click_1);
            // 
            // ccd_temp
            // 
            this.ccd_temp.AutoSize = true;
            this.ccd_temp.Location = new System.Drawing.Point(302, 27);
            this.ccd_temp.Name = "ccd_temp";
            this.ccd_temp.Size = new System.Drawing.Size(31, 17);
            this.ccd_temp.TabIndex = 15;
            this.ccd_temp.Text = "0°C";
            // 
            // camera_choose
            // 
            this.camera_choose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.camera_choose.Location = new System.Drawing.Point(200, 24);
            this.camera_choose.Name = "camera_choose";
            this.camera_choose.Size = new System.Drawing.Size(88, 23);
            this.camera_choose.TabIndex = 15;
            this.camera_choose.Text = "Camera";
            this.camera_choose.UseVisualStyleBackColor = false;
            this.camera_choose.Click += new System.EventHandler(this.camera_choose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select your device :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.eregristrersousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // eregristrersousToolStripMenuItem
            // 
            this.eregristrersousToolStripMenuItem.Name = "eregristrersousToolStripMenuItem";
            this.eregristrersousToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.eregristrersousToolStripMenuItem.Text = "Eregristrer-sous";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youtubeTutorialsToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.ourWebsiteToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // youtubeTutorialsToolStripMenuItem
            // 
            this.youtubeTutorialsToolStripMenuItem.Name = "youtubeTutorialsToolStripMenuItem";
            this.youtubeTutorialsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.youtubeTutorialsToolStripMenuItem.Text = "Youtube tutorials";
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.sourceCodeToolStripMenuItem.Text = "Source code";
            // 
            // ourWebsiteToolStripMenuItem
            // 
            this.ourWebsiteToolStripMenuItem.Name = "ourWebsiteToolStripMenuItem";
            this.ourWebsiteToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.ourWebsiteToolStripMenuItem.Text = "Our website";
            // 
            // Global_handling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1054, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Global_handling";
            this.Text = "My Astronomical stuff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_exposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_time)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button focuser_choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button OutOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Go_position;
        private System.Windows.Forms.Label current_focuser_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Focuser_value;
        private System.Windows.Forms.Button Disconnect_focuser;
        private System.Windows.Forms.Label focuser_temp;
        private System.ComponentModel.BackgroundWorker focuser_temp_worker;
        private System.Windows.Forms.Label error_char;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button camera_choose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ccd_temp;
        private System.Windows.Forms.Button disconnect_camera;
        private System.Windows.Forms.Button Cooling_assistant;
        private System.Windows.Forms.ComboBox Binning;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown count_exposure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown exposure_time;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eregristrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeTutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourWebsiteToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker ccd_temp_worker;
        private System.ComponentModel.BackgroundWorker ccd_capture_worker;
        private System.Windows.Forms.Button filter_wheel_choose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label current_position;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox filter_select;
    }
}

