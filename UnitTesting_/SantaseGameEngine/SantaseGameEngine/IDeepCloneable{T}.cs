namespace SantaseGameEngine
{
    public interface IDeepCloneable<out T>
    {
        T DeepClone();
    }
}