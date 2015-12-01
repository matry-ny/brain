namespace BrainConsoleApp.OOP
{
    public static class VideoPortsCollectionExtensions
    {
        public static bool TryGetPort(this VideoPortsCollection collection, string name, out VideoPort port)
        {
            port = default(VideoPort);
            for (int index = 0; index < collection.Count; index++)
            {
                var item = collection[index];
                if (item.Name == name)
                {
                    port = item;
                    return true;
                }
            }

            return false;
        }
    }
}