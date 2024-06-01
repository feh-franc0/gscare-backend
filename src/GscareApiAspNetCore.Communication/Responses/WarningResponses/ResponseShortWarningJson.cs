﻿namespace GscareApiAspNetCore.Communication.Responses.WarningResponses;
public class ResponseShortWarningJson
{
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string AvisoType { get; set; } = string.Empty;
    public string DataInicial { get; set; } = string.Empty;
    public string DataFinal { get; set; } = string.Empty;
}
