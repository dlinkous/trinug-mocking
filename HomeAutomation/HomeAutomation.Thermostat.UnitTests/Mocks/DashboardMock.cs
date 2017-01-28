using System;
using HomeAutomation.Thermostat;

namespace HomeAutomation.Thermostat.UnitTests.Mocks
{
	internal class DashboardMock : IDashboard
	{
		internal int DesiredTemperature = 0;

		public int GetDesiredTemperature()
		{
			return DesiredTemperature;
		}
	}
}
