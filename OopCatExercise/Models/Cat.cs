using System;
namespace OopCatExercise.Models
{
	public abstract class Cat : ICat
	{
        public bool IsAsleep { get; private set; } = false;
        public double AverageHeight { get; private set; }
        public string Setting { get; private set; }

		public Cat(int averageheight, string setting) 
		{
            AverageHeight = averageheight;
            Setting = setting;
		}



        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp() 
        {
            IsAsleep = false;
        }

        public abstract string Eat();
    }
}
