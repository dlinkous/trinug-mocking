using System;
using NUnit;
using NUnit.Framework;
using HomeAutomation.Thermostat;

namespace HomeAutomation.Thermostat.UnitTests
{
	public class ControllerExampleTests
	{
		//[Test]
		public void ExecuteWithOriginalClasses()
		{
			var controller = new Controller(new Dashboard(), new Sensor(), new HVAC());
			controller.Execute();
		}
	}
}
