using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;
using OA.Repo;

namespace OA.Service
{
    class TypeOfRelationService : ITypeOfRelationService
    {
        private IRepository<TypeOfRelation> typeRepository;
        
        public TypeOfRelationService(IRepository<TypeOfRelation> typeRepository)
        {
            this.typeRepository = typeRepository;
        }
        
        public void DeleteType(long id)
        {
            TypeOfRelation typeOfRelation = typeRepository.Get(id);
            typeRepository.Remove(typeOfRelation);
            typeRepository.SaveChanges();
            throw new NotImplementedException();
        }

        public TypeOfRelation GetType(long id)
        {
            return typeRepository.Get(id);
            throw new NotImplementedException();
        }

        public void InsertType(TypeOfRelation type)
        {
            typeRepository.Insert(type);
            throw new NotImplementedException();
        }

        public void UpdateType(TypeOfRelation type)
        {
            typeRepository.Update(type);
            throw new NotImplementedException();
        }

        IEnumerable<TypeOfRelation> ITypeOfRelationService.GetType()
        {
            return typeRepository.GetAll();
            throw new NotImplementedException();
        }
    }
}
