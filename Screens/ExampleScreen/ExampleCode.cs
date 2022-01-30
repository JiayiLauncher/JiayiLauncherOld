namespace Secret.Screens;

public partial class ExampleScreen : Screen
{
    public ExampleScreen()
    {
        Initialize();
    }

    // make the big button do something
    private void BigButton_OnClick(object? sender, EventArgs e)
    {
        // do something, like uhhhhh print a message
        Console.WriteLine("Big button clicked!");
    }
}