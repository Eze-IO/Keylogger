# KeyLogger

[![NuGet](https://img.shields.io/nuget/v/EzeIO.Keylogger.svg)](https://www.nuget.org/packages/EzeIO.Keylogger) [![build](https://github.com/Eze-IO/Keylogger/actions/workflows/build.yml/badge.svg)](https://github.com/Eze-IO/Keylogger/actions/workflows/build.yml)

**A library that uses the Windows low-level keyboard hook (`WH_KEYBOARD_LL`) to raise an event when a key is pressed, with COM support.**

Targets .NET Framework 4.6.2+ and .NET 8 (`net8.0-windows`).

## Intended use

This is a low-level input library for building legitimate Windows software: global
hotkeys and shortcut managers, accessibility and assistive-input tools, automation and
macro utilities, kiosk/point-of-sale input handling, and games that need raw key state.

Capturing keystrokes is sensitive. Use it only where you have a clear, lawful basis and,
where applicable, the informed consent of the people whose input is captured. Do not use
it to covertly record another person's keystrokes, harvest credentials, or otherwise
monitor someone without their knowledge — that is likely illegal and is not a supported
use case. You are responsible for complying with the laws and policies that apply to you.

## Usage

Install the package, then use the namespace:

```
dotnet add package EzeIO.Keylogger
```

```c#
using Eze.IO.Workspace;
```

### Subscribe to key presses

```c#
static void Main(string[] args)
{
    DetectKey.OnKeyPressed += OnKeyPress_Handled;
}

static void OnKeyPress_Handled(LoggedKeys keys)
{
    VirtualKeys k = keys.Key;
    if (k == VirtualKeys.Enter)
    {
        // User pressed the 'Enter' key
    }
}
```

Adding the first handler installs the hook; removing the last handler (`-=`) uninstalls it. `DetectKey.IsDetecting` reports whether the hook is currently installed.

`LoggedKeys` exposes the pressed key as a `VirtualKeys` value (`Key`) and its name (`KeyName`).

### COM

`DetectKeyFactory` (ProgId `Eze.IO.Workspace.DetectKeyFactory`) exposes the same event to COM clients such as VBScript or VBA, once the .NET Framework build is registered with `regasm /codebase Keyboard.dll`. Set `Detect` to `true` to start raising `OnKeyPressed`.

## Building

```
dotnet build Keylogger.sln
dotnet pack src/Keyboard.csproj -c Release -o artifacts
```

The hook is a Windows API and runs on Windows only.

## License

[MIT](LICENSE)
