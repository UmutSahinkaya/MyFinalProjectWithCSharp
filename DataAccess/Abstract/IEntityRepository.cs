using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class:Referans tip olabilir
    //IEntity : IEntity olabilir veya IEntity implemente eden nesne de olabilir.
    //new(): new'lenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Burası bizim filtreler yazmamızı sağlıyor. Misal Ürünleri fiyata göre listele veya İndirim miktarına göre listele vs
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
