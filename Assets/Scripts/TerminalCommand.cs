using System.Collections;

public abstract class TerminalCommand
{
    public string command; // e.g.   cd, ls
    public string desc; // e.g.  change directory to <file_path>
    public static ArrayList commands;  // all available commands

    protected TerminalCommand()
    {
        commands.Add(this);
    }

    public static void prepareTerminalCommands()
    {
        commands = new ArrayList();

        TerminalCommand cmd_cd = new Command_cd();
        TerminalCommand cmd_ls = new Command_ls();
        TerminalCommand cmd_help = new Command_help();
        TerminalCommand cmd_clear = new Command_clear();
        TerminalCommand cmd_exit = new Command_exit();
    }

    public static void findAndRunCommand(string text)
    {
        string[] tokens = text.Split(' ');
        bool foundIt = false;
        foreach (TerminalCommand t_cmd in commands)
        {
            if (t_cmd.command.Equals(tokens[0]))
            {
                foundIt = true;
                t_cmd.runCommand();
                break;
            }
        }

        if (!foundIt)
        {
            string toBePrinted = "";
            toBePrinted += "<b>" + "<color=red>" + "Command does not exist" + "</color>" + "</b>";
            Terminal.printToTerminal(toBePrinted);
        }
            
    }

    protected abstract void runCommand();

    public override string ToString()
    {
        return "\t" + command + " - " + desc;
    }

}
