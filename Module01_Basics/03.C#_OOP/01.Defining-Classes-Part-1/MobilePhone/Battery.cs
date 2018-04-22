using System;

namespace MobilePhone
{
    public class Battery
    {
        private const int MAX_HOURS_IDLE = 1000;
        private const int MAX_HOURS_TALK = 200;

        private BatteryType batteryType;
        private double? hoursIdle;
        private double? hoursTalk;

        public Battery()
        {
        }

        public Battery(BatteryType batteryType)
            : this(batteryType, null, null)
        {
        }

        public Battery(BatteryType batteryType, double? hoursIdle)
            :this(batteryType, hoursIdle, null)
        {
        }

        public Battery(BatteryType batteryType, double? hoursIdle, double? hoursTalk)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType BatteryType {
            get
            {
                return this.batteryType;
            }
            private set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("Battery type should not be a null or empty string!");
                }

                if (!Enum.IsDefined(typeof(BatteryType), value))
                {
                    throw new ArgumentException("Wrong battery type!");
                }

                this.batteryType = value;
            }
        }

        public double? HoursIdle {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value > MAX_HOURS_IDLE)
                {
                    throw new ArgumentException("Hours idle can not be such a large number!");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Hours idle must be a positive number!");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value > MAX_HOURS_TALK)
                {
                    throw new ArgumentException("Hours talk can not be such a large number!");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Hours talk must be a positive number!");
                }

                this.hoursTalk = value;
            }
        }
    }
}
