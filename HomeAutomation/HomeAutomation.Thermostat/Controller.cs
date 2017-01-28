using System;

namespace HomeAutomation.Thermostat
{
	public class Controller
	{
		private readonly IDashboard dashboard;
		private readonly ISensor sensor;
		private readonly IHVAC hvac;

		public Controller(IDashboard dashboard, ISensor sensor, IHVAC hvac)
		{
			if (dashboard == null) throw new ArgumentNullException(nameof(dashboard));
			if (sensor == null) throw new ArgumentNullException(nameof(sensor));
			if (hvac == null) throw new ArgumentNullException(nameof(hvac));
			this.dashboard = dashboard;
			this.sensor = sensor;
			this.hvac = hvac;
		}

		public void Execute()
		{
			var desiredTemperature = dashboard.GetDesiredTemperature();
			var currentTemperature = sensor.Read();
			if (currentTemperature < desiredTemperature)
			{
				hvac.Heat();
			} else if (currentTemperature == desiredTemperature)
			{
				hvac.Off();
			} else if (currentTemperature > desiredTemperature)
			{
				hvac.Cool();
			}
		}
	}
}
