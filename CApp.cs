using static SDL2.SDL;
using Secret.Utils;

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

    public CApp()
    {
        Window = IntPtr.Zero;
        Running = true;
        RenderUtils = new(this);
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