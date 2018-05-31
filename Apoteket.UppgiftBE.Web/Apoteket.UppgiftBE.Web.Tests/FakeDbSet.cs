using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Tests
{
    public class FakeDbSet<T> : IDbSet<T>
        whwere T : class
        {
             ObservableCollection<T> _data;
             IQueryable _query;
             public FakeDbSet()
             {
                _data = new ObservableCollection<T>();
                 _query = _data.AsQueryable();
             }

        //find function

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derive from FakeDbSet<T> and override Find");
        }

        // add function

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }
        //remove function
        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        // Attach function

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        //  Detach function

        public T Detach(T item)
        {
            _data.Remove(item);
            return item;
        }

        // Create function

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

    public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
    {
        return Activator.CreateInstance<TDerivedEntity>();
    }

    public ObservableCollection<T> Local
    {
        get { return _data; }
    }

    Type IQueryable.ElementType
    {
        get { return _query.ElementType; }
    }

    System.Linq.Expressions.Expression IQueryable.Expression
    {
        get { return _query.Expression; }
    }

    IQueryProvider IQueryable.Provider
    {
        get { return _query.Provider; }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return _data.GetEnumerator();
    }
}

   

   