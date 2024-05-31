﻿using GscareApiAspNetCore.Communication.Responses;

namespace GscareApiAspNetCore.Application.UseCases;
public interface IGetAllEmployeesUseCase
{
    Task<ResponseEmployeesJson> Execute();
}
