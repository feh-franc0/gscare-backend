﻿namespace GscareApiAspNetCore.Domain.Entities;
public class Warning
{
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string AvisoType { get; set; } = string.Empty;
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }
    public string Mensagem { get; set; } = string.Empty;

    // Foreign Key
    public long CompanyId { get; set; }

    // Navigation property
    public Company Company { get; set; } = null!;
}
