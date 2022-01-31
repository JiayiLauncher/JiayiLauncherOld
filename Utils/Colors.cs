using static SDL2.SDL;

// static class for all of the colors we need so we don't have to create them every time
namespace JiayiLauncher.Utils
{
    public static class Colors
    {
        public static SDL_Color Background = new();
        public static SDL_Color Text = new();
        public static SDL_Color Button = new();
        public static SDL_Color Layer1 = new();

        // shadow colors for each layer
        public static SDL_Color BackgroundShadow = new();
        public static SDL_Color Layer1Shadow = new();

        // gray color for less important text
        public static SDL_Color Gray = new();

        public static void InitColors()
        {
            Background.r = 12;
            Background.g = 12;
            Background.b = 12;
            Background.a = 255;

            Text.r = 255;
            Text.g = 255;
            Text.b = 255;
            Text.a = 255;

            Button.r = 255;
            Button.g = 0;
            Button.b = 0;
            Button.a = 255;

            Layer1.r = 30;
            Layer1.g = 30;
            Layer1.b = 30;
            Layer1.a = 255;

            BackgroundShadow.r = 5;
            BackgroundShadow.g = 5;
            BackgroundShadow.b = 5;
            BackgroundShadow.a = 255;

            Layer1Shadow.r = 10;
            Layer1Shadow.g = 10;
            Layer1Shadow.b = 10;
            Layer1Shadow.a = 255;

            Gray.r = 100;
            Gray.g = 100;
            Gray.b = 100;
            Gray.a = 255;
        }
    }
}