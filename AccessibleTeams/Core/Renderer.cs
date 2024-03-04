namespace AccessibleTeams.Core
{
    internal static class Renderer
    {
        internal static void RenderBlock(byte top, byte left, byte width, byte height)
        {
            if (width < 2 || height < 2)
            {
                throw new ArgumentException("Width and height must be at least 2");
            }

            Console.CursorTop = top;
            Console.CursorLeft = left;
            var horizontalLine = new string('─', width - 2);
            Console.WriteLine($"┌{horizontalLine}┐");
            for (var i = 0; i < height - 2; i++)
            {
                Console.CursorLeft = left;
                Console.WriteLine($"|{new string(' ', width - 2)}|");
            }
            Console.CursorLeft = left;
            Console.WriteLine($"└{horizontalLine}┘");
        }

        internal static void RenderButton(byte top, byte left, string title, bool IsFocused = false)
        {
            if (IsFocused)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            RenderBlock(top, left, (byte)(title.Length + 4), 3);
            Console.CursorTop = top + 1;
            Console.CursorLeft = left + 2;
            Console.WriteLine(title);
        }
    }
}
