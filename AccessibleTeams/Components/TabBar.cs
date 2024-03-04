using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class TabBar
    {
        private readonly IEnumerable<Button> _actions;

        public TabBar()
        {
            _actions = new List<Button>
            {
                new Button("Messages", true, false),
                new Button("Files", false, false),
                new Button("+", false, false),
            };
        }

        public void Render()
        {
            Renderer.RenderBlock(2, 24, 78, 3);

            byte left = 24;
            foreach (var action in _actions)
            {
                action.Render(2, left);
                left += (byte)((byte)action.Text.Length + 4);
            }
        }
    }
}
