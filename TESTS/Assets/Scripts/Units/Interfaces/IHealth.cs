namespace Units.Interfaces
{
    public interface IHealth
    {
        int Health { get; set; }
        void GetDamage(int damage);
    }
}