using static SDL2.SDL;
using static SDL2.SDL_ttf;
using static SDL2.SDL_image;
using JiayiLauncher.Utils;
using System.Numerics;
using JiayiLauncher.UI;
using JiayiLauncher.UI.Elements;
using JiayiLauncher.Screens;

namespace JiayiLauncher;

public class CApp
{
    public bool Running;

    public IntPtr Window;
    public IntPtr Renderer;
    public IntPtr GLContext;

    private SDL_Color color;
    private SDL_Color color2;
    private SDL_Color yellow;

    public static List<Element> Elements = new();

    // delta time stuff
    private ulong now;
    private ulong last;

    public CApp()
    {
        Window = IntPtr.Zero;
        Running = true;
        color = new SDL_Color();
        color.r = 255;
        color.g = 0;
        color.b = 0;
        color.a = 255;

        color2 = new SDL_Color();
        color2.r = 30;
        color2.g = 30;
        color2.b = 30;
        color2.a = 255;

        yellow = new SDL_Color();
        yellow.r = 255;
        yellow.g = 255;
        yellow.b = 0;
        yellow.a = 255;
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

            // calculate delta time
            last = now;
            now = SDL_GetPerformanceCounter();

            Common.DeltaTime = (double)((now - last) * 1000 / SDL_GetPerformanceFrequency());

            OnLoop();
            OnRender();

            //SDL_Delay(16);
        }

        OnCleanup();
    }

    public bool OnInit()
    {
        if (SDL_Init(SDL_INIT_VIDEO) < 0) return false;
        if (TTF_Init() < 0) return false;
        if (IMG_Init(IMG_InitFlags.IMG_INIT_PNG | IMG_InitFlags.IMG_INIT_JPG) < 0) return false;

        Window = SDL_CreateWindow
            ("Jiayi Launcher", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, 900, 550, SDL_WindowFlags.SDL_WINDOW_OPENGL);
        if (Window == IntPtr.Zero) return false;

        SDL_SetHint(SDL_HINT_RENDER_SCALE_QUALITY, "linear");

        Renderer = SDL_CreateRenderer
            (Window, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED | SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
        if (Renderer == IntPtr.Zero) return false;

        // colors!
        Colors.InitColors();

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

        // now is a very good time to update the animations
        AnimationManager.Update((float)Common.DeltaTime);

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