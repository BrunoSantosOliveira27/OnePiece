
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnePiece.Models;

[Table("FRUTA_DO_DIABO")]

 public class FRUTA_DO_DIABO
 
 {
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int id { get; set; }

[Required]
[StringLength(30)]
public string nome { get; set; }


public string Descricao { get; set; }
 }
 

