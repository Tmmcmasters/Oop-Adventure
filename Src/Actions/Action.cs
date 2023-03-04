namespace OOPADVENTURE;

public abstract class Action
{
    //Each action is this game is going to have a unique identifier called Name. Creating a property for Name using Virtual. Virtual tells the compiler that other classes that exten the action class are able to override the getter and setter of the virtual property. 
    public virtual string Name => ""; //WE use a => to automaticall generate a getter for us. The name will be set to base empty string on the base action class. 

    public virtual void Execute(string[] args)
    {
        throw new Exception("Nothing to execute");
    } 
}