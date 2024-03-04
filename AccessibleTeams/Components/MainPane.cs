using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class MainPane
    {
        private readonly TabBar _tabBar;
        private readonly IEnumerable<Message> _messages;
        private readonly Input _startThreadInput;
        private readonly Button _sendButton;

        public string Title { get; private set; }

        public MainPane(string title)
        {
            Title = title;

            _tabBar = new TabBar();
            _messages = new List<Message>()
            {
                new Message("Msg 1: Lorem ipsum", ["Reply 1", "Reply 2"]),
                new Message("Msg 2: Lorem ipsum", []),
            };
            _startThreadInput = new Input();
            _sendButton = new Button("Send", false, false);
        }

        public void Render()
        {
            Renderer.RenderBlock(0, 23, 80, 24);

            Console.CursorLeft = 25;
            Console.CursorTop = 1;
            Console.WriteLine(Title);

            _tabBar.Render();
            byte top = 5;
            foreach (var message in _messages)
            {
                message.Render(top, 28);
                top += (byte)(message.Replies.Count() * 3 + 3);
            }

            _startThreadInput.Render(20, 28, 70, 3);
            _sendButton.Render(20, 90);
        }
    }
}
