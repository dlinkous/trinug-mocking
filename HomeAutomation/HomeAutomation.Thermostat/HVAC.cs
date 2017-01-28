using System;

namespace HomeAutomation.Thermostat
{
	internal class HVAC : IHVAC
	{
		private string status = "Off";

		public void Cool()
		{
			status = "Cooling";
		}

		public void Heat()
		{
			status = "Heating";
		}

		public void Off()
		{
			status = "Off";
		}

		private string GetStatus()
		{
			return status;
		}
	}
}
