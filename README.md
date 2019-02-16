# Keylogger
**A library that uses the Windows API to catch keypress events**

## Add library to project and then put 'using Eze.IO.Workspace;'
### Example
``` c#
static void Main(string[] args)
{
    DetectKey.OnKeyPressed += OnKeyPress_Handled;
}

protectecd void OnKeyPress_Handled(LoggedKeys keys)
{
   VirtualKeys k = keys.Key;
   if(k == VirtualKeys.Enter)
   {
      //User pressed 'enter'key
   }
}
```
