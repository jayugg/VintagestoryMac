# VintagestoryMac
This project provides an unoffical macOS client build for Vintage Story that supports one-click mod installation via URL scheme.
This is only for testing purposes and is not an official build of Vintage Story.
It does not contain any of the Vintage Story assets or code, which you must obtain from the official Vintage Story website after having bought an account.
Will be taken down at request of the Vintage Story team.

## How to Use
1. Download the latest version of Vintage Story from the official website.
2. Set the environment variable `VINTAGE_STORY_1_21_0` to the path of your Vintage Story installation.
3. Build the project using the command:
   ```bash
   dotnet build -c Release Vintagestory.csproj
   ```
4. The app bundle will be located in the `release` folder.
5. Place the `Vintagestory.app` bundle in your Applications folder.
6. Launch the app once to register the URL scheme.
7. You can now test the mod installation by running the following command in your terminal:
   ```bash
   vintagestorymodinstall://modid
   ```
8. Enjoy 1-click mod installation from your browser or terminal!

## License

The code in this repo is licensed under the MIT License.  
Vintage Story itself, and any other third‑party native libraries, remain under their original licenses.
