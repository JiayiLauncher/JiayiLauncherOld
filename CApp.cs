using static SDL2.SDL;
using static SDL2.SDL_ttf;
using static SDL2.SDL_image;
using Secret.Utils;
using System.Numerics;
using Secret.UI;
using Secret.UI.Elements;

namespace Secret;

public class CApp
{
    public bool Running
    {
        get; private set;
    }

    public IntPtr Window;
    public IntPtr Renderer;

    private SDL_Color color;

    public static List<Element> Elements = new();

    public CApp()
    {
        Window = IntPtr.Zero;
        Running = true;
        color = new SDL_Color();
        color.r = 255;
        color.g = 0;
        color.b = 0;
        color.a = 255;
    }

    public void OnExecute()
    {
        if (OnInit() == false)
            throw new Exception("Failed to initialize SDL: " + SDL_GetError());

        // here's a text label, it wants to say hi
        var textLabel = new TextLabel(new Vector2(100, 100), color, "Hello World!", Fonts.MontserratBlack(20));

        // here's a button, it wants the console to say hi when clicked
        var button = new Button(new Vector2(100, 200), new Vector2(150, 50), "Click me!", Fonts.MontserratBlack(20), color);
        button.Click += (sender, e) => Console.WriteLine("Hello World!");

        // some guy wanted a text label to say "sex" so here
        var textLabel2 = new TextLabel(new Vector2(300, 100), color, "sex", Fonts.MontserratBold(12));

        SDL_Event cool;

        while (Running)
        {
            while (SDL_PollEvent(out cool) == 1) // true
            {
                OnEvent(cool);
            }

            OnLoop();
            OnRender();

            SDL_Delay(16);
        }

        OnCleanup();
    }

    public bool OnInit()
    {
        if (SDL_Init(SDL_INIT_EVERYTHING) < 0) return false;
        if (TTF_Init() < 0) return false;
        if (IMG_Init(IMG_InitFlags.IMG_INIT_PNG) < 0) return false;

        Window = SDL_CreateWindow
            ("Jiayi Launcher", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, 900, 550, SDL_WindowFlags.SDL_WINDOW_OPENGL);
        if (Window == IntPtr.Zero) return false;

        SDL_SetHint(SDL_HINT_RENDER_SCALE_QUALITY, "linear");

        Renderer = SDL_CreateRenderer(Window, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        if (Renderer == IntPtr.Zero) return false;

        return true;
    }

    public void OnEvent(SDL_Event eventt)
    {
        // respond to close event
        if (eventt.type == SDL_EventType.SDL_QUIT)
            Running = false;

        foreach (var element in Elements)
        {
            element.OnEvent(eventt);
        }
    }

    public void OnLoop()
    {
        SDL_SetRenderDrawColor(Renderer, 15, 15, 15, 255);
        SDL_RenderClear(Renderer);

        // here come the elements, they like to render things
        foreach (var element in Elements)
        {
            element.OnRender();
        }
    }

    public void OnRender()
    {
        SDL_RenderPresent(Renderer);
    }

    public void OnCleanup()
    {
        TTF_Quit();
        IMG_Quit();
        SDL_Quit();
    }
}