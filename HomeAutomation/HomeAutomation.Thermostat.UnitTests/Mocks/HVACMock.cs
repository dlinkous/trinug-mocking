using System;
using System.Collections.Generic;
using HomeAutomation.Thermostat;

namespace HomeAutomation.Thermostat.UnitTests.Mocks
{
	public class HVACMock : IHVAC
	{
		public enum Mode
		{
			Cool,
			Heat,
			Off
		}

		internal List<Mode> History = new List<Mode>();

		public void Cool()
		{
			History.Add(Mode.Cool);
		}

		public void Heat()
		{
			History.Add(Mode.Heat);
		}

		public void Off()
		{
			History.Add(Mode.Off);
		}
	}
}
