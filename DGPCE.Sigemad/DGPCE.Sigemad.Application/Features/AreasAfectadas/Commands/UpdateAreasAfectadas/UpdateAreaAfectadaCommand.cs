﻿using MediatR;
using NetTopologySuite.Geometries;

namespace DGPCE.Sigemad.Application.Features.AreasAfectadas.Commands.UpdateAreasAfectadas;
public class UpdateAreaAfectadaCommand : IRequest
{
    public int Id { get; set; }
    public int IdEvolucion { get; set; }
    public DateTime FechaHora { get; set; }
    public int IdProvincia { get; set; }
    public int IdMunicipio { get; set; }
    public int IdEntidadMenor { get; set; }
    public Geometry? GeoPosicion { get; set; }
}
