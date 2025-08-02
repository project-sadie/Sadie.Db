using System.ComponentModel.DataAnnotations;

namespace Sadie.Db.Models;

public class ServerLocaleText
{
    [MaxLength(120)] public string Key { get; set; }
    [MaxLength(300)] public string Text { get; set; }
}