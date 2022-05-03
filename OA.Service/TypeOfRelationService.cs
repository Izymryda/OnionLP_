using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    class TypeOfRelationService : ITypeOfRelationService
    {
        //private IRepository<TypeOfRelation> typeRepository;//?
        /*
        public TypeOfRelationService(IRepository<TypeOfRelation> typeRepository)
        {
            this.typeRepository = typeRepository;
        }
        */
        public void DeleteType(long id)
        {
            /*TypeOfRelation typeOfRelation = typeRepository.Get(id);
            typeRepository.Remove(typeOfRelation);
            typeRepository.SaveChanges();*/
            throw new NotImplementedException();
        }

        public TypeOfRelation GetType(long id)
        {
            //return typeRepository.Get(id);
            throw new NotImplementedException();
        }

        public void InsertType(User user)
        {
            //typeRepository.Insert(user);
            throw new NotImplementedException();
        }

        public void UpdateType(User user)
        {
            //typeRepository.Update(user);
            throw new NotImplementedException();
        }

        IEnumerable<TypeOfRelation> ITypeOfRelationService.GetType()
        {
            //return typeRepository.GetAll();
            throw new NotImplementedException();
        }
    }
}
