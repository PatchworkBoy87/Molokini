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

    public static PagedResult<WasteEntryDto> ToPagedDto(this PagedResult<WasteEntry> entity)
    {
        return new PagedResult<WasteEntryDto>
        {
            Items = entity.Items.Select(ToDto),
            TotalCount = entity.TotalCount,
            PageNumber = entity.PageNumber,
            PageSize = entity.PageSize,
        };
    }

    public static PagedResult<WasteJobEntryDto> ToPagedDto(this PagedResult<WasteJob> entity)
    {
        return new PagedResult<WasteJobEntryDto>
        {
            Items = entity.Items.Select(ToDto),
            TotalCount = entity.TotalCount,
            PageNumber = entity.PageNumber,
            PageSize = entity.PageSize,
        };
    }
}