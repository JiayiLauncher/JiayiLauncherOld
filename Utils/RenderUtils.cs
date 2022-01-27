using System.Numerics;
using Secret.UI;
using static SDL2.SDL;
using static SDL2.SDL_ttf;
using static SDL2.SDL_image;

namespace Secret.Utils;

public static class RenderUtils
{
    private static CApp _app = Program.App; // this is a bit of a hack, but it works (too lazy to refactor)
    private static IntPtr _surface;
    private static IntPtr _textTexture;
    private static IntPtr _imgTexture;
    public static void DrawRect(Vector2 pos, Vector2 size, SDL_Color color)
    {
        SDL_Rect rect = new();
        rect.x = (int)pos.X;
        rect.y = (int)pos.Y;
        rect.w = (int)size.X;
        rect.h = (int)size.Y;
        SDL_SetRenderDrawColor(_app.Renderer, color.r, color.g, color.b, color.a);
        SDL_RenderFillRect(_app.Renderer, ref rect);
    }

    // i don't have outline rect :(

    public static void DrawText(Vector2 pos, string text, SDL_Color color, IntPtr font)
    {
        if (font == IntPtr.Zero) throw new Exception("Selected font returned NULL (0)");
        _surface = TTF_RenderText_Blended(font, text, color);
        _textTexture = SDL_CreateTextureFromSurface(_app.Renderer, _surface);
        SDL_Rect rect = new();
        SDL_Rect arg3 = new();

        SDL_QueryTexture(_textTexture, out _, out _, out arg3.w, out arg3.h);
        rect.x = (int)pos.X;
        rect.y = (int)pos.Y;
        rect.w = arg3.w;
        rect.h = arg3.h;
        
        SDL_RenderCopy(_app.Renderer, _textTexture, ref arg3, ref rect);
    }

    public static void DrawImage(string path)
    {
        _surface = IMG_Load(path);
        _imgTexture = SDL_CreateTextureFromSurface(_app.Renderer, _surface);
        SDL_QueryTexture(_imgTexture, out _, out _, out _, out _);
    }
}