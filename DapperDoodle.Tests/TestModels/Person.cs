using System.Runtime.CompilerServices;
using static PeanutButter.RandomGenerators.RandomValueGen;

namespace DapperDoodle.Tests.TestModels
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public static Person Create()
        {
            return new Person()
            {
                Id = 0,
                Name = GetRandomString(),
                Surname = GetRandomString(),
                Email = GetRandomEmail()
            };
        }
    }
}