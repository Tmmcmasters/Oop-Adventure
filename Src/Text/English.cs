using OOPADVENTURE;

public class English :Language //English Class "Inherits" all the properties from the language class
                                //Allows us to use properties for Language and just add English or Spanish Specific Classes
{

    public English() {

        ChooseYourName = "Hello, what is your name?";  //When it is constructed sets the value of ChooseYourName to the string
        DefaultName = "No Name";
        Welcome = "Welcome, {0}, to your OOP Adventure!";

    }

}