using CustomTestingFramework.Attributes;
using CustomTestingFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CustomTestingFramework.TestRunner
{
    public class TestRunner
    {
        private readonly ICollection<string> resultInfo;

        public TestRunner()
        {
            resultInfo = new List<string>();
        }

        
        public ICollection<string> Run(string path)
        {
            var testClasses = Assembly
                .LoadFile(path)
                .GetTypes()
                .Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof
                (TestClassAttribute))).ToList();

            foreach (var testClass in testClasses)
            {
                var testMethods = testClass
                    .GetMethods()
                     .Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof
                (TestMethodAttribute))).ToList();

                var testClassInstance = Activator.CreateInstance(testClass);

                foreach (var methodInfo in testMethods)
                {
                    try
                    {
                        methodInfo.Invoke(testClassInstance, null);

                        resultInfo.Add($"Method {methodInfo.Name} - passed");
                    }
                    catch (TestException e)
                    {
                        resultInfo.Add($"Method {methodInfo.Name} - failed");
                    }
                    catch
                    {
                        resultInfo.Add($"Method {methodInfo.Name} - unexpected error ocured");
                    }
                }
            }

            return resultInfo;

        }
    }
}
