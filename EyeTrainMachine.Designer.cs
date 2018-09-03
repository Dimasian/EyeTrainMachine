namespace EyeTrainMachine_WinForms
	{
	partial class EyeTrainMachine
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeTrainMachine));
			this.btn_connect = new System.Windows.Forms.Button();
			this.lbl_frontSensor = new System.Windows.Forms.Label();
			this.lbl_rearSensor = new System.Windows.Forms.Label();
			this.btn_exersize_0 = new System.Windows.Forms.Button();
			this.tb_status = new System.Windows.Forms.TextBox();
			this.btn_findCenter = new System.Windows.Forms.Button();
			this.btn_exersize_1 = new System.Windows.Forms.Button();
			this.tb_fromArduino = new System.Windows.Forms.TextBox();
			this.lbl_remiter_txt = new System.Windows.Forms.Label();
			this.lbl_rem_iter = new System.Windows.Forms.Label();
			this.lbl_dist = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_connect
			// 
			this.btn_connect.BackColor = System.Drawing.Color.DodgerBlue;
			this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_connect.ForeColor = System.Drawing.Color.Yellow;
			this.btn_connect.Location = new System.Drawing.Point(28, 22);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(197, 77);
			this.btn_connect.TabIndex = 1;
			this.btn_connect.Text = "CONNECT";
			this.btn_connect.UseVisualStyleBackColor = false;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// lbl_frontSensor
			// 
			this.lbl_frontSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_frontSensor.Location = new System.Drawing.Point(311, 22);
			this.lbl_frontSensor.Name = "lbl_frontSensor";
			this.lbl_frontSensor.Size = new System.Drawing.Size(209, 30);
			this.lbl_frontSensor.TabIndex = 2;
			this.lbl_frontSensor.Text = "front_sensor";
			this.lbl_frontSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_rearSensor
			// 
			this.lbl_rearSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_rearSensor.Location = new System.Drawing.Point(311, 69);
			this.lbl_rearSensor.Name = "lbl_rearSensor";
			this.lbl_rearSensor.Size = new System.Drawing.Size(209, 30);
			this.lbl_rearSensor.TabIndex = 3;
			this.lbl_rearSensor.Text = "rear_sensor";
			this.lbl_rearSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_exersize_0
			// 
			this.btn_exersize_0.BackColor = System.Drawing.Color.DarkViolet;
			this.btn_exersize_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_exersize_0.ForeColor = System.Drawing.Color.Yellow;
			this.btn_exersize_0.Location = new System.Drawing.Point(28, 185);
			this.btn_exersize_0.Name = "btn_exersize_0";
			this.btn_exersize_0.Size = new System.Drawing.Size(197, 77);
			this.btn_exersize_0.TabIndex = 4;
			this.btn_exersize_0.Text = "Exersize 0";
			this.btn_exersize_0.UseVisualStyleBackColor = false;
			this.btn_exersize_0.Click += new System.EventHandler(this.btn_exersize_0_Click);
			// 
			// tb_status
			// 
			this.tb_status.Location = new System.Drawing.Point(311, 115);
			this.tb_status.Multiline = true;
			this.tb_status.Name = "tb_status";
			this.tb_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_status.Size = new System.Drawing.Size(626, 157);
			this.tb_status.TabIndex = 5;
			// 
			// btn_findCenter
			// 
			this.btn_findCenter.BackColor = System.Drawing.Color.SeaGreen;
			this.btn_findCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_findCenter.ForeColor = System.Drawing.Color.Turquoise;
			this.btn_findCenter.Location = new System.Drawing.Point(28, 105);
			this.btn_findCenter.Name = "btn_findCenter";
			this.btn_findCenter.Size = new System.Drawing.Size(197, 77);
			this.btn_findCenter.TabIndex = 6;
			this.btn_findCenter.Text = "Find center";
			this.btn_findCenter.UseVisualStyleBackColor = false;
			this.btn_findCenter.Click += new System.EventHandler(this.btn_findCenter_Click);
			// 
			// btn_exersize_1
			// 
			this.btn_exersize_1.BackColor = System.Drawing.Color.DarkViolet;
			this.btn_exersize_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_exersize_1.ForeColor = System.Drawing.Color.Yellow;
			this.btn_exersize_1.Location = new System.Drawing.Point(28, 268);
			this.btn_exersize_1.Name = "btn_exersize_1";
			this.btn_exersize_1.Size = new System.Drawing.Size(197, 77);
			this.btn_exersize_1.TabIndex = 7;
			this.btn_exersize_1.Text = "Exersize 1";
			this.btn_exersize_1.UseVisualStyleBackColor = false;
			this.btn_exersize_1.Click += new System.EventHandler(this.btn_exersize_1_Click);
			// 
			// tb_fromArduino
			// 
			this.tb_fromArduino.Location = new System.Drawing.Point(311, 291);
			this.tb_fromArduino.Multiline = true;
			this.tb_fromArduino.Name = "tb_fromArduino";
			this.tb_fromArduino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_fromArduino.Size = new System.Drawing.Size(626, 286);
			this.tb_fromArduino.TabIndex = 8;
			// 
			// lbl_remiter_txt
			// 
			this.lbl_remiter_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_remiter_txt.Location = new System.Drawing.Point(541, 22);
			this.lbl_remiter_txt.Name = "lbl_remiter_txt";
			this.lbl_remiter_txt.Size = new System.Drawing.Size(211, 30);
			this.lbl_remiter_txt.TabIndex = 9;
			this.lbl_remiter_txt.Text = "REMAINING ITERATIONS:";
			this.lbl_remiter_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_rem_iter
			// 
			this.lbl_rem_iter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_rem_iter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_rem_iter.Location = new System.Drawing.Point(779, 22);
			this.lbl_rem_iter.Name = "lbl_rem_iter";
			this.lbl_rem_iter.Size = new System.Drawing.Size(83, 30);
			this.lbl_rem_iter.TabIndex = 10;
			this.lbl_rem_iter.Text = "--";
			this.lbl_rem_iter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_dist
			// 
			this.lbl_dist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_dist.Location = new System.Drawing.Point(672, 69);
			this.lbl_dist.Name = "lbl_dist";
			this.lbl_dist.Size = new System.Drawing.Size(109, 30);
			this.lbl_dist.TabIndex = 11;
			this.lbl_dist.Text = "--";
			this.lbl_dist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(541, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 30);
			this.label2.TabIndex = 12;
			this.label2.Text = "DISTANCE:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EyeTrainMachine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 663);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_dist);
			this.Controls.Add(this.lbl_rem_iter);
			this.Controls.Add(this.lbl_remiter_txt);
			this.Controls.Add(this.tb_fromArduino);
			this.Controls.Add(this.btn_exersize_1);
			this.Controls.Add(this.btn_findCenter);
			this.Controls.Add(this.tb_status);
			this.Controls.Add(this.btn_exersize_0);
			this.Controls.Add(this.lbl_rearSensor);
			this.Controls.Add(this.lbl_frontSensor);
			this.Controls.Add(this.btn_connect);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EyeTrainMachine";
			this.Text = "EYE TRAIN MACHINE";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EyeTrainMachine_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Label lbl_frontSensor;
		private System.Windows.Forms.Label lbl_rearSensor;
		private System.Windows.Forms.Button btn_exersize_0;
		private System.Windows.Forms.TextBox tb_status;
		private System.Windows.Forms.Button btn_findCenter;
		private System.Windows.Forms.Button btn_exersize_1;
		private System.Windows.Forms.TextBox tb_fromArduino;
		private System.Windows.Forms.Label lbl_remiter_txt;
		private System.Windows.Forms.Label lbl_rem_iter;
		private System.Windows.Forms.Label lbl_dist;
		private System.Windows.Forms.Label label2;
	}
	}

