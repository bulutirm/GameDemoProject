using GameDemoProject.PlayerOptions.Entities;

namespace GameDemoProject.PlayerOptions.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);

        void Update(Player player);

        void Delete(Player player);

        void Verify(Player player);

    }
}
