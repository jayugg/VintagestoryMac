using Vintagestory.Client;
using Vintagestory.Client.NoObf;

namespace VintagestoryMac;

[Register ("AppDelegate")]
public class AppDelegate : NSApplicationDelegate {
	public override void DidFinishLaunching (NSNotification notification)
	{
		var args = NSProcessInfo.ProcessInfo.Arguments;
		Console.WriteLine("Unofficial Vintagestory Client to test URL Scheme Support on macOS");
		Console.WriteLine("Received arguments: " + string.Join(", ", args));
		var newArgs = args.Select(arg => arg.Replace("vintagestorymodinstall://", "-i vintagestorymodinstall://"))
			.ToArray();
		ClientProgram.Main(newArgs);
		
		// Kill the app
		NSApplication.SharedApplication.Terminate(this);
	}

	public override void WillTerminate (NSNotification notification)
	{
	}
}
