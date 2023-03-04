using System.Reflection;
// .dll and .exe

#nullable disable


const string dllFile = "CalculatorDll.dll";
var path = Path.Combine(Directory.GetCurrentDirectory(), "ext", dllFile);


if (!File.Exists(path))
{
    Console.WriteLine("Error: CalculatorDLL.dll not found");
    return;
}



var assembly = Assembly.LoadFrom(path);

var calculatorType = assembly.GetType("CalculatorDll.Calculator");

var calculatorInstance = Activator.CreateInstance(calculatorType);

var subtractMethodInfo = calculatorType.GetMethod("Subtract");
var result = subtractMethodInfo.Invoke(calculatorInstance, new object[] { 10, 3 });

Console.WriteLine(result);





// Calculator calculator = new();
// Console.WriteLine(calculator.Add(10, 5));