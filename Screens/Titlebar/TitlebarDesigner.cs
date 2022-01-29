using Secret.UI.Elements;
using static SDL2.SDL;
using System.Numerics;
using Secret.Utils;

namespace Secret.Screens;

// custom title bar
public partial class Titlebar
{
    // the "bar" of the titlebar
    public Frame Bar;

    // close and minimize buttons
    public Button CloseButton;
    public Button MinimizeButton;

    // the title of the window
    public TextLabel Title;

    // the icon of the window
    public Picture Icon;

    // initialize the titlebar
    public void Initialize()
    {
        // create elements
        Bar = new Frame(new Vector2(0, 0), new Vector2(Common.WindowSize.X, 20), Colors.Layer1);

        CloseButton = new Button
            (new Vector2(Common.WindowSize.X - 20, 0), new Vector2(20, 20), "X", Fonts.MontserratExtraBold(12), Colors.Layer1, Colors.Text);
        MinimizeButton = new Button
            (new Vector2(Common.WindowSize.X - 40, 0), new Vector2(20, 20), "—", Fonts.MontserratExtraBold(12), Colors.Layer1, Colors.Text);

        Title = new TextLabel(new Vector2(20, 0), Colors.Text, "Title", Fonts.MontserratBlack(12));
        Icon = new Picture(new Vector2(0, 0), "icon.png");

        // set parent elements
        Bar.Add(CloseButton);
        Bar.Add(MinimizeButton);
        Bar.Add(Title);
        Bar.Add(Icon);

        // events
        CloseButton.Click += CloseButton_OnClick;
        MinimizeButton.Click += MinimizeButton_OnClick;
    }
}