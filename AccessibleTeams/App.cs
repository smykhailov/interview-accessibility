using AccessibleTeams.Components;

namespace AccessibleTeams
{
    internal class App
    {
        private readonly AppBar _appBar;
        private readonly Teams _teams;
        private readonly MainPane _mainPane;

        public App() { 
            _appBar = new AppBar();
            _teams = new Teams();
            _mainPane = new MainPane("Teams 1 / Channel 2");
        }

        public void Run() {
            _appBar.Render();
            _teams.Render();
            _mainPane.Render();

            Console.CursorLeft = 0;
            Console.CursorTop = 30;
        }
    }
}
