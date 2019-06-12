using System;
using NoConditionals;
using NoConditionalsSolved.IfElseToTable;
using NoConditionalsSolved.IoC;
using NoConditionalsSolved.MultipleEnums;
using NoConditionalsSolved.TemplatePattern;

namespace NoConditionalsSolved
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Look in each sub folder for examples.\r\n" +
                              "Using Console application even the examples have nothing to execute.\r\n" +
                              "Ech example contains task mark with TODO code comment.");


            var sensorValue = SensorValueToMovementConverter.CalculateBasedOnPrecision(5);
            var deviceFamilly = new DeviceToControllerAdapter(DeviceFamily.Hq300).GetDeviceFamilyName();
            new MotionAutomat().UpdatePosition(5);
            new CompositionRoot().Run();
            Console.ReadKey();
        }
    }
}
