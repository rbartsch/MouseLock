# MouseLock
A C# program that allows you to constrain your mouse movement within your primary screen monitor's borders or an arbitrary area.

A compiled version is in the release section here (https://github.com/rbartsch/MouseLock/releases)

Useful for any situation when you need to constrain where the mouse cursor can go, for example in some PC video games when you play in windowed or borderless windowed mode the cursor does not constrain to the the game window.
This program would allow you to size the form to the physical window of the game, or in case of a full screen borderless window mode game you can just use the default constraint to constrain it to your primary monitor's screen resolution.

![program](https://i.imgur.com/vHLmFXn.png "Program screenshot")

Dependencies:

GlobalMouseKeyHook (https://github.com/gmamaladze/globalmousekeyhook) - used for when for system-wide tracking of mouse and keyboard when a win form is not focused. Compile manually and add its reference to the project or follow its nuget instructions.
