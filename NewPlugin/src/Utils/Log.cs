namespace NewPlugin
{
    public class Log
    {
        private string name;

        public Log(string name)
        {
            this.name = name;
        }

        public void Error(string message)
        {
            SuperController.LogError($"{nameof(NewPlugin)}.{name}: {message}");
        }

        public void Message(string message)
        {
            SuperController.LogMessage($"{nameof(NewPlugin)}.{name}: {message}");
        }
    }
}
