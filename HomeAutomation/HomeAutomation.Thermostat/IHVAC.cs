using System;

namespace HomeAutomation.Thermostat
{
	public interface IHVAC
	{
		void Cool();
		void Heat();
		void Off();
	}
}
