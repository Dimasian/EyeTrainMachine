using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace EyeTrainMachine_WinForms
{


	public class EyeTrainer
	{
		//--variables-------------
		int exersizes = 1;//currently NOT USED
		int steps = 1;//defines how far object goes towards or backwards in one step

		//--objects declaration---
		SerialPort port;
		StepperMotor motor;
		public static Button btn_connect;
		public static TextBox tbStatus;
		public static TextBox tbFromArduino;
		public static Label lblFrontSensor;
		public static Label lblRearSensor;
		public static Button Exersize0;
		public static Label lblIterations;
		public static Label lblDist;



		public EyeTrainer ()
		{
			lblFrontSensor.BackColor = Color.Red;
			lblRearSensor.BackColor = Color.Red;
		}
		public void CloseConnection ()
		{
			if (port != null)
			{
				port.Close ();
				tbStatus.Text += "Port has been closed!\n";
				btn_connect.Text = "CONNECT";
			}
		}
		public void OpenConnection ()
		{
			//?: how to find serial port of Arduino?

			string portName = FindComPort.AutodetectArduinoPort ();
			portName = "COM4";//BECAUSE AUTODETECT DOESN'T WORK!!!
			port = new SerialPort (portName, 9600);
			motor = new StepperMotor (port, 20, 100);
			try
			{
				//un-comment this line to cause the arduino to re-boot when the serial connects
				port.DtrEnable = true;
				port.Open ();
				tbStatus.Text += "Port has been opened!\n";
				btn_connect.Text = "DISCONNECT";
			}
			catch
			{
				//alert the user that we could not connect to the serial port
				tbStatus.Text = "Can't connect to serial port!\n";
			}
		}
		//currently NOT USED (because for each exersize there's a button on form)
		public void ExecuteExersizes ()
		{
			for (int i = 0; i < exersizes; i++)
			{
				Exersize (i);
			}
		}
		private void Exersize (int n)
		{
			switch (n)
			{
				case 0:
					Exersize_0 ();
					break;
				case 1:
					//Exersize_1();
					break;
				case 2:
					//Exersize_2();
					break;
				default:
					break;
			}
		}
		//from center move backwards, wait, move to center. repeat i times.
		public void Exersize_0 ()
		{
			string msg;
			int rem = 50;
			tbStatus.Text += "Exersize 0 is started!\n";
			steps = motor.stepsPerRevolution / 2;//defines how far object goes towards or backwards in one step
			for (int i = 0; i <= rem; i++)
			{

				msg = ReadComPortMessage ();
				if (msg == "done" || i == 0)
				{
					motor.Rotate (-steps);
					//EXECUTE ASYNC FOR NOT TO HALT PROGRAM?
					Thread.Sleep (1500);
				}
				if (msg == "done" || i == 0)
				{
					motor.Rotate (steps);
					//EXECUTE ASYNC FOR NOT TO HALT PROGRAM?
					lblIterations.Text = (rem - i).ToString ();
					Application.DoEvents ();
					Thread.Sleep (1500);
				}
			}
			tbStatus.Text += "Exersize 0 is complete!\n";
		}
		//from center move backwards, wait, move to center. repeat i times.
		public void Exersize_1 ()
		{
			string msg;
			int rem = 50;
			tbStatus.Text += "Exersize 1 is started!\n";
			steps = motor.stepsPerRevolution;//defines how far object goes towards or backwards in one step
			motor.motorSpeed = 500;
			motor.stepsPerRevolution = 1000;
			for (int i = 0; i <= rem; i++)
			{

				msg = ReadComPortMessage ();
				if (msg == "done" || i == 0)
				{
					motor.Rotate (-steps);
					//EXECUTE ASYNC FOR NOT TO HALT PROGRAM?
					Thread.Sleep (1500);
				}
				if (msg == "done" || i == 0)
				{
					motor.Rotate (steps);
					//EXECUTE ASYNC FOR NOT TO HALT PROGRAM?
					lblIterations.Text = (rem - i).ToString ();
					Application.DoEvents ();
					Thread.Sleep (1500);
				}
			}
			tbStatus.Text += "Exersize 1 is complete!\n";
		}
		//find center of the guide pipe
		public void FindCenter ()
		{
			tbStatus.AppendText ("Searching center..." + Environment.NewLine);

			steps = 1;
			List<string> msg = new List<string> ();
			int dist = 0;
			bool frontSensorOn = false;
			bool rearSensorOn = false;

			while (!rearSensorOn)
			{
				msg.Add (ReadComPortMessage ());
				for (int i = 0; i < msg.Count; i++)
				{
					if (msg.Contains ("RearSensorOn"))
					{
						msg.Clear ();
						rearSensorOn = true;
						steps = -steps;
						motor.Rotate (-motor.stepsPerRevolution);
						dist += motor.stepsPerRevolution;
						tbStatus.AppendText ("Reached REAR sensor!" + Environment.NewLine);
						lblRearSensor.BackColor = Color.LightGreen;
						Thread.Sleep (1000);
						break;
					}
				}
				motor.Rotate (steps);
				tbFromArduino.AppendText ("Moving: " + steps + Environment.NewLine);
				lblDist.Text = dist.ToString ();
				Application.DoEvents ();
				Thread.Sleep (200);
			}


			while (!frontSensorOn)
			{
				msg.Add (ReadComPortMessage ());
				for (int i = 0; i < msg.Count; i++)
				{
					if (msg.Contains ("FrontSensorOn"))
					{
						frontSensorOn = true;
						steps = -steps;
						motor.Rotate (motor.stepsPerRevolution);
						tbStatus.AppendText ("Reached FRONT sensor!" + Environment.NewLine);
						lblFrontSensor.BackColor = Color.LightGreen;
						Thread.Sleep (1000);
						break;
					}
				}
				motor.Rotate (steps);
				dist += -steps;
				tbFromArduino.Text += "Moving: " + steps + Environment.NewLine;
				lblDist.Text = dist.ToString ();
				Application.DoEvents ();
				Thread.Sleep (200);
			}

			tbStatus.AppendText ("Distance = " + dist + Environment.NewLine);
			motor.Rotate ((int) (dist / 2 - motor.stepsPerRevolution));//move half the total distance to the center
			tbStatus.AppendText ("Center found!" + Environment.NewLine);
		}
		//read message from Arduino
		private string ReadComPortMessage ()
		{
			string msg = "";
			if (port.BytesToRead > 0)
			{
				msg = port.ReadLine ();
				msg = msg.TrimEnd (new char[] { '\r', '\n' });
			}
			return msg;
		}
	}//end class
}//end namespace
