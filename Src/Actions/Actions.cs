namespace OOPADVENTURE;


//This is all the logic that will allow us to create a single actions instance that we can use anywhere inside of our game. 
public sealed class Actions
{
    private static Actions _instance;

    public static Actions Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Actions();

            return _instance;
        }
    }

    private readonly Dictionary<string, Action> _registeredActions = new();

    private Actions ()
    {

    }

    public void Register (Action action)
    {
        var name = action.Name.ToLower (); //We don't the player to worry about what case they use when they type in the action name so they match up when we compare them.

        if (_registeredActions.ContainsKey (name))
            _registeredActions[name] = action; // if the action already exists. We replace the existing actions using the name for the key and the isntance of the action for its calue. 
        else 
            _registeredActions.Add (name, action); //If not, we add to the dictionary. 
    }

    public void Execute(string[] args) //This is the execute method that the player calls. It accepts a string of arguments. 
    {

        var actionName = args[0]; //We get the first value of the arguments array and set to the actionName. 

        if (_registeredActions.ContainsKey(actionName))
            _registeredActions[actionName].Execute(args);
        else
            Console.WriteLine(Text.Language.ActionError);

    }
}