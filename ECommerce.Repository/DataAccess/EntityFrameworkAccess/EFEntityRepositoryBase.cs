using ECommerce.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.Repository.DataAccess.EntityFrameworkAccess;

public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
{

	public void Add(TEntity entity)
	{
		using var context = new TContext();
		var addedEntity = context.Entry(entity);
		addedEntity.State = EntityState.Added;//Niye burda Context.Add(entity)yazmmadiq?
		context.SaveChanges();
	}

	public void Delete(TEntity entity)
	{
		using var context = new TContext();
		var addedEntity = context.Entry(entity);
		addedEntity.State = EntityState.Deleted;
		context.SaveChanges();
	}

	public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
	{
		using var context = new TContext();
		return context.Set<TEntity>().SingleOrDefault(filter);
	}

	public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
	{
		using var context = new TContext();
		return filter == null ?
			context.Set<TEntity>().ToList()
			: context.Set<TEntity>().Where(filter).ToList();
	}

	public void Update(TEntity entity)
	{
		using var context = new TContext();
		var addedEntity = context.Entry(entity);
		addedEntity.State = EntityState.Modified;
		context.SaveChanges();
	}
}
