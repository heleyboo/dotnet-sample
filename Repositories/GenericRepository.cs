using System.Linq.Expressions;
using webapi.DbContext;
using webapi.Repositories.Interfaces;

namespace webapi.Repositories;

public class GenericRepository < T > : IGenericRepository < T > where T: class {
    protected readonly AdministrativeDataContext context;
    public GenericRepository(AdministrativeDataContext context) {
        this.context = context;
    }
    public T Add(T entity) {
        context.Set<T>().Add(entity);
        context.SaveChanges();
        return entity;
    }
    public void AddRange(IEnumerable <T> entities) {
        context.Set<T>().AddRange(entities);
    }
    public IEnumerable <T> GetAll() {
        return context.Set<T>().ToList();
    }
    
    public IEnumerable < T > Find(Expression < Func < T, bool >> expression) {
        return context.Set < T > ().Where(expression);
    }
    public T GetById(int id) {
        return context.Set<T>().Find(id);
    }
    public void Remove(T entity) {
        context.Set<T>().Remove(entity);
    }
    public void RemoveRange(IEnumerable < T > entities) {
        context.Set<T>().RemoveRange(entities);
    }
}