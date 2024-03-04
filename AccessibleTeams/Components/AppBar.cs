using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class AppBar
    {
        private readonly IEnumerable<Button> _actions;

        public AppBar()
        {
            _actions = new List<Button>
            {
                new Button("Activity"),
                new Button("Teams", true),
                new Button("Chats"),
                new Button("Files"),
            };
        }

        public void Render()
        {
            Renderer.RenderBlock(0, 0, 5, 24);

            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            byte top = 0;
            foreach (var action in _actions)
            {
                action.Render(top, 0);
                top += 3;
            }
        }
    }
}
