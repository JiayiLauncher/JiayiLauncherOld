using System.Numerics;
using JiayiLauncher.Screens;
using JiayiLauncher.UI.Elements;
using JiayiLauncher.Utils;

namespace JiayiLauncher.Screens;

// i'm lazy, so here's the screen class
public class Screen
{
    // position
    public Vector2 Position;

    // all screens initialize themselves in their constructor, so we only need a method to destroy them
    public virtual void Destroy()
    {
        // do nothing
    }
}

// the manager of all screens, screen transitions, and the sidebar
public class Manager
{
    // sidebar
    public Sidebar Sidebar;

    // the screens
    public List<Screen> Screens = new();

    // the current screen
    public Screen? CurrentScreen = null;

    // constructor
    public Manager()
    {
        // create the sidebar
        Sidebar = new Sidebar();
    }

    // keep track of the button Y
    private int ButtonY = 70;
    public void AddScreen(Screen screen, string icon)
    {
        // add the screen to the list
        Screens.Add(screen);

        // create a button for the sidebar
        var button = new Button(new Vector2(0, ButtonY), new Vector2(50, 50), string.Empty, Fonts.MontserratExtraBold(20), Colors.Layer1, Colors.Text);
        button.Click += (sender, e) =>
        {
            // transition to the screen if it's not the current screen
            if (screen != CurrentScreen)
            {
                TransitionToScreen(screen);
            }
        };

        // add the button to the sidebar
        Sidebar.Base.Add(button);

        // create a picture for the sidebar
        var picture = new Picture(new Vector2(0, ButtonY), icon);

        // add the picture to the sidebar
        Sidebar.Base.Add(picture);

        // add 50 to the button Y
        ButtonY += 50;
    }

    // transition to a new screen
    public void TransitionToScreen(Screen screen)
    {
        // if the current is null, this is the first screen, so don't worry about smoothly transitioning the last one out
        if (CurrentScreen == null)
        {
            CurrentScreen = Screens[0];
            CurrentScreen.Position = new(0, Common.WindowSize.Y);
            Animation.EaseIn(CurrentScreen, new(50, 0), 0.5f);
        }
        else
        {
            // otherwise, smoothly transition the current screen out, then transition the new screen in
            Animation.EaseOut(CurrentScreen, new(Common.WindowSize.X, 0), 0.5f);
            Animation.EaseIn(screen, new(50, 0), 0.5f);
        }
    }
}