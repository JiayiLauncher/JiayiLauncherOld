using System.Numerics;

namespace Secret.UI;

public class Element
{
    public Vector2 Position
    {
        get; set;
    }

    public Vector2 Size
    {
        get; set;
    }

    public Element? Child = null;

    public Element()
    {
        
    }
}