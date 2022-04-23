using iSoftEnterprise.BackEnd.Domain.Common;

namespace iSoftEnterprise.BackEnd.Domain.Enterprise
{
  public class Sucursal : BaseDomainModel
  {
    public string Descripcion { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Telefono_01 { get; set; } = string.Empty;
    public string Telefono_02 { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
  }
}
