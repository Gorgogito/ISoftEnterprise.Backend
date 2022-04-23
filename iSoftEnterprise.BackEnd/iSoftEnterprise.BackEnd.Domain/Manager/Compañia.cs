using iSoftEnterprise.BackEnd.Domain.Common;

namespace iSoftEnterprise.BackEnd.Domain.Manager
{
  public class Compañia : BaseDomainModel
  {

    public string RUC { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Representante { get; set; } = string.Empty;
    public string Telefono_01 { get; set; } = string.Empty;
    public string Telefono_02 { get; set; } = string.Empty;
    public string Telefono_03 { get; set; } = string.Empty;
    public string Telefono_04 { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
    public string Web { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string VistaVentana { get; set; } = string.Empty;
    public string VistaReporte { get; set; } = string.Empty;
    public string Index_Ubigeo { get; set; } = string.Empty;
   
  }
}
