using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Repositories;

using AutoMapper;
using System.Threading.Tasks;
using Xunit;

public class BusRepositoryTests
{
    private readonly BusRepository _repository;
    private readonly IMapper _mapper;

    public BusRepositoryTests()
    {
        var dbContext = DbContextInMemory.GetInMemoryDbContext();
        _mapper = new MapperConfiguration(cfg => { }).CreateMapper();
        _repository = new BusRepository(dbContext, _mapper);
    }

    [Fact]
    public async Task Save_ShouldAddNewBus()
    {
        var bus = new Bus { IdBus = 1, Nombre = "Bus 1" };

        await _repository.Save(bus);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
        Assert.Equal("Bus 1", result.Nombre);
    }

    [Fact]
    public async Task Delete_ShouldSoftDeleteBus()
    {
        var bus = new Bus { IdBus = 1, Nombre = "Bus 1" };
        await _repository.Save(bus);

        await _repository.Delete(bus);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
        Assert.True(result.IsDeleted);
    }
}
