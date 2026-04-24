namespace Molokini.Shared.Contracts.DTOs;

public record PaginationQuery(
    int CurrentPage = 0,
    int PageSize = 10);