using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Repositories;

using AutoMapper;
using System.Threading.Tasks;
using Xunit;

public class ReservaDetalleRepositoryTests
{
    private readonly ReservaDetalleRepository _repository;
    private readonly IMapper _mapper;

    public ReservaDetalleRepositoryTests()
    {
        var dbContext = DbContextInMemory.GetInMemoryDbContext();
        _mapper = new MapperConfiguration(cfg => { }).CreateMapper();
        _repository = new ReservaDetalleRepository(dbContext, _mapper);
    }

    [Fact]
    public async Task Save_ShouldAddNewReservaDetalle()
    {
        var reservaDetalle = new ReservaDetalle { IdReservaDetalle = 1};

        await _repository.Save(reservaDetalle);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
        
    }

    [Fact]
    public async Task Delete_ShouldSoftDeleteReservaDetalle()
    {
        var reservaDetalle = new ReservaDetalle { IdReservaDetalle = 1};
        await _repository.Save(reservaDetalle);

        await _repository.Delete(reservaDetalle);

        var result = await _repository.Get(1);
        Assert.NotNull(result);
        Assert.True(result.IsDeleted);
    }
}
