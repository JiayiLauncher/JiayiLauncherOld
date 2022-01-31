using JiayiLauncher.Utils;
using System.Numerics;
using static SDL2.SDL;

namespace JiayiLauncher.UI.Elements;

// frame: container for other elements (can have a border)
public class Frame : Element
{
    public bool Border { get; set; }
    public int BorderWidth { get; set; } = 1;
    public SDL_Color BorderColor { get; set; } = new SDL_Color();

    // first element with sizing
    public Vector2 Size { get; set; }
    SDL_Rect rect = new();

    // my children will grow strong
    public List<Element> Children { get; set; } = new();

    public Frame(Vector2 position, Vector2 size, SDL_Color color, bool border = false, SDL_Color borderColor = new(), int borderWidth = 1) : base(position, color)
    {
        Size = size;
        Border = border;
        BorderWidth = borderWidth; // not sure how to implement border width so we'll leave this for now
        BorderColor = borderColor;

        // draw a filled rectangle, if we have a border then draw that after

        rect.x = (int)RealPosition.X;
        rect.y = (int)RealPosition.Y;
        rect.w = (int)Size.X;
        rect.h = (int)Size.Y;
    }

    public override void OnRender()
    {
        // update real position by calling base.OnRender()
        base.OnRender();

        // proper rendering :)
        // draw the rectangle
        SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
        SDL_RenderFillRect(Renderer, ref rect);

        // draw the border
        if (Border)
        {
            SDL_SetRenderDrawColor(Renderer, BorderColor.r, BorderColor.g, BorderColor.b, BorderColor.a);
            SDL_RenderDrawRect(Renderer, ref rect);
        }
    }

    // add and remove elements
    public void Add(Element element)
    {
        Children.Add(element);
        // set parent
        element.Parent = this;
        // update its position
        element.UpdatePosition();
    }

    public void Remove(Element element)
    {
        Children.Remove(element);
        // set parent
        element.Parent = null;
        // update its position
        element.UpdatePosition();
    }
}