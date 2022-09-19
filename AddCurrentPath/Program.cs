using System;

namespace AddCurrentPath;

// 将应用的当前路径加入的用户Path中
internal static class Program
{
    private static void Main()
    {
        Console.WriteLine($"Current Path is {AppContext.BaseDirectory}");
        Console.ReadLine();

        // const EnvironmentVariableTarget environmentVariableTarget = EnvironmentVariableTarget.User;
        // const string variable = "Path";
        //
        // var result = Environment.GetEnvironmentVariable(variable, environmentVariableTarget);
        // if (result is null) throw new NullReferenceException();
        //
        // var paths = result.Split(";");
        // var currentPath = AppContext.BaseDirectory;
        // if (paths.Contains(currentPath))
        // {
        //     Console.WriteLine("already exist!");
        // }
        // else
        // {
        //     Console.WriteLine($"about to add {currentPath} to Path");
        //     var value = $"{result};{currentPath}";
        //     Environment.SetEnvironmentVariable(variable, value, environmentVariableTarget);
        //     Console.WriteLine("done!");
        // }
        // Console.WriteLine("Press [Enter] to exit");
        // Console.ReadLine();
    }
}