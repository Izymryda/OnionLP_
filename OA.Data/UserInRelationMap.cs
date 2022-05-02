using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.Data
{
    public class UserInRelationMap
    {
        public UserInRelationMap(EntityTypeBuilder<UserInRelation> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasMany(t => t.User1).WithOne();
            entityBuilder.HasMany(t => t.User2).WithOne();
            entityBuilder.HasMany(t => t.TypeOfRelation).WithOne();
        }
    }
}
