using System;
using Zadanie3.Scaffold;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {

            using var db = new NorthwindContext();

            db.Add(new Users() { });

            db.SaveChanges();

        }
    }
}
