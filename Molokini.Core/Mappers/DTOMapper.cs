using Molokini.Core.Entities;
using Molokini.Shared.Contracts.DTOs;
using Molokini.Shared.Models;

namespace Molokini.Core.Mappers;

public static class DTOMapper
{
    public static WasteEntryDto ToDto(this WasteEntry entity)
    {
        return new WasteEntryDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
        };
    }

    public static WasteJobEntryDto ToDto(this WasteJob entity)
    {
        return new WasteJobEntryDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
        };
    }

    // To IEnumerable of DTOs
    public static IEnumerable<TDestination> ToDtos<TSource, TDestination>(
    this IEnumerable<TSource> source,
    Func<TSource, TDestination> map)
    {
        return source.Select(map);
    }
}