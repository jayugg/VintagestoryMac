using System;
using System.IO;
using System.Linq;
using SmushSharp;
using Vintagestory.API.Config;
using Vintagestory.Client;
using Vintagestory.Common;
using Vintagestory.Server;

#nullable enable

namespace Vintagestory;

public class ClientMac
{
    private static void Main(string[] args)
    {
        /*
        var logDir = Path.Combine(GamePaths.Logs, "Launch");
        
        var logFile = Path.Combine(logDir, "client-mac.log");
        var fs = new FileStream(logFile, FileMode.CreateNew);
        var writer = new StreamWriter(fs) { AutoFlush = true };
        Console.SetOut(writer);
        Console.SetError(writer);
        Console.WriteLine("Logging started at " + DateTime.Now);
        */

        // If we have CLI args, skip URL detection
        if (args.Length > 0)
        {
            StartGame(args);
            return;
        }
        Console.WriteLine("Waiting for a URL…");
        var launchUrl = SmushSharp.SmushSharp.DetectLaunchUrl(0.5);
        if (!string.IsNullOrEmpty(launchUrl))
            Console.WriteLine("URL received: " + launchUrl);
        else
            Console.WriteLine("No URL received; launching normally.");

        StartGame(string.IsNullOrEmpty(launchUrl)
            ? []
            : [launchUrl]);
    }
    private static void StartGame(string[] args)
    {
        Console.WriteLine("Unofficial Vintagestory Client to test URL Scheme Support on macOS");
        Console.WriteLine("Received arguments: " + string.Join(", ", args));
		
        var newArgs = args
            .Select(arg => arg.Replace("vintagestorymodinstall://", "-i vintagestorymodinstall://"))
            .ToArray();
		
        ClientProgram.Main(newArgs);
    }
}
