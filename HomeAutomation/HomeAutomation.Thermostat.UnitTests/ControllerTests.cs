using System;
using System.Linq;
using NUnit;
using NUnit.Framework;
using HomeAutomation.Thermostat;
using HomeAutomation.Thermostat.UnitTests.Mocks;

namespace HomeAutomation.Thermostat.UnitTests
{
	public class ControllerTests
	{
		[TestCase(68, 64, HVACMock.Mode.Heat)]
		[TestCase(68, 68, HVACMock.Mode.Off)]
		[TestCase(68, 75, HVACMock.Mode.Cool)]
		public void ExecuteWithTemperaturesAndAssertMode(int desired, int current, HVACMock.Mode expectedMode)
		{
			var dashboard = new DashboardMock();
			var sensor = new SensorMock();
			var hvac = new HVACMock();
			var controller = new Controller(dashboard, sensor, hvac);
			dashboard.DesiredTemperature = desired;
			sensor.CurrentTemperature = current;
			controller.Execute();
			var actualMode = hvac.History.Single();
			Assert.AreEqual(expectedMode, actualMode);
		}
	}
}
