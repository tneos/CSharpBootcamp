namespace EventsApp
{
    // Delegate declaration(Signature of method that handles the event)
    //public delegate void TemperatureChangeHandler(string message);

    // Create EventArgs class
    public class TemperatureChangeEventArgs : EventArgs
    {
        // property holding the temperature
        public int Temperature { get; }
        // Set temperature in constructor
        public TemperatureChangeEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        //public event TemperatureChangeHandler? OnTemperatureChange;
        // Generic event handler
        public event EventHandler<TemperatureChangeEventArgs>? TemperatureChange;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                // _temperature = value;
                // if (_temperature > 30)
                if(_temperature != value)
                {
                    _temperature = value;
                    // RAISE EVENT
                    OnTemperatureChange(new TemperatureChangeEventArgs(value));

                }
            }
        }

        protected virtual void OnTemperatureChange(TemperatureChangeEventArgs e)
        {
            TemperatureChange?.Invoke(this, e);

        }

    }

       // Subscriber
        public class TemperatureAlert
        {
            public void OnTemperatureChange(object ?sender, TemperatureChangeEventArgs e)
            {
                Console.WriteLine($"Alert: Temperature is {e.Temperature}, sender is {sender}");
            }
        }

        public class TempCoolingAlert
        {
            public void OnTemperatureChange(object ?sender, TemperatureChangeEventArgs e)
            {
                Console.WriteLine($"TEMP COOLING ALERT: Temperature is {e.Temperature}, sender is {sender}");
            }
        }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instances
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            monitor.TemperatureChange += alert.OnTemperatureChange;
            monitor.TemperatureChange += alert2.OnTemperatureChange;

            monitor.Temperature = 20;
            // Get user's input
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine() ?? "");

            Console.ReadKey();
        }
    }
}