namespace BaiLab6.Ex2
{
    public class Thermostat
    {
        public delegate void TemperatureChangeHandler(float newTemperature);
        
        private TemperatureChangeHandler _OnTemperatureChange;
        private float _CurrentTemperature;

        public TemperatureChangeHandler OnTemperatureChange
        {
            get{ return _OnTemperatureChange;}
            set{ _OnTemperatureChange = value;}
        }

        public float CurrentTemperature
        {
            get { return _CurrentTemperature;}
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if (OnTemperatureChange != null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }
    }
}