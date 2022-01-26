using static SDL2.SDL;
using static SDL2.SDL_ttf;
using Secret.Utils;
using System.Numerics;

namespace Secret;

public class CApp
{
    public bool Running
    {
        get; private set;
    }

    public RenderUtils RenderUtils;

    public IntPtr Window;
    public IntPtr Renderer;

    private SDL_Color color;

    public CApp()
    {
        Window = IntPtr.Zero;
        Running = true;
        RenderUtils = new(this);
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
        if (eventt.type == SDL_EventType.SDL_QUIT) Running = false;


    }

    public void OnLoop()
    {
        SDL_SetRenderDrawColor(Renderer, 15, 15, 15, 255);
        SDL_RenderClear(Renderer);
        RenderUtils.DrawText(new Vector2(0, 0), "cool text", color, Fonts.MontserratBlack(30));
    }

    public void OnRender()
    {
        SDL_RenderPresent(Renderer);
    }

    public void OnCleanup()
    {
        SDL_Quit();
    }
}