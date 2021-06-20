namespace BaiLab6.Ex2
{
    public class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        private float _Temperature;
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                System.Console.WriteLine("Heater: On");
            }
            else
            {
                System.Console.WriteLine("Heater: Off");
            }
        }
    }
}