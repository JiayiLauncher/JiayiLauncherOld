using Secret.Utils;
using System.Numerics;
using static SDL2.SDL;
using static SDL2.SDL_ttf;

namespace Secret.UI.Elements;

// label: it just draws text
public class TextLabel : Element
{
    public string Text { get; set; }
    public IntPtr Font { get; set; }

    // SDL stuff
    private IntPtr _surface;
    private IntPtr _textTexture;

    // rectangles
    SDL_Rect _rect = new();
    SDL_Rect _rect2 = new();

    public TextLabel(Vector2 position, SDL_Color color, string text, IntPtr font) : base(position, color)
    {
        Text = text;
        Font = font;

        // init
        if (Font == IntPtr.Zero) throw new Exception("Selected font returned NULL (0)");
        _surface = TTF_RenderText_Blended(Font, Text, Color);
        _textTexture = SDL_CreateTextureFromSurface(Renderer, _surface);

        SDL_QueryTexture(_textTexture, out _, out _, out _rect2.w, out _rect2.h);
        _rect.x = (int)RealPosition.X;
        _rect.y = (int)RealPosition.Y;
        _rect.w = _rect2.w;
        _rect.h = _rect2.h;
    }

    public override void OnRender()
    {
        // update real position by calling base.OnRender()
        base.OnRender();

        // proper rendering :)
        SDL_RenderCopy(Renderer, _textTexture, ref _rect2, ref _rect);
    }
}