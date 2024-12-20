# BananaAutoClicker

A MelonLoader mod for automating banana collection in the game **Banana** by OnlyBananasStudio.  

## Features

- **Auto Clicker**: Automates the process of collecting bananas in-game.
- **Toggle On/Off**: Easily toggle the auto-clicker functionality using the `F1` key.

## Requirements

- [MelonLoader](https://melonwiki.xyz/) (latest version recommended)
- The game **Banana** by OnlyBananasStudio

## Installation

1. **Install MelonLoader**:
   - Follow the [official MelonLoader installation guide](https://melonwiki.xyz/#/README?id=installing-melonloader).

2. **Download the Mod**:
   - Clone this repository or download the latest release from the [Releases](https://github.com/your-repo/releases) page.

3. **Add the Mod**:
   - Place the `BananaAutoClicker.dll` file into the `Mods` folder of your game's directory.

4. **Launch the Game**:
   - Start the game, and MelonLoader will automatically load the mod.

## Usage

1. **Activate/Deactivate**:
   - Press the `F1` key during gameplay to toggle the auto-clicker on or off.
   - A log message will confirm the current status:
     - `"Auto Clicker Active"`: Auto-clicker is running.
     - `"Auto Clicker Paused"`: Auto-clicker is disabled.

2. **Automatic Banana Collection**:
   - When active, the mod will continually add bananas to your total.

## Development

This mod is written in C# and uses the **MelonLoader** framework for integration with Unity games.

### Code Overview

- **Namespace**: `BananaAutoClicker`
- **Main Class**: `Core` (inherits from `MelonMod`)
- **Key Functionalities**:
  - Initializes upon game start (`OnInitializeMelon` and `OnLateInitializeMelon`).
  - Detects the `GameManager` to interact with the game's banana-collection mechanics.
  - Monitors for `F1` key input to toggle the auto-clicker.

## Contributing

1. Fork the repository.
2. Create a new branch (`feature/my-feature`).
3. Commit your changes.
4. Open a pull request to contribute!

## Disclaimer

This mod is provided "as is" and is not affiliated with **OnlyBananasStudio**. Use at your own risk. Always back up your game files before using mods.

## License

This project is licensed under the [MIT License](LICENSE).
