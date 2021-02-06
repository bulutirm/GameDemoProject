using System;
using GameDemoProject.CampaignOption.Concrete;
using GameDemoProject.PlayerOptions.Abstract;

namespace GameDemoProject.CampaignOption.Entitiy
{
    public class Campaigner : IPerson
    {
        public int Id { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
