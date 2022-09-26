using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace AddCurrentPath;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine($"Current Path is {Directory.GetCurrentDirectory()}");
        Console.WriteLine("More features will coming soon!");

        if (VersionCheck() is false)
        {
            Console.WriteLine("Press [Enter] to quit");
            Console.ReadLine();
        }

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

    private static bool VersionCheck()
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            Process.GetCurrentProcess().ProcessName);

        if (Directory.Exists(path) is false)
            Directory.CreateDirectory(path);

        var assembly = Assembly.GetExecutingAssembly();
        var entryFileInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
        var version = entryFileInfo.ProductVersion;

        var versionFilePath = Path.Combine(path, "version.txt");
        if (File.Exists(versionFilePath) is false)
        {
            File.WriteAllText(versionFilePath, version);
            return true;
        }

        var content = File.ReadAllText(versionFilePath);
        if (content == version)
            return false;

        File.WriteAllText(versionFilePath, version);
        return true;
    }
}