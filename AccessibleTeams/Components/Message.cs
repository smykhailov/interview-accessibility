using AccessibleTeams.Core;

namespace AccessibleTeams.Components
{
    internal class Message
    {
        public string MessageText { get; private set; }
        public IEnumerable<string> Replies { get; private set; }
        private readonly Input _replyInput;
        private readonly Button _replyButton;

        public Message(string msg, IEnumerable<string> rpls) { 
            MessageText = msg;
            Replies = rpls;
            _replyInput = new Input();
            _replyButton = new Button("Reply", false, false);
        }

        public void Render(byte top, byte left)
        {
            Renderer.RenderBlock(top, left, 70, 3);
            Console.CursorLeft = left + 2;
            Console.CursorTop = top + 1;
            Console.WriteLine(MessageText);

            Console.CursorLeft = left + 6;
            foreach (var r in Replies)
            {
                Console.CursorTop = top += 2;
                Renderer.RenderBlock(top, (byte)(left + 10), 60, 3);
                Console.CursorLeft = left + 12;
                Console.CursorTop = top + 1;
                Console.WriteLine(r);

            }

            _replyInput.Render((byte)(top + 2), (byte)(left + 10), 60, 3);
            _replyButton.Render((byte)(top + 2), (byte)(left + 61));
        }
    }
}
