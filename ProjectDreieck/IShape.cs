namespace ProjectDreieck
{
    public interface IShape
    {
        void SetSides(int?[] _sides);
        int?[] GetSides();
        string GetName();
    }
}
