using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class Input
    {
        public void Render(byte top, byte left, byte width, byte height)
        {
            Renderer.RenderBlock(top, left, width, height);
        }
    }
}
