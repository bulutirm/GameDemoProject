using GameDemoProject.CampaignOption.Concrete;
using GameDemoProject.CampaignOption.Entitiy;
using GameDemoProject.OrderOption.Concrete;
using GameDemoProject.OrderOption.Entity;
using GameDemoProject.PlayerOptions.Concrete;
using GameDemoProject.PlayerOptions.Entities;

namespace GameDemoProject
{
    class Program
    { 

        public static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "Irem";
            player.LastName = "Bulut";
            player.NationalityId = "12345678910";
            player.BirthDate = new System.DateTime(2002, 4, 6);
            player.NickName = "bulutirm";
           
            PlayerManager playerManager = new PlayerManager();
            playerManager.Save(player);
            playerManager.Update(player);
            playerManager.Delete(player);

            Order order = new Order();
            order.Id = 1;
            order.FirstName = "Irem";
            order.LastName = "Bulut";
            order.NationalityId = "12345678910";
            order.BirthDate = new System.DateTime(2002, 4, 6);

            OrderManager orderManager = new OrderManager();
            orderManager.Add(order);
            orderManager.Verify(order);

            Campaigner campaigner = new Campaigner();
            campaigner.Id = 1;
            campaigner.FirstName = "Irem";
            campaigner.LastName = "Bulut";
            campaigner.NationalityId = "12345678910";
            campaigner.BirthDate = new System.DateTime(2002, 4, 6);


            CampaignerManager campaignerManager = new CampaignerManager();
            campaignerManager.Add(campaigner);
            campaignerManager.Update(campaigner);
            campaignerManager.Delete(campaigner);

        }
    }
}
