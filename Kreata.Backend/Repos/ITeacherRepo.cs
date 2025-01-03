﻿using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
namespace Kreta.Backend.Repos;

public interface ITeacherRepo
{
    Task<List<Teacher>> GetAll();
    Task<Teacher?> GetBy(Guid id);
    Task<ControllerResponse> UpdateTeacherAsync(Teacher teacher);
}