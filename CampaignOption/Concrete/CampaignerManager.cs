using System;
using GameDemoProject.CampaignOption.Abstract;
using GameDemoProject.CampaignOption.Entitiy;

namespace GameDemoProject.CampaignOption.Concrete
{
    public class CampaignerManager : ICampaignerService
    {
      
        public void Add(Campaigner campaigner)
        {
            Console.WriteLine("The campaigne was added.");
          
        }

    
        public void Delete(Campaigner campaigner)
        {
            Console.WriteLine("The campaigne was deleted.");
        }

      
        public void Update(Campaigner campaigner)
        {
            Console.WriteLine("The campaigne was updated.");
        }
    }
}
