using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.Data
{
    class TypeOfRelationMap
    {
        public TypeOfRelationMap(EntityTypeBuilder<TypeOfRelation> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
        }
    }
}
