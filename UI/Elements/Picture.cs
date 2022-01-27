using Secret.Utils;
using System.Numerics;
using static SDL2.SDL;
using static SDL2.SDL_image;

namespace Secret.UI.Elements;

// picture: exactly what it sounds like
public class Picture : Element
{
    public string Path { get; set; }

    // SDL stuff, again
    private IntPtr _surface;
    private IntPtr _texture;

    public Picture(Vector2 position, string path) : base(position, new SDL_Color())
    {
        Path = path;
        // refactoring this too
        _surface = IMG_Load(Path);
        _texture = SDL_CreateTextureFromSurface(Renderer, _surface);
        SDL_Rect rect = new();
        SDL_Rect arg3 = new();

        SDL_QueryTexture(_texture, out _, out _, out arg3.w, out arg3.h);
        rect.x = (int)Position.X;
        rect.y = (int)Position.Y;
        rect.w = arg3.w;
        rect.h = arg3.h;

        SDL_RenderCopy(Renderer, _texture, ref arg3, ref rect);
    }
}