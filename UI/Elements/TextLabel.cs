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

    public TextLabel(Vector2 position, SDL_Color color, string text, IntPtr font) : base(position, color)
    {
        Text = text;
        Font = font;
        // refactoring text rendering, let's just put the code in DrawText here
        if (Font == IntPtr.Zero) throw new Exception("Selected font returned NULL (0)");
        _surface = TTF_RenderText_Blended(Font, Text, Color);
        _textTexture = SDL_CreateTextureFromSurface(Renderer, _surface);
        SDL_Rect rect = new();
        SDL_Rect arg3 = new();

        SDL_QueryTexture(_textTexture, out _, out _, out arg3.w, out arg3.h);
        rect.x = (int)Position.X;
        rect.y = (int)Position.Y;
        rect.w = arg3.w;
        rect.h = arg3.h;

        SDL_RenderCopy(Renderer, _textTexture, ref arg3, ref rect);
    }
}