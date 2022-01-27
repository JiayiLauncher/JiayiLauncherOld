using Secret.Utils;
using System.Numerics;
using static SDL2.SDL;
using static SDL2.SDL_ttf;

namespace Secret.UI.Elements;

// button: do i have to explain this?
public class Button : Element
{
    public string Text { get; set; }
    public IntPtr Font { get; set; }
    public SDL_Color FontColor;
    public SDL_Color HoverColor;
    public SDL_Color ClickColor;
    public bool Clicked { get; set; }
    public bool Hover { get; set; }
    public bool Enabled { get; set; } = true;
    public Vector2 Size { get; set; }

    // SDL
    private IntPtr _surface;
    private IntPtr _textTexture;

    // event!
    public event EventHandler<EventArgs> Click;

    public Button(Vector2 position, Vector2 size, string text, IntPtr font) : base(position, new SDL_Color())
    {
        // alright let's do this
        Text = text;
        Font = font;
    
        // white text
        FontColor = new SDL_Color();
        FontColor.r = 255;
        FontColor.g = 255;
        FontColor.b = 255;
        FontColor.a = 255;

        // red will be default color
        Color = new SDL_Color();
        Color.r = 255;
        Color.g = 0;
        Color.b = 0;
        Color.a = 255;

        // hover color is a bit lighter than the default color
        HoverColor = new SDL_Color();
        HoverColor.r = 255;
        HoverColor.g = 20;
        HoverColor.b = 20;
        HoverColor.a = 255;

        // clicked color is a bit darker than the default color
        ClickColor = new SDL_Color();
        ClickColor.r = 200;
        ClickColor.g = 0;
        ClickColor.b = 0;
        ClickColor.a = 255;

        // rendering time
        // draw a filled rectangle
        SDL_Rect rect = new();
        rect.x = (int)Position.X;
        rect.y = (int)Position.Y;
        rect.w = (int)Size.X;
        rect.h = (int)Size.Y;

        // change color depending on the button's state
        if (Hover)
        {
            SDL_SetRenderDrawColor(Renderer, HoverColor.r, HoverColor.g, HoverColor.b, HoverColor.a);
        }
        else if (Clicked)
        {
            SDL_SetRenderDrawColor(Renderer, ClickColor.r, ClickColor.g, ClickColor.b, ClickColor.a);
        }
        else
        {
            SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
        }

        SDL_RenderFillRect(Renderer, ref rect);

        // text rendering
        if (Font == IntPtr.Zero) throw new Exception("Selected font returned NULL (0)");
        _surface = TTF_RenderText_Blended(Font, Text, FontColor);
        _textTexture = SDL_CreateTextureFromSurface(Renderer, _surface);
        SDL_Rect rect2 = new();
        SDL_Rect arg3 = new();

        SDL_QueryTexture(_textTexture, out _, out _, out arg3.w, out arg3.h);
        rect2.x = (int)Position.X + (int)(Size.X / 2) - (arg3.w / 2);
        rect2.y = (int)Position.Y + (int)(Size.Y / 2) - (arg3.h / 2);
        rect2.w = arg3.w;
        rect2.h = arg3.h;

        SDL_RenderCopy(Renderer, _textTexture, ref arg3, ref rect2);
    }

    public override void OnEvent(SDL_Event e)
    {
        if (Common.IsMouseInside(Position, Size, e))
        {
            if (e.type == SDL_EventType.SDL_MOUSEMOTION)
            {
                Hover = true;
            }
            else if (e.type == SDL_EventType.SDL_MOUSEBUTTONDOWN)
            {
                Clicked = true;
                Click?.Invoke(this, EventArgs.Empty);
            }
        }
        else
        {
            Hover = false;
            Clicked = false;
        }
    }
}