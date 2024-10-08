﻿using GscareApiAspNetCore.Communication.Requests;
using GscareApiAspNetCore.Domain.Entities;

namespace GscareApiAspNetCore.Application.UseCases.DocumentUseCases;
public interface IUploadDocumentUseCase
{
    Task<string> Execute(DocumentUploadDto documentDto);
}