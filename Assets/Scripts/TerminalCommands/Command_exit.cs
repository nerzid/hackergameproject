using System;
using UnityEngine;

public class Command_exit : TerminalCommand
{
    // This command is ignored when used in Unity Editor.
    public Command_exit()
    {
        command = "exit";
        desc = "Closes the application";
    }

    protected override void runCommand()
    {
        Application.Quit();
    }
}
