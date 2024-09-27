using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnePiece.Models;

[Table("PERSONAGEM")]

 public class PERSONAGEM
 
 {
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int id { get; set; }

[Required]
[StringLength(30)]
public string Nome { get; set; }

[Required]
[StringLength(200)]
public string Imagem { get; set; }

public int Fruta_id { get; set; }

[ForeignKey("Fruta_id")]
public FRUTA_DO_DIABO FRUTA_DO_DIABO { get; set; }
public int Tripulacao_id { get; set; }

[ForeignKey("Tripulacao_id")]
public TRIPULACAO TRIPULACAO { get; set; }
 }
 