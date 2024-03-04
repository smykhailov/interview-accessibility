using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class Teams
    {
        private readonly string[] teamsTree = [
            "Team 1", 
            "  Channel 1", 
            "  \x1b[31mChannel 2\x1b[0m", 
            "  Channel 3", 
            "Team 2", 
            "  Channel 1", 
            "  Channel 2"
        ];

        public void Render()
        {
            Renderer.RenderBlock(0, 5, 19, 24);

            Console.CursorTop = 1;
            for (int i = 0; i < teamsTree.Length; i++)
            {
                Console.CursorLeft = 8;
                Console.WriteLine(teamsTree[i]);
            }

            Renderer.RenderButton(20, 7, "Create Team");
        }
    }
}
