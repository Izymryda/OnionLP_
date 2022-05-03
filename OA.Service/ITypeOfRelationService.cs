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
        void InsertType(User user);
        void UpdateType(User user);
        void DeleteType(long id);
    }
}
