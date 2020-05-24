# raspberryPi-1
My first .NET Raspberry Pi application

## Description
This is a simple project to be able to control a light on a breadboard hooked up to a Raspberry Pi. The Raspberry Pi will run this .NET application to control the connected LED. The light will blink on and off continuously.

## Usage
If you have a Raspberry Pi (4+) with .NET Core installed, you may use this code to switch an LED on and off. The LED should be wired to the Raspberry Pi with the source coming from GPIO Pin 17. The circuit should include a 220 Ohm resistor.

### Steps
1. Clone/copy this repository onto your Raspberry Pi
2. Navigate into the *Release* folder: `cd Release/`
3. Run the .NET application:
	`dotnet ConsoleApp1.dll`

## Setup
For those interested in setting up a Raspberry Pi to run this .NET application, see my post, [.NET and Raspberry Pi](https://blog.type-recorder.com/net-and-raspberry-pi/).

## Resources
See the below resources for tutorials and guidance on building .NET applications for your Raspberry Pi.

- [Setup .NET Core 3.0 Runtime and SDK on Raspberry Pi 4](https://edi.wang/post/2019/9/29/setup-net-core-30-runtime-and-sdk-on-raspberry-pi-4)
- [IoT 101: IoT with .NET Core (and Raspberry Pi)](https://channel9.msdn.com/Series/IoT-101) - These videos walk through creating a blinking light!
- [Sample .NET Core IoT Scenarios (with a Raspberry Pi)](https://github.com/dotnet/iot/blob/master/samples/README.md)
	- [Blink an LED with .NET Core on a Raspberry Pi](https://github.com/dotnet/iot/blob/master/samples/led-blink/README.md)
- [Using IoT on a Beer Kegerator](https://www.concurrency.com/blog/april-2018/using-iot-on-a-beer-kegerator)
