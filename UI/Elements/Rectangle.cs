using System.Numerics;
using static SDL2.SDL;

namespace Secret.UI.Elements;

// rectangle: rectangle
// ...yeah that's about it
public class Rectangle : Element
{
    public Vector2 Size { get; set; }

    private SDL_Rect _rect = new();

    public Rectangle(Vector2 position, Vector2 size, SDL_Color color) : base(position, color)
    {
        Size = size;

        _rect.x = (int)Position.X;
        _rect.y = (int)Position.Y;
        _rect.w = (int)Size.X;
        _rect.h = (int)Size.Y;
    }

    // override UpdatePosition
    public override void UpdatePosition()
    {
        // update real position by calling base.UpdatePosition()
        base.UpdatePosition();

        // update the rectangle
        _rect.x = (int)RealPosition.X;
        _rect.y = (int)RealPosition.Y;
        _rect.w = (int)Size.X;
        _rect.h = (int)Size.Y;
    }

    public override void OnRender()
    {
        // update
        UpdatePosition();

        // render
        SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
        SDL_RenderFillRect(Renderer, ref _rect);
    }
}