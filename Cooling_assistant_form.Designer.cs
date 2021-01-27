
namespace Test_ASCOM_form
{
    partial class Cooling_assistant_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cooling_assistant_form));
            this.label1 = new System.Windows.Forms.Label();
            this.ccd_temp_cooling = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.target_temp = new System.Windows.Forms.TextBox();
            this.timeout_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cooling_step_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Go_cooling_warming = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current temperature :";
            // 
            // ccd_temp_cooling
            // 
            this.ccd_temp_cooling.AutoSize = true;
            this.ccd_temp_cooling.Location = new System.Drawing.Point(204, 188);
            this.ccd_temp_cooling.Name = "ccd_temp_cooling";
            this.ccd_temp_cooling.Size = new System.Drawing.Size(31, 17);
            this.ccd_temp_cooling.TabIndex = 1;
            this.ccd_temp_cooling.Text = "0°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target temperature (°) :";
            // 
            // target_temp
            // 
            this.target_temp.Location = new System.Drawing.Point(207, 74);
            this.target_temp.Name = "target_temp";
            this.target_temp.Size = new System.Drawing.Size(64, 22);
            this.target_temp.TabIndex = 3;
            // 
            // timeout_box
            // 
            this.timeout_box.Location = new System.Drawing.Point(207, 146);
            this.timeout_box.Name = "timeout_box";
            this.timeout_box.Size = new System.Drawing.Size(64, 22);
            this.timeout_box.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timeout (s) :";
            // 
            // cooling_step_box
            // 
            this.cooling_step_box.Location = new System.Drawing.Point(207, 111);
            this.cooling_step_box.Name = "cooling_step_box";
            this.cooling_step_box.Size = new System.Drawing.Size(64, 22);
            this.cooling_step_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cooling step (°) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cooling assistant";
            // 
            // Go_cooling_warming
            // 
            this.Go_cooling_warming.Location = new System.Drawing.Point(207, 230);
            this.Go_cooling_warming.Name = "Go_cooling_warming";
            this.Go_cooling_warming.Size = new System.Drawing.Size(137, 28);
            this.Go_cooling_warming.TabIndex = 9;
            this.Go_cooling_warming.Text = "Cooling/Warming";
            this.Go_cooling_warming.UseVisualStyleBackColor = true;
            this.Go_cooling_warming.Click += new System.EventHandler(this.Go_cooling_warming_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Error";
            this.label2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Error";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Error";
            this.label8.Visible = false;
            // 
            // Cooling_assistant_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(356, 270);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Go_cooling_warming);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cooling_step_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeout_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.target_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccd_temp_cooling);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cooling_assistant_form";
            this.Text = "Cooling_assistant_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ccd_temp_cooling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox target_temp;
        private System.Windows.Forms.TextBox timeout_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cooling_step_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Go_cooling_warming;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}