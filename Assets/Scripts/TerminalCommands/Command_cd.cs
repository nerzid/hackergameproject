
using System;

public class Command_cd : TerminalCommand
{
    public Command_cd()
    {
        command = "cd";
        desc = "Change directory to <file_path>";
    }

    protected override void runCommand()
    {
        String text = "";
        text = "<b>" + "<color=red>" + "Not implemented yet" + "</color>" + "</b>";
        Terminal.printToTerminal(text);
    }
}
