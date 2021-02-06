using System;
using GameDemoProject.CampaignOption.Entitiy;

namespace GameDemoProject.CampaignOption.Abstract
{
    public interface ICampaignerService
    {
        void Add(Campaigner campaigner);
        void Delete(Campaigner campaigner);
        void Update(Campaigner campaigner);
    }
}
