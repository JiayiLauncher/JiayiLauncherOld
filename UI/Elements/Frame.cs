using Secret.Utils;
using System.Numerics;
using static SDL2.SDL;

namespace Secret.UI.Elements;

// frame: container for other elements (can have a border)
public class Frame : Element
{
    public bool Border { get; set; }
    public int BorderWidth { get; set; } = 1;

    // first element with sizing
    public Vector2 Size { get; set; }

    public Frame(Vector2 position, SDL_Color color, bool border = false, int borderWidth = 1) : base(position, color)
    {
        Border = border;
        BorderWidth = borderWidth; // not sure how to implement border width so we'll leave this for now

        // draw a filled rectangle, if we have a border then draw that after
        SDL_Rect rect = new();
        rect.x = (int)Position.X;
        rect.y = (int)Position.Y;
        rect.w = (int)Size.X;
        rect.h = (int)Size.Y;

        SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
        SDL_RenderFillRect(Renderer, ref rect);

        if (Border)
        {
            SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
            SDL_RenderDrawRect(Renderer, ref rect);
        }
    }
}