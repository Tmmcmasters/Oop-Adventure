namespace OOPADVENTURE; //NameSpace allows you to avoid naming conflicts with the classes in your program.

public abstract class Character //Public lets the compiler know that this will be accessible by any other class in our program
                                //Abstract makes this class not "instiantable". They "extend" off of this base class in order to get their logic
{

    public string Name { get; set; } //Get;set; automatiically lets the compiler know to make this Name(below) getter and setter work 
                                        //When we create a character, it requires a "name" arguement that we can save to the property itself. 
    public Character(string name) //This is a "constructor." A "constructor" is what is called when the class is created.  
    {
        Name = name; 
    }

}
