namespace NewPlugin
{
    public static class Log
    {
        public static void Error(string message, string name = nameof(Script))
        {
            SuperController.LogError($"{nameof(NewPlugin)}.{name}: {message}");
        }

        public static void Message(string message, string name = nameof(Script))
        {
            SuperController.LogMessage($"{nameof(NewPlugin)}.{name}: {message}");
        }
    }
}
