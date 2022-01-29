using static SDL2.SDL;

namespace Secret.Screens;

public partial class Titlebar
{
    // constructor
    public Titlebar()
    {
        Initialize();
    }

    // make the close and minimize buttons act like close and minimize buttons
    private void CloseButton_OnClick(object? sender, EventArgs e)
    {
        // close the window
        Program.App.Running = false;
    }

    private void MinimizeButton_OnClick(object? sender, EventArgs e)
    {
        // minimize the window
        //SDL_MinimizeWindow(Program.App.Window);
        // this code did hide the window but it also hung my entire computer, so let's try a different approach
        //SDL_HideWindow(Program.App.Window);
        // this code did not work either, let's leave this for now
    }
}