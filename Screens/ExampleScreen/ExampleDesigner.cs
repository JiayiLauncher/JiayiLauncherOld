using JiayiLauncher.UI.Elements;
using static SDL2.SDL;
using System.Numerics;
using JiayiLauncher.Utils;

namespace JiayiLauncher.Screens;

public partial class ExampleScreen : Screen
{
    // the design of this screen goes here
    // elements
    public Frame Base;

    // small sidebar with example buttons
    public Frame Sidebar;
    public Button Button1;
    public Button Button2;
    public Button Button3;

    // the main content area
    public Frame Content;

    // frame with heading and subheading inside main content
    public Frame MainText;
    public TextLabel Heading;
    public TextLabel Subheading;

    // big button inside main content
    public Button BigButton;

    private void Initialize()
    {
        // create elements
        Base = new Frame(new Vector2(0, 0), Common.WindowSize, Colors.Background);

        Sidebar = new Frame(new Vector2(0, 0), new Vector2(200, Common.WindowSize.Y), Colors.Layer1);
        Button1 = new Button
            (new Vector2(0, 0), new Vector2(200, 50), "Button 1", Fonts.MontserratExtraBold(20), Colors.Button, Colors.Text);
        Button2 = new Button
            (new Vector2(0, 50), new Vector2(200, 50), "Button 2", Fonts.MontserratExtraBold(20), Colors.Button, Colors.Text);
        Button3 = new Button
            (new Vector2(0, 100), new Vector2(200, 50), "Button 3", Fonts.MontserratExtraBold(20), Colors.Button, Colors.Text);

        Content = new Frame(new Vector2(200, 0), new Vector2(Common.WindowSize.X - 200, Common.WindowSize.Y), Colors.Layer1);

        MainText = new Frame(new Vector2(0, 0), new Vector2(Content.Size.X, 100), Colors.Background);
        Heading = new TextLabel(new Vector2(0, 0), Colors.Text, "Heading", Fonts.MontserratBlack(30));
        Subheading = new TextLabel(new Vector2(0, 50), Colors.Gray, "Subheading", Fonts.MontserratBlack(20));

        BigButton = new Button
            (new Vector2(0, 0), new Vector2(Content.Size.X, 100), "Big Button", Fonts.MontserratExtraBold(30), Colors.Button, Colors.Text);

        // set parent elements
        Base.Add(Sidebar);
        Base.Add(Content);

        Sidebar.Add(Button1);
        Sidebar.Add(Button2);
        Sidebar.Add(Button3);

        Content.Add(MainText);
        MainText.Add(Heading);
        MainText.Add(Subheading);

        Content.Add(BigButton);

        // set event handlers
        BigButton.Click += BigButton_OnClick;
    }
}