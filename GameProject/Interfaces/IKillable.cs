namespace GameProject.Interfaces
{
    public interface IKillable
    {
        int Health { get; set; }

        bool CheckIfKilled();
    }
}