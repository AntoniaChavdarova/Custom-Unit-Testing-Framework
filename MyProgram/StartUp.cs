using System;
using CustomTestingFramework.TestRunner;

namespace MyProgram
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var runner = new TestRunner();

            var result = runner.Run(@"D:\Repositiry\Custom-Unit-Testing-Framework\CustomTestingFramework.Tests\bin\Debug\netcoreapp3.1\CustomTestingFramework.Tests.dll");

           

            foreach (var info in result)
            {
                Console.WriteLine(info);
            }
        }
    }
}
