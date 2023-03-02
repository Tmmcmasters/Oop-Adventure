namespace OOPADVENTURE;

public partial class House //Tells the compiler to look at any other files in our project that are partial class House. Then it will concatenate them all into a single file when it compiles
{
    public Player Player { get; }

    private readonly Random _rnd = new(1234); //read only tells the compiler to automaticall set the value of the field when compiling and it cant be changed at runtime. 

    public House (Player player)
    {
        Player = player;
    }

}