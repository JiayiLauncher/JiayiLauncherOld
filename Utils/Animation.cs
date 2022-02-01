using System.Numerics;
using JiayiLauncher.UI.Elements;
using JiayiLauncher.UI;
using JiayiLauncher.Screens;
using static SDL2.SDL;
using JiayiLauncher.Utils;

namespace JiayiLauncher.Utils;

public enum EasingStyle
{
    Constant, // constant speed
    Snap, // snap to the end
    Cubic, // cubic interpolation
    Elastic, // like it's a rubber band
    Bounce // like it's a bouncy ball
}

// class for animating elements and screens
public static class Animation
{
    public enum EasingDirection
    {
        In,
        Out,
        InOut
    }

    // animate an element
    public static void Animate(Element element, Vector2 destination, EasingStyle style, EasingDirection direction, float duration)
    {
        // get the current position
        var currentPosition = element.Position;

        // get the distance between the current position and the destination
        var distance = destination - currentPosition;

        // get the distance per frame
        var distancePerFrame = distance / duration;

        // get the easing function
        var easingFunction = GetEasingFunction(style, direction);

        // start the animation
        var animation = new Track(element, destination, easingFunction, distancePerFrame, duration);
        AnimationManager.AddAnimation(animation);
    }

    // animate a screen
    public static void Animate(Screen screen, Vector2 destination, EasingStyle style, EasingDirection direction, float duration)
    {
        // get the current position
        var currentPosition = screen.Position;

        // get the distance between the current position and the destination
        var distance = destination - currentPosition;

        // get the distance per frame
        var distancePerFrame = distance / duration;

        // get the easing function
        var easingFunction = GetEasingFunction(style, direction);

        // start the animation
        var animation = new Track(screen, destination, easingFunction, distancePerFrame, duration);
        AnimationManager.AddAnimation(animation);
    }

    // easing function
    private static Func<float, float> GetEasingFunction(EasingStyle style, EasingDirection direction)
    {
        switch (style)
        {
            case EasingStyle.Constant:
                return GetConstantEasingFunction(direction);
            case EasingStyle.Snap:
                return GetSnapEasingFunction(direction);
            case EasingStyle.Cubic:
                return GetCubicEasingFunction(direction);
            case EasingStyle.Elastic:
                return GetElasticEasingFunction(direction);
            case EasingStyle.Bounce:
                return GetBounceEasingFunction(direction);
            default:
                return GetConstantEasingFunction(direction);
        }
    }

    // constant easing function (move at a constant speed)
    private static Func<float, float> GetConstantEasingFunction(EasingDirection direction)
    {
        switch (direction)
        {
            case EasingDirection.In:
                return (t) => t;
            case EasingDirection.Out:
                return (t) => 1 - t;
            case EasingDirection.InOut:
                return (t) => t * 2 - 1;
            default:
                return (t) => t;
        }
    }

    // snap easing function (basically teleport to the destination)
    private static Func<float, float> GetSnapEasingFunction(EasingDirection direction)
    {
        switch (direction)
        {
            case EasingDirection.In:
                return (t) => 1;
            case EasingDirection.Out:
                return (t) => 0;
            case EasingDirection.InOut:
                return (t) => t;
            default:
                return (t) => t;
        }
    }

    // cubic easing function (the smooth one)
    private static Func<float, float> GetCubicEasingFunction(EasingDirection direction)
    {
        switch (direction)
        {
            case EasingDirection.In:
                return (t) => t * t * t;
            case EasingDirection.Out:
                return (t) => (--t) * t * t + 1;
            case EasingDirection.InOut:
                return (t) => t < 0.5 ? 4 * t * t * t : (t - 1) * (2 * t - 2) * (2 * t - 2) + 1;
            default:
                return (t) => t * t * t;
        }
    }

    // elastic easing function (like a rubber band)
    private static Func<float, float> GetElasticEasingFunction(EasingDirection direction)
    {
        switch (direction)
        {
            case EasingDirection.In:
                return (t) =>
                {
                    var p = 0.3f;
                    var s = p / 4;
                    return (float)(Math.Pow(2, -10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) + 1);
                };
            case EasingDirection.Out:
                return (t) =>
                {
                    var p = 0.3f;
                    var s = p / 4;
                    return (float)(Math.Pow(2, -10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) + 1);
                };
            case EasingDirection.InOut:
                return (t) =>
                {
                    var p = 0.45f;
                    var s = p / 4;
                    return (float)(t < 0.5 ? Math.Pow(2, 10 * (t - 1)) * Math.Sin((t - s) * (2 * Math.PI) / p) * 0.5 : Math.Pow(2, -10 * (t - 1)) * Math.Sin((t - s) * (2 * Math.PI) / p) * 0.5 + 1);
                };
            default:
                return (t) =>
                {
                    var p = 0.3f;
                    var s = p / 4;
                    return (float)(Math.Pow(2, -10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) + 1);
                };
        }
    }

