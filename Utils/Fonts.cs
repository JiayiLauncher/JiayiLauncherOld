using static SDL2.SDL_ttf;

namespace Secret.Utils;

public static class Fonts
{
    // Montserrat is my favorite font
    public static IntPtr MontserratBlack(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-Black.ttf", size);
    public static IntPtr MontserratBlackItalic(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-BlackItalic.ttf", size);
    public static IntPtr MontserratBold(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-Bold.ttf", size);
    public static IntPtr MontserratBoldItalic(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-BoldItalic.ttf", size);
    public static IntPtr MontserratExtraBold(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-ExtraBold.ttf", size);
    public static IntPtr MontserratExtraBoldItalic(int size) => TTF_OpenFont(Directory.GetCurrentDirectory() + "/Assets/Fonts/Montserrat-ExtraBoldItalic.ttf", size);
}