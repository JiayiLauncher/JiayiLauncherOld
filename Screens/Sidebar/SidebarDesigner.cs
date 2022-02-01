using JiayiLauncher.UI.Elements;
using static SDL2.SDL;
using System.Numerics;
using JiayiLauncher.Utils;

namespace JiayiLauncher.Screens;

public class Sidebar : Screen
{
    // icon only sidebar, we'll add buttons dynamically through the manager
    public Frame Base;

    // the jiayi logo
    public Picture Logo;

    // real quick: since i don't have the logo on hand, i'll just use a placeholder rectangle that is red
    public Rectangle RedRectangle;

    // init
    public void Initialize()
    {
        // create elements
        Base = new Frame(new Vector2(0, 0), new Vector2(50, Common.WindowSize.Y), Colors.Layer1);

        Logo = new Picture(new Vector2(0, 0), "Jiayi50x50.png");

        RedRectangle = new Rectangle(new Vector2(0, 0), new Vector2(50, 50), Colors.Button);

        // set parent elements
        Base.Add(Logo);
    }
}