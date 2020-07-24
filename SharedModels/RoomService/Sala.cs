using SharedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sala : EntityBase
{
    [Key]
    public int Id_Sala { get; set; }
    public string NombreSala { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaBaja { get; set; }
    public DateTime? FechaUltimoUso { get; set; }
    public DateTime? TiempoAcumuladoUso { get; set; }
    [NotMapped]
    public List<Participante> Participante { get; set; }
    public string PasswordSala { get; set; }
    public bool ControlAsistencia { get; set; }

}