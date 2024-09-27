using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnePiece.Models;

[Table("TRIPULACAO")]

 public class TRIPULACAO
 
 {
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int id { get; set; }

public string nome { get; set; }

[Required]
[StringLength(30)]
public string Cor { get; set; }

 }