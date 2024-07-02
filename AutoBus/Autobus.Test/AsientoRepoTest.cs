using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Repositories;

using AutoMapper;
using System.Threading.Tasks;
using Xunit;

public class AsientoRepositoryTests
{
    private readonly AsientoRepository _repository;
    private readonly IMapper _mapper;

    public AsientoRepositoryTests()
    {
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();
        _mapper = new MapperConfiguration(cfg => { }).CreateMapper();
        _repository = new AsientoRepository(dbContext, _mapper);
    }

    [Fact]
    public async Task Save_ShouldAddNewAsiento()
    {
        var asiento = new Asiento { IdAsiento = 1 };

        await _repository.Save(asiento);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
       
    }

    [Fact]
    public async Task Delete_ShouldSoftDeleteAsiento()
    {
        var asiento = new Asiento { IdAsiento = 1 };
        await _repository.Save(asiento);

        await _repository.Delete(asiento);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
        Assert.True(result.IsDeleted);
    }
}
