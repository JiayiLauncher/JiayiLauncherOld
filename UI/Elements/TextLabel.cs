using Secret.Utils;
using System.Numerics;
using static SDL2.SDL;

namespace Secret.UI.Elements;

// label: it just draws text
public class TextLabel : Element
{
    public string Text { get; set; }
    public IntPtr Font { get; set; }

    public TextLabel(Vector2 position, SDL_Color color, string text, IntPtr font) : base(position, color)
    {
        Text = text;
        Font = font;
        RenderUtils.DrawText(RealPosition, Text, Color, Font);
    }
}