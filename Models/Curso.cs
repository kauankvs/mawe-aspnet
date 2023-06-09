﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Mawe.Models;

public class Curso
{
    [BsonElement("nomeUnico")]
    public string NomeUnico { get; set; }

    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("duracaoEmMinutos")]
    public int DuracaoEmMinutos { get; set; }

    [BsonElement("descricao")]
    public string Descricao { get; set; } = null!;

    [BsonElement("capaUrl")]
    public string CapaUrl { get; set; } = null!;

    [BsonElement("preco")]
    public double Preco { get; set; }

    [BsonElement("dataDeCriacao")]
    public DateTime DataDeCriacao { get; set; }

    [BsonElement("categoria")]
    public string Categoria { get; set; }

}
