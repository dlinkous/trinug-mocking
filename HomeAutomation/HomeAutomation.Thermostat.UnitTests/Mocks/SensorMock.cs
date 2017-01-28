using System;
using HomeAutomation.Thermostat;

namespace HomeAutomation.Thermostat.UnitTests.Mocks
{
	internal class SensorMock : ISensor
	{
		internal int CurrentTemperature = 0;

		public int Read()
		{
			return CurrentTemperature;
		}
	}
}
