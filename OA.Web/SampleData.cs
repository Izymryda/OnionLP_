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
            if (!context.UserProfiles.Any())
            {
                context.UserProfiles.AddRange(
                    new UserProfile
                    {
                        FirstName="Serhiy",
                        LastName="Stroyan",
                        Sex="male",
                        Address="Kyiv"
                        
                    },
                    new UserProfile
                    {
                        FirstName = "Oleg",
                        LastName = "Kalinyk",
                        Sex = "male",
                        Address = "Kyiv"

                    },
                    new UserProfile
                    {
                        FirstName = "Tania",
                        LastName = "Slot",
                        Sex = "female",
                        Address = "Khmelnytskyi"

                    },
                    new UserProfile
                    {
                        FirstName = "Ira",
                        LastName = "Savchenko",
                        Sex = "female",
                        Address = "Kyiv"

                    });
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        UserName = "ChShFront",
                        Email = "stroyan@gmail.com",
                        Password = "123"
                    },
                    new User
                    {
                        UserName = "Kalina",
                        Email = "olka@outlook.com",
                        Password = "345"
                    },
                    new User
                    {
                        UserName = "Izymryda",
                        Email = "fizmaf96@gmail.com",
                        Password = "567"
                    },
                    new User
                    {
                        UserName = "KomokShersti",
                        Email = "irinka@gmail.com",
                        Password = "789"
                    }
                    ); 
                context.SaveChanges();
            }
            if(!context.TypeOfRelations.Any())
            {
                context.TypeOfRelations.AddRange(
                new TypeOfRelation
                {               
                    Name = "Love"
                }, 
                new TypeOfRelation
                {
                    Name = "Friend"
                },
                new TypeOfRelation
                {
                    Name = "Hobby"
                }
                );
                context.SaveChanges();
            }  
        }
    }
}
