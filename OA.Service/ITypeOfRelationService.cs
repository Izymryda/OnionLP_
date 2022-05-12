using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Service
{
    public interface ITypeOfRelationService
    {
        IEnumerable<TypeOfRelation> GetType();
        TypeOfRelation GetType(long id);
        void InsertType(TypeOfRelation type);
        void UpdateType(TypeOfRelation type);
        void DeleteType(long id);
    }
}
