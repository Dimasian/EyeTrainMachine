using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace EyeTrainMachine_WinForms
	{
	public class StepperMotor
		{
		SerialPort port;
		string msg;
		public int stepsPerRevolution = 20;
		public int motorSpeed = 100;

		public StepperMotor (SerialPort port,int stepsPerRevolution, int motorSpeed)
			{
			this.port = port;
			this.stepsPerRevolution=stepsPerRevolution;
			this.motorSpeed=motorSpeed;
			}
		public void Rotate (int steps)
			{
			msg=steps+":"+motorSpeed+"&";
			port.Write(msg);
		  }
		}
	}
