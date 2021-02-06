using System;
using GameDemoProject.PlayerOptions.Abstract;

namespace GameDemoProject.PlayerOptions.Entities
{
    public class Player : IPerson
    {
        public string NickName { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
