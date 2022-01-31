using JiayiLauncher.Utils;
using System.Numerics;
using static SDL2.SDL;
using static SDL2.SDL_ttf;

namespace JiayiLauncher.UI.Elements;

// redoing the button code because it didn't work before
// button: has a text label and a click event
public class Button : Element
{
    public string Text { get; set; }
    public IntPtr Font { get; set; }
    public Vector2 Size { get; set; }
    public SDL_Color TextColor;

    // SDL stuff
    private IntPtr _surface;
    private IntPtr _textTexture;

    // rectangles
    SDL_Rect _rect = new();
    SDL_Rect _rect2 = new();

    SDL_Rect _buttonRect = new();

    // button states
    public bool IsHovered { get; private set; }
    public bool IsPressed { get; private set; }

    // colors for the states
    SDL_Color _hoverColor = new();
    SDL_Color _pressedColor = new();

    // keep the default color somewhere for later
    SDL_Color _defaultColor = new();

    public Button(Vector2 position, Vector2 size, string text, IntPtr font, SDL_Color color, SDL_Color textColor) : base(position, color)
    {
        Text = text;
        Font = font;
        Size = size;
        TextColor = textColor;

        // set the button states colors depending on the default color
        _hoverColor = new SDL_Color();
        _pressedColor = new SDL_Color();

        // hover is a bit lighter than the default color
        _hoverColor.r = (byte)(color.r + (255 - color.r) / 2.5);
        _hoverColor.g = (byte)(color.g + (255 - color.g) / 2.5);
        _hoverColor.b = (byte)(color.b + (255 - color.b) / 2.5);
        _hoverColor.a = color.a;

        // pressed is a bit darker than the default color
        _pressedColor.r = (byte)(color.r / 2.5);
        _pressedColor.g = (byte)(color.g / 2.5);
        _pressedColor.b = (byte)(color.b / 2.5);
        _pressedColor.a = color.a;

        // default is uhhhh... default
        _defaultColor = color;

        // init
        // a rectangle for the button
        _buttonRect.x = (int)RealPosition.X;
        _buttonRect.y = (int)RealPosition.Y;
        _buttonRect.w = (int)size.X;
        _buttonRect.h = (int)size.Y;

        // init text and put the text in the middle of the rectangle
        if (Font == IntPtr.Zero) throw new Exception("Selected font returned NULL (0)");
        _surface = TTF_RenderText_Blended(Font, Text, TextColor);
        _textTexture = SDL_CreateTextureFromSurface(Renderer, _surface);

        SDL_QueryTexture(_textTexture, out _, out _, out _rect2.w, out _rect2.h);

        // center the text
        _rect.x = (int)RealPosition.X + ((int)size.X - _rect2.w) / 2;
        _rect.y = (int)RealPosition.Y + ((int)size.Y - _rect2.h) / 2;
        _rect.w = _rect2.w;
        _rect.h = _rect2.h;
    }

    // override UpdatePosition
    public override void UpdatePosition()
    {
        // update real position by calling base.UpdatePosition()
        base.UpdatePosition();

        // update the button rectangle
        _buttonRect.x = (int)RealPosition.X;
        _buttonRect.y = (int)RealPosition.Y;
        _buttonRect.w = (int)Size.X;
        _buttonRect.h = (int)Size.Y;

        // center the text
        _rect.x = (int)RealPosition.X + ((int)Size.X - _rect2.w) / 2;
        _rect.y = (int)RealPosition.Y + ((int)Size.Y - _rect2.h) / 2;
        _rect.w = _rect2.w;
        _rect.h = _rect2.h;
    }

    public override void OnRender()
    {
        // update
        UpdatePosition();

        // update button color depending on button states
        if (IsHovered)
        {
            Color = _hoverColor;
        }
        else if (IsPressed)
        {
            Color = _pressedColor;
        }
        else
        {
            Color = _defaultColor;
        }
        // proper rendering :)
        // draw the rectangle
        SDL_SetRenderDrawColor(Renderer, Color.r, Color.g, Color.b, Color.a);
        SDL_RenderFillRect(Renderer, ref _buttonRect);

        // draw the text
        SDL_RenderCopy(Renderer, _textTexture, ref _rect2, ref _rect);
    }

    public event EventHandler Click;

    public override void OnEvent(SDL_Event e)
    {
        base.OnEvent(e);

        if (e.type == SDL_EventType.SDL_MOUSEBUTTONUP)
        {
            if (IsPressed && Common.IsMouseInside(RealPosition, Size, e))
            {
                IsPressed = false;
                IsHovered = true;
                Click?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                IsPressed = false;
                IsHovered = false;
            }
        }
        else if (e.type == SDL_EventType.SDL_MOUSEBUTTONDOWN)
        {
            if (Common.IsMouseInside(RealPosition, Size, e))
            {
                IsPressed = true;
                IsHovered = false;
            }
        }
        else if (e.type == SDL_EventType.SDL_MOUSEMOTION)
        {
            IsHovered = IsPressed ? false : Common.IsMouseInside(RealPosition, Size, e);
        }
    }
}