using System.Numerics;
using JiayiLauncher.UI.Elements;
using JiayiLauncher.UI;
using JiayiLauncher.Screens;
using static SDL2.SDL;
using JiayiLauncher.Utils;

namespace JiayiLauncher.Utils;

// class for animating elements and screens
public static class Animation
{
    // element ease in
    public static void EaseIn(Element element, Vector2 end, float speed)
    {
        // get the current position
        var start = element.Position;

        // get the distance between the two points
        var distance = Vector2.Distance(start, end);

        // get the time it takes to get to the end
        var time = distance / speed;

        // get the time passed
        var timePassed = 0f;

        // while the time passed is less than the time it takes to get to the end
        while (timePassed < time)
        {
            // get the percentage of time passed
            var percentage = timePassed / time;

            // get the new position
            var newPosition = Vector2.Lerp(start, end, percentage);

            // set the new position
            element.Position = newPosition;

            // increment the time passed
            timePassed += (float)Common.DeltaTime;
        }

        // set the final position
        element.Position = end;
    }

    // same thing, but for screens
    public static void EaseIn(Screen screen, Vector2 end, float speed)
    {
        // get the current position
        var start = screen.Position;

        // get the distance between the two points
        var distance = Vector2.Distance(start, end);

        // get the time it takes to get to the end
        var time = distance / speed;

        // get the time passed
        var timePassed = 0f;

        // while the time passed is less than the time it takes to get to the end
        while (timePassed < time)
        {
            // get the percentage of time passed
            var percentage = timePassed / time;

            // get the new position
            var newPosition = Vector2.Lerp(start, end, percentage);

            // set the new position
            screen.Position = newPosition;

            // increment the time passed
            timePassed += (float)Common.DeltaTime;
        }

        // set the final position
        screen.Position = end;
    }

    // element ease out
    public static void EaseOut(Element element, Vector2 end, float speed)
    {
        // get the current position
        var start = element.Position;

        // get the distance between the two points
        var distance = Vector2.Distance(start, end);

        // get the time it takes to get to the end
        var time = distance / speed;

        // get the time passed
        var timePassed = 0f;

        // while the time passed is less than the time it takes to get to the end
        while (timePassed < time)
        {
            // get the percentage of time passed
            var percentage = timePassed / time;

            // get the new position
            var newPosition = Vector2.Lerp(start, end, percentage);

            // set the new position
            element.Position = newPosition;

            // increment the time passed
            timePassed += (float)Common.DeltaTime;
        }

        // set the final position
        element.Position = end;
    }

    // same thing, but for screens
    public static void EaseOut(Screen screen, Vector2 end, float speed)
    {
        // get the current position
        var start = screen.Position;

        // get the distance between the two points
        var distance = Vector2.Distance(start, end);

        // get the time it takes to get to the end
        var time = distance / speed;

        // get the time passed
        var timePassed = 0f;

        // while the time passed is less than the time it takes to get to the end
        while (timePassed < time)
        {
            // get the percentage of time passed
            var percentage = timePassed / time;

            // get the new position
            var newPosition = Vector2.Lerp(start, end, percentage);

            // set the new position
            screen.Position = newPosition;

            // increment the time passed
            timePassed += (float)Common.DeltaTime;
        }

        // set the final position
        screen.Position = end;
    }
}