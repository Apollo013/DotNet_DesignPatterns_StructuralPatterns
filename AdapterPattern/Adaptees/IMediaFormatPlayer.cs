namespace AdapterPattern.Adaptees
{
    interface IMediaFormatPlayer
    {
        string Name { get; }
        void Play(string fileName);
    }
}
