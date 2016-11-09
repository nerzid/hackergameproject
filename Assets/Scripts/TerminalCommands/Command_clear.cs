

using System;

public class Command_clear : TerminalCommand
{
    public Command_clear()
    {
        command = "clear";
        desc = "Clears the terminal meaning deletes all text on it.";
    }

    protected override void runCommand()
    {
        Terminal.terminalText.text = "";
    }
}
