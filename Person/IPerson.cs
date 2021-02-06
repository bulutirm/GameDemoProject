using System;
namespace GameDemoProject.PlayerOptions.Abstract
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
