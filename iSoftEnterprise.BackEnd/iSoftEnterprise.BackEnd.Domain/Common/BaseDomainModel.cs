namespace iSoftEnterprise.BackEnd.Domain.Common
{
  public abstract class BaseDomainModel
  {
    public long ID_Key { get; set; }
    public decimal ID_Index { get; set; }
    public decimal Index_Estado { get; set; }
    public DateTime FechaHoraRegistro { get; set; }
    public decimal Index_UserRegistro { get; set; }
    public DateTime FechaHoraModificacion { get; set; }
    public decimal Index_UserModificacion { get; set; }
  }
}
