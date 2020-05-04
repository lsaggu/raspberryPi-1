using System;
using System.Device.Gpio;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //vars
            int pin = 18;
            int onTime = 1000; //time light will remain on in milliseconds
            int offTime = 200; //time light will be off in milliseconds

            //initialize GPIO controller
            GpioController rPiController = new GpioController();
            rPiController.OpenPin(pin);

            Console.WriteLine("Hello World!");

            while (true)
            {
                rPiController.Write(pin, PinValue.High); //turn on the light
                Thread.Sleep(onTime); //wait
                rPiController.Write(pin, PinValue.Low); //turn off the light
                Thread.Sleep(offTime); //wait
            }

        }
    }
}
