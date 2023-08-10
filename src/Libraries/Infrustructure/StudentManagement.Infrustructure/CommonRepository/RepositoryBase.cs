
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Shared;
using StudentManagement.Shared.Common;
using StudentManagement.Shared.Extentions;

namespace StudentManagement.Infrustructure.CommonRepository;

public class RepositoryBase<TEntity, IModel, T> : IRepository<TEntity, IModel, T>
    where TEntity : class, IEntity<T>, new()
    where IModel : class, IVm<T>, new()
    where T : IEquatable<T>

{
    protected readonly IMapper _mapper;
    private readonly StudentManagementDbContext _dbContext;
    public RepositoryBase(IMapper mapper, StudentManagementDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
        DbSet = _dbContext.Set<TEntity>();
    }

    public DbSet<TEntity> DbSet { get; }

    public async Task<IModel> Add(TEntity entity)
    { 
        await DbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<IModel>(entity);
    }

    public async Task Delete(TEntity entity)
    {
        DbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(T id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity != null)
        {
            DbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

    }

    public  Task<IEnumerable<IModel>> GetAll()
    {
        var data = DbSet.AsEnumerable();
        var models = _mapper.Map<IEnumerable<IModel>>(data);
       // return Task.FromResult(models);
       return Task.FromResult(models);
    }

    public async Task<IModel> GetById(T id)
    {
        var data = await DbSet.FindAsync(id);
        return _mapper.Map<IModel>(data);
    }

    public async Task<IModel> Update(T id, TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        var exist = await DbSet.FindAsync(id);
        if (exist != null)
        {
            DbSet.Entry(exist).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();
        }
        return _mapper.Map<IModel>(entity);
    }
}
