﻿using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetEntitiesRepository();
        Task<T> GetEntityRepository(int id);
        Task<bool> UpdateEntityRepository(int id, T entity);
        Task CreateEntityRepository(T entity);
        Task<bool> DeleteEntityRepository(int id);
        Task<List<post>> searchPostsRepository(string? value, int? categoryId, int? typeId, bool viewsSorted);
    }
}
