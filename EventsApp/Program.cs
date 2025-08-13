namespace EventsApp
{
    // Delegate declaration(Signature of method that handles the event)
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler? OnTemperatureChange;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                if (_temperature > 30)
                {
                    // RAISE EVENT
                    RaiseTemperatureChangedEvent("Temperature is above threshold!");

                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChange?.Invoke(message);

        }

    }

       // Subscriber
        public class TemperatureAlert
        {
            public void OnTemperatureChange(string message)
            {
                Console.WriteLine("Alert: " + message);
            }
        }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instances
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.OnTemperatureChange += alert.OnTemperatureChange;

            monitor.Temperature = 20;
            // Get user's input
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine() ?? "");

            Console.ReadKey();
        }
    }
}