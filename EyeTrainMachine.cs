using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeTrainMachine_WinForms
	{
	public partial class EyeTrainMachine : Form
		{
		EyeTrainer eyeTrainer;

		public EyeTrainMachine ()
			{
			InitializeComponent();
			tb_status.ScrollToCaret();
			tb_fromArduino.ScrollToCaret();

			EyeTrainer.btn_connect = btn_connect;
			EyeTrainer.tbStatus = tb_status;
			EyeTrainer.tbFromArduino = tb_fromArduino;
			EyeTrainer.lblFrontSensor = lbl_frontSensor;
			EyeTrainer.lblRearSensor = lbl_rearSensor;
			EyeTrainer.lblIterations = lbl_rem_iter;
			EyeTrainer.lblDist = lbl_dist;
			eyeTrainer = new EyeTrainer ();
		}

		private void Form1_Load (object sender, EventArgs e)
			{

			}

		private void EyeTrainMachine_FormClosing (object sender, FormClosingEventArgs e)
			{
			eyeTrainer.CloseConnection();
			}

		private void btn_connect_Click (object sender, EventArgs e)
			{
			if (btn_connect.Text=="CONNECT")
			{
				eyeTrainer.OpenConnection ();
				return;
			}
			if (btn_connect.Text=="DISCONNECT")
			{
				eyeTrainer.CloseConnection ();
				return;
			}
		}

		private void btn_exersize_0_Click (object sender, EventArgs e)
		{
			eyeTrainer.Exersize_0();
		}

		private void btn_findCenter_Click (object sender, EventArgs e)
		{
			eyeTrainer.FindCenter();
		}

		private void btn_exersize_1_Click (object sender, EventArgs e)
		{
			eyeTrainer.Exersize_1();
		}
	}
	}
