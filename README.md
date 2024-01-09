# HiveOSAutoSwitcher

This is my attempt at creating a HiveOS Autoswitcher for Nicehash algorithms, using WhatToMine and C# :)

You need to create your own Secrets.cs and wtm.txt file (in the same directory as the .exe).
The wtm.txt file is the url to the wtm json file for your rig

### Secrets.cs
```
internal class Secrets
{
	public static string APIKey = "API Key From HiveOS Account -> Sessions -> Personal Tokens";
	public static string login = "**Your Username**";
	public static string password = "Your Password";
}
```