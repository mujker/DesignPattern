namespace Observer.Interface
{
    public interface IWeatherable
    {
        void AddObser(IObserable obser);
        void RemoveObser(IObserable obser);
        void NotifyObser(IObserable obser);
    }
}
