using System;

public class Command_help : TerminalCommand
{
    public Command_help()
    {
        command = "help";
        desc = "Lists all avaliable commands";
    }

    protected override void runCommand()
    {
        string text = "";

        text += "<i>" + "<color=green>" + "Avaliable commands are" + "\n" + "</color>" + "</i>";
        foreach(TerminalCommand t_cmd in commands)
        {
            text += "\t<b>" + t_cmd.command + "</b>" + " - " + "<color=grey>" + t_cmd.desc + "</color>" + "\n";
        }
        
        Terminal.printToTerminal(text);
    }
}
