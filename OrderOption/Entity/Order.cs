

using System;
using GameDemoProject.PlayerOptions.Abstract;

namespace GameDemoProject.OrderOption.Entity
{
    public class Order : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get ; set; }
        public string NationalityId { get ; set ; }
        public DateTime BirthDate { get ; set ; }
    }
}
