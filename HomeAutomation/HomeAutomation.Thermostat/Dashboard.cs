using System;

namespace HomeAutomation.Thermostat
{
	internal class Dashboard : IDashboard
	{
		public int GetDesiredTemperature()
		{
			return 72;
		}
	}
}
