using static SDL2.SDL;
using System.Numerics;

namespace JiayiLauncher.Utils;

// common utils
public static class Common
{
    // window size
    public static Vector2 WindowSize = new(900, 550);

    // delta time
    public static double DeltaTime = 0; // set by the main loop

    // is a position inside a certain rectangle
    public static bool IsInside(Vector2 position, Vector2 rectPosition, Vector2 rectSize)
    {
        if (position.X >= rectPosition.X && position.X <= rectPosition.X + rectSize.X)
        {
            if (position.Y >= rectPosition.Y && position.Y <= rectPosition.Y + rectSize.Y)
            {
                return true;
            }
        }

        return false;
    }

    // is the mouse inside a certain rectangle (shorthand method)
    public static bool IsMouseInside(Vector2 rectPosition, Vector2 rectSize, SDL_Event e)
    {
        return IsInside(new Vector2(e.button.x, e.button.y), rectPosition, rectSize);
    }
}