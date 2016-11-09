using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour {

    public GameObject terminalTextGO;
    public InputField inputField;

    public static Text terminalText;

    ArrayList commands;

	// Use this for initialization
	void Start () {
        terminalText = terminalTextGO.GetComponent<Text>();
        TerminalCommand.prepareTerminalCommands();
    }
	
	// Update is called once per frame
	void Update () {
        terminalInputListener();
    }

    void terminalInputListener() {
        if (inputField.isFocused)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                string user_text = inputField.text;
                if (!user_text.Trim().Equals(""))
                {
                    terminalText.text += "\n" + user_text.ToString();
                    TerminalCommand.findAndRunCommand(user_text);
                    inputField.text = "";
                }
            }            
        }
        inputField.Select();
        inputField.ActivateInputField();
    }

    public static void printToTerminal(string text)
    {
        terminalText.text += "\n" + text;
    }
}
