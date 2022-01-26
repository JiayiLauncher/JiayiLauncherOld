using static SDL2.SDL_ttf;

namespace Secret.Utils;

public static class Fonts
{
    public static IntPtr MontserratBlack(int size) => TTF_OpenFont("/home/carlton/Secret/Assets/Fonts/Montserrat-BlackItalic.ttf", size);
    public static IntPtr MontserratBlackItalic(int size) => TTF_OpenFont("Montserrat-BlackItalic.ttf", size);

}