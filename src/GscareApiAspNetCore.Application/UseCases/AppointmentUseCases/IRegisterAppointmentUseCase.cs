﻿using GscareApiAspNetCore.Communication.Requests;
using GscareApiAspNetCore.Communication.Responses.AppointmentResponses;
using System.Threading.Tasks;

namespace GscareApiAspNetCore.Application.UseCases.AppointmentUseCases
{
    public interface IRegisterAppointmentUseCase
    {
        Task<ResponseRegisteredAppointmentJson> Execute(RequestAppointmentJson request);
    }
}
