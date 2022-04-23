using iSoftEnterprise.BackEnd.Domain.Common;

namespace iSoftEnterprise.BackEnd.Domain.Security
{
  public class User : BaseDomainModel
  {
   
    public string ID_User { get; set; } = string.Empty;
    public string Contraseña { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string Telefono_01 { get; set; } = string.Empty;
    public string Telefono_02 { get; set; } = string.Empty;
    public string EMail_01 { get; set; } = string.Empty;
    public string EMail_02 { get; set; } = string.Empty;
    public string Web_01 { get; set; } = string.Empty;
    public string Web_02 { get; set; } = string.Empty;
    public decimal Index_Role { get; set; }
   
  }
}
