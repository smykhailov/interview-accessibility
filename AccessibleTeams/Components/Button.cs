using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class Button
    {
        public string Text { get; private set; }
        public bool IsFocused { get; set; }
        public bool IsFirstLetterOnly { get; set; }

        public Button(string text, bool isFocused = false, bool isFirstLetterOnly = true) { 
            Text = text;
            IsFocused = isFocused;
            IsFirstLetterOnly = isFirstLetterOnly;
        }

        public void Click()
        {
            Console.WriteLine($"Button {Text} clicked");
        }

        public void Render(byte top, byte left)
        {
            Renderer.RenderButton(top, left, IsFirstLetterOnly ? Text.First().ToString() : Text, IsFocused);
        }
    }
}
