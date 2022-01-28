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

    SDL_Rect rect = new();
    SDL_Rect arg3 = new();

    public Picture(Vector2 position, string path) : base(position, new SDL_Color())
    {
        // make the path start at the current directory
        Path = $"{Directory.GetCurrentDirectory()}/Assets/Images/{path}";

        // initialize!
        _surface = IMG_Load(Path);
        _texture = SDL_CreateTextureFromSurface(Renderer, _surface);

        SDL_QueryTexture(_texture, out _, out _, out arg3.w, out arg3.h);

        rect.x = (int)Position.X;
        rect.y = (int)Position.Y;
        rect.w = arg3.w;
        rect.h = arg3.h;

        // print the path
        Console.WriteLine(Path);
    }

    // override UpdatePosition
    public override void UpdatePosition()
    {
        // update real position by calling base.UpdatePosition()
        base.UpdatePosition();

        // update the picture rectangle
        rect.x = (int)RealPosition.X;
        rect.y = (int)RealPosition.Y;
        rect.w = arg3.w;
        rect.h = arg3.h;
    }

    public override void OnRender()
    {
        // you know the drill
        UpdatePosition();

        SDL_RenderCopy(Renderer, _texture, ref arg3, ref rect);
    }
}