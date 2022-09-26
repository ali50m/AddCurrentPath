using System;
using System.IO;
using System.Runtime.Versioning;
using Squirrel;

namespace AddCurrentPath;

// 将应用的当前路径加入的用户Path中
[SupportedOSPlatform("windows")]
internal static class Program
{
    private static bool _hint;

    private static void Main()
    {
        // run Squirrel first, as the app may exit after these run
        SquirrelAwareApp.HandleEvents(onEveryRun: OnAppRun);

        Console.WriteLine($"Current Path is {Directory.GetCurrentDirectory()}");
        Console.WriteLine("More features will coming soon!");
        if (_hint is false) return;

        Console.WriteLine("Press [Enter] to quit");
        Console.ReadLine();

        // Console.WriteLine("Press [Enter] to quit");
        // Console.ReadLine();

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

    private static void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
    {
        if (firstRun is false) _hint = true;
    }
}