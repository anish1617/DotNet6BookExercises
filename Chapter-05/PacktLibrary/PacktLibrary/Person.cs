using System.Collections.Generic;
using static System.ValueTuple;
using System;

namespace Packt.Shared
{
    public partial class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWorld;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Oranges", Number: 5);
        }

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavoriteAncientWorld;
        }

        public void PassigngParameters(int x, ref int y, out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }
    }
}
