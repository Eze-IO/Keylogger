# Keyboard

[![NuGet](https://img.shields.io/nuget/v/EzeIO.Keylogger.svg)](https://www.nuget.org/packages/EzeIO.Keylogger) [![build](https://github.com/Eze-IO/Keylogger/actions/workflows/build.yml/badge.svg)](https://github.com/Eze-IO/Keylogger/actions/workflows/build.yml)

**A library that uses the Windows low-level keyboard hook (`WH_KEYBOARD_LL`) to raise an event when a key is pressed, with COM support.**

Targets .NET Framework 4.6.2+ and .NET 8 (`net8.0-windows`).

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
