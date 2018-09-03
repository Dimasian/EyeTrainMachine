﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace EyeTrainMachine_WinForms
{
	public static class FindComPort
	{
		static FindComPort()
		{

		}

		public static string AutodetectArduinoPort ()
		{
			ManagementScope connectionScope = new ManagementScope();
			SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
			ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

			try
			{
				foreach (ManagementObject item in searcher.Get())
				{
					string desc = item["Description"].ToString();
					string deviceId = item["DeviceID"].ToString();

					if (desc.Contains("Arduino"))
					{
						return deviceId;
					}
				}
			}
			catch (ManagementException e)
			{
				/* Do Nothing */
			}

			return null;
		}
	}
}
