using System.Numerics;
using static SDL2.SDL;

namespace Secret.UI;

public class Element
{
    // basic properties for a UI element
    public Vector2 Position { get; set; }
    public SDL_Color Color;

    // we want to inherit position from the parent so here's a property for that (this can be null!)
    public Element? Parent { get; set; }

    // the REAL position (this is calculated by the parent)
    internal Vector2 RealPosition { get; private set; }

    // hacking again because Program.App.Renderer is pretty long
    internal IntPtr Renderer = Program.App.Renderer;

    // constructor
    public Element(Vector2 position, SDL_Color color)
    {
        Position = position;
        Color = color;

        // add to list of elements
        CApp.Elements.Add(this);
        UpdatePosition();
    }

    public virtual void UpdatePosition()
    { 
        // if we have a parent, we need to calculate the real position
        if (Parent != null)
            RealPosition = Parent.RealPosition + Position;
        else
            RealPosition = Position;
    }

    // event!!!
    public virtual void OnEvent(SDL_Event e) { }

    // i found out how to properly render so here's a render event
    public virtual void OnRender()
    {
        // update
        UpdatePosition();
    }
}