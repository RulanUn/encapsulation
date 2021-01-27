using System;

namespace ConsoleApp1
{
    class Gun
    {
        private bool isLoaded;

        private void Reloaded()
        {
           
                Console.WriteLine("Заряжаем...");
                isLoaded = true;
                Console.WriteLine("Заряжено!");
        }
        public void Shut()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reloaded();
            }
            
            Console.WriteLine("Пабах...");
            isLoaded = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shut();
        }
    }
}