    // bounce easing function (like that ball i found on the street)
    // ...okay maybe i didn't find it on the street but you get the idea
    private static Func<float, float> GetBounceEasingFunction(EasingDirection direction)
    {
        switch (direction)
        {
            case EasingDirection.In:
                return (t) =>
                {
                    var a = 0.3f;
                    var p = a / 4;
                    return (float)(1 - Math.Pow(2, -10 * t) * Math.Sin((t - p) * (2 * Math.PI) / a));
                };
            case EasingDirection.Out:
                return (t) =>
                {
                    var a = 0.3f;
                    var p = a / 4;
                    return (float)(Math.Pow(2, -10 * t) * Math.Sin((t - p) * (2 * Math.PI) / a) + 1);
                };
            case EasingDirection.InOut:
                return (t) =>
                {
                    var a = 0.45f;
                    var p = a / 4;
                    return (float)(t < 0.5 ? 1 - Math.Pow(2, -10 * (t * 2)) * Math.Sin((t * 2 - p) * (2 * Math.PI) / a) * 0.5 : Math.Pow(2, -10 * (t * 2 - 1)) * Math.Sin((t * 2 - p) * (2 * Math.PI) / a) * 0.5 + 1);
                };
            default:
                return (t) =>
                {
                    var a = 0.3f;
                    var p = a / 4;
                    return (float)(1 - Math.Pow(2, -10 * t) * Math.Sin((t - p) * (2 * Math.PI) / a));
                };
        }
    }
}

public static class AnimationManager
{
    private static List<Track> _animations = new List<Track>();

    public static void AddAnimation(Track animation)
    {
        _animations.Add(animation);
    }

    public static void Update(float deltaTime)
    {
        for (int i = 0; i < _animations.Count; i++)
        {
            var animation = _animations[i];
            animation.Update(deltaTime);
            if (animation.IsFinished)
            {
                _animations.RemoveAt(i);
                i--;
            }
        }
    }
}

public class Track
{
    // properties
    public Element? Element { get; }
    // in case we need to animate a screen
    public Screen? Screen { get; }
    public bool IsScreen { get; } = false; // no (currently)
    public Vector2 Destination { get; }
    public Func<float, float> EasingFunction { get; }
    public Vector2 DistancePerFrame { get; }
    public float Duration { get; }

    // start time
    private uint StartTime { get; set; }

    // are we finished
    public bool IsFinished { get; private set; }

    // constructor
    public Track(Element element, Vector2 destination, Func<float, float> easingFunction, Vector2 distancePerFrame, float duration)
    {
        // set the element
        Element = element;

        // set the destination
        Destination = destination;

        // set the easing function
        EasingFunction = easingFunction;

        // set the distance per frame
        DistancePerFrame = distancePerFrame;

        // set the duration
        Duration = duration;

        // set the start time
        StartTime = SDL_GetTicks();
    }

    // constructor but for screens
    public Track(Screen screen, Vector2 destination, Func<float, float> easingFunction, Vector2 distancePerFrame, float duration)
    {
        // set the element
        Screen = screen;

        // set the destination
        Destination = destination;

        // set the easing function
        EasingFunction = easingFunction;

        // set the distance per frame
        DistancePerFrame = distancePerFrame;

        // set the duration
        Duration = duration;

        // set the start time
        StartTime = SDL_GetTicks();

        // this is a screen
        IsScreen = true;
    }

    // update the animation
    public void Update(float deltaTime)
    {
        // BUT WAIT! is this a screen
        if (!IsScreen)
        {
            // get the current time
            var currentTime = SDL_GetTicks();

            // get the time elapsed
            var timeElapsed = (int)(currentTime - StartTime);

            // get the current position
            var currentPosition = Element.Position;

            // get the current distance
            var currentDistance = Destination - currentPosition;

            // get the current distance per frame
            var currentDistancePerFrame = DistancePerFrame;

            // get the current easing function
            var currentEasingFunction = EasingFunction;

            // get the current duration
            var currentDuration = Duration;

            // get the current progress
            var currentProgress = (float)timeElapsed / currentDuration;

            // get the current easing value
            var currentEasingValue = currentEasingFunction(currentProgress);

            // get the current distance
            var currentDistanceValue = currentDistancePerFrame * currentEasingValue;

            // set the current position
            Element.Position = currentPosition + currentDistanceValue;

            // check if the animation is finished
            if (timeElapsed >= currentDuration)
            {
                // set the position to the destination
                Element.Position = Destination;

                // set the animation as finished
                IsFinished = true;
            }
        }
        else // oh yeah this is a screen
        {
            // get the current time
            var currentTime = SDL_GetTicks();

            // get the time elapsed
            var timeElapsed = (int)(currentTime - StartTime);

            // get the current position
            var currentPosition = Screen.Position;

            // get the current distance
            var currentDistance = Destination - currentPosition;

            // get the current distance per frame
            var currentDistancePerFrame = DistancePerFrame;

            // get the current easing function
            var currentEasingFunction = EasingFunction;

            // get the current duration
            var currentDuration = Duration;

            // get the current progress
            var currentProgress = (float)timeElapsed / currentDuration;

            // get the current easing value
            var currentEasingValue = currentEasingFunction(currentProgress);

            // get the current distance
            var currentDistanceValue = currentDistancePerFrame * currentEasingValue;

            // set the current position
            Screen.Position = currentPosition + currentDistanceValue;

            // check if the animation is finished
            if (timeElapsed >= currentDuration)
            {
                // set the position to the destination
                Screen.Position = Destination;

                // set the animation as finished
                IsFinished = true;
            }
        }
    }
}