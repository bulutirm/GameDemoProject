using System;
using System.Collections.Generic;
using GameDemoProject.PlayerOptions.Abstract;
using GameDemoProject.PlayerOptions.Entities;

namespace GameDemoProject.PlayerOptions.Concrete
{
    public class PlayerManager : IPlayerService
    {
        Player register = new Player();

        public void Delete(Player player)
        {
          
            Console.WriteLine("The player was deleted: " +player.NickName);

        }

        public void Save(Player player)
        {
          
            Console.WriteLine("The player was added: " +player.NickName);

        }

        public void Update(Player player)
        {
            Console.WriteLine("The player was updated: " +player.NickName);

        }

        public void Verify(Player player)
        {
            Console.WriteLine("The player was verified: " +player.NickName);
        }
    }
}
