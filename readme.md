# UKGoodMorning

Catch fish of any size in Ultrakill!

![this ones for my fellow trans community](images/this%20ones%20for%20the%20lgbtq%20community.jpg)

## Usage

UKGoodMorning creates a new local preference, `fish_size`, that allows the sizes of the fish you catch to be adjusted. UKGoodMorning does **NOT** submit the size to the Steam leaderboards due to the way the leaderboard works in vanilla.

## Configuration

To adjust the fish size, simply open the console (F8) and type the following:
`prefs set_local int fish_size <size>`
(you replace \<size\> with the size that you want). This is set to 2 by default.

## Installation

You can install UKGoodMorning by first installing [BepInEx](https://docs.bepinex.dev/articles/user_guide/installation/index.html). After that, simply drag the file from the releases to `(path to ULTRAKILL)\BepInEx\plugins`. You're all set after that!

## Building

If you want to build UKGoodMorning for yourself, you'll need to open the project in Visual Studio 2022. After that, create a folder named `lib` and drag the following files from your Ultrakill directory to this folder:

- `Assembly-CSharp.dll` (ULTRAKILL_Data\\Managed)
- `UnityEngine.dll` (ULTRAKILL_Data\\Managed)
- `UnityEngine.UI.dll` (ULTRAKILL_Data\\Managed)
- `UnityEngine.CoreModule.dll` (ULTRAKILL_Data\\Managed)
- `0Harmony.dll` (BepInEx\\core)
- `BepInEx.dll` (BepInEx\\core)

When you're done, simply build and you should get your UKGoodMorning.dll in `bin\Release`. It's a matter of installing it from there and you're all set!
