using UnityEngine;
using System.Collections;
using System;

public class Command_ls : TerminalCommand
{
    public Command_ls()
    {
        command = "ls";
        desc = "List all files and directories in the current directory";
    }

    protected override void runCommand()
    {
        String text = "";
        text = "<b>" + "<color=red>" + "Not implemented yet" + "</color>" + "</b>";
        Terminal.printToTerminal(text);
    }
}
