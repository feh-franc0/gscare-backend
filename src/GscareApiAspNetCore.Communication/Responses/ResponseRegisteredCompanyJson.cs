﻿namespace GscareApiAspNetCore.Communication.Responses;
public class ResponseRegisteredCompanyJson
{
    public string NomeDaEmpresa { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string TipoDeEscala { get; set; } = string.Empty;
    public string ValorPagoMensal { get; set; } = string.Empty;
    public string ValorDoPlantaoDaProfissional { get; set; } = string.Empty;
}
