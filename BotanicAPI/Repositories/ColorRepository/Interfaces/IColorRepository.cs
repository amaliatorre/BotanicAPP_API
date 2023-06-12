using BotanicAPI.Entities.Color;

namespace BotanicAPI.Repositories.ColorRepository.Interfaces
{
    public interface IColorRepository
    {
        ColorEntity Create(ColorEntity colorEntity);
    }
}
