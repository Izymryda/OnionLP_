using System.Linq;
using OA.Repo;
using OA.Data;
using OA.Service;

namespace OA.Web
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if(!context.User.Any())
            {
                context.Peoples.AddRange(
                    new People
                    {
                        Name = "Sergiy",
                        SecondName = "Stroyan",
                        Sex = "male",
                        City = "Khmelnitsky"
                    },
                    new People
                    {
                        Name = "Oleg",
                        SecondName = "Kalinyk",
                        Sex = "male",
                        City = "Kiev"
                    },
                    new People
                    {
                        Name = "Tania",
                        SecondName = "Clot",
                        Sex = "female",
                        City = "Khmelnitsky"
                    },
                    new People
                    {
                        Name = "Ira",
                        SecondName = "Savchenko",
                        Sex = "female",
                        City = "Kiev"
                    }
                    );
                context.SaveChanges();
            }
            if(!context.Type_Of_Relations.Any())
            {
                context.Type_Of_Relations.AddRange(
                new Type_of_Relation
                {
                    Name = "Love"
                }, 
                new Type_of_Relation
                {
                    Name = "Friend"
                },
                new Type_of_Relation
                {
                    Name = "Hobby"
                }
                );
                context.SaveChanges();
            }
            if (!context.Pep_N_Rels.Any())
            {
                context.Pep_N_Rels.AddRange(
                new Pep_n_Rel
                {
                    Date = System.DateTime.Now,
                    PeopleId_1 = 1,
                    PeopleId_2=2,
                    T_RId = 1
                }) ;
                context.SaveChanges();
            }

        }
    }
}
