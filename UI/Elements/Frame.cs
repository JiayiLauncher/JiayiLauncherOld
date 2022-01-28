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
    SDL_Rect rect = new();

    // my children will grow strong
    public List<Element> Children { get; set; } = new();

    public Frame(Vector2 position, SDL_Color color, bool border = false, int borderWidth = 1) : base(position, color)
    {
        Border = border;
        BorderWidth = borderWidth; // not sure how to implement border width so we'll leave this for now

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

        if (Border)
        {
            SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
            SDL_RenderDrawRect(Renderer, ref rect);
        }
    }

    // add and remove elements
    public void Add(Element element)
    {
        Children.Add(element);
        // set parent
        element.Parent = this;
    }

    public void Remove(Element element)
    {
        Children.Remove(element);
        // set parent
        element.Parent = null;
    }
}