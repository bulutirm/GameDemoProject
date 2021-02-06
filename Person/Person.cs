using System;
using GameDemoProject.PlayerOptions.Abstract;

namespace GameDemoProject.Person
{
    public abstract class Person : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NationalityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}

