 
 

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
//using SFSdotNet.Framework.Common.Entities.Metadata;
//using SFSdotNet.Framework.Common.Entities;

//using Repository.Pattern.Ef6;
#endregion
namespace MBK.Time.Client.Models
{


	  [Serializable()]
	  public partial class supCity{
public Guid? GuidCity { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidState { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supState supState { get; set; }		
		
			

public supCustomer supCustomers { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supCustomer{
public Guid? GuidCustomer { get; set; }		

			

public String Name { get; set; }		
		
			

public String Address { get; set; }		
		
			

public String ZipCode { get; set; }		
		
			

public Double? Lat { get; set; }		
		
			

public Double? Long { get; set; }		
		
			

public String Telephone { get; set; }		
		
			

public String CustomerCode { get; set; }		
		
			

public String ContactName { get; set; }		
		
			

public String ContactEmail { get; set; }		
		
			

public String RFC { get; set; }		
		
			

public Guid? GuidState { get; set; }		
		
			

public Guid? GuidCity { get; set; }		
		
			

public Guid? GuidParent { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public String Address2 { get; set; }		
		
			

public String Comments { get; set; }		
		
			

public supCity supCity { get; set; }		
		
			

public supCustomer supCustomer1 { get; set; }		
		
			

public supCustomer supCustomer2 { get; set; }		
		
			

public supState supState { get; set; }		
		
			

public supRouteCustomer supRouteCustomers { get; set; }		
		
			

public supStoreCustomer supStoreCustomers { get; set; }		
		
			

public supOrder supOrders { get; set; }		
		
			

public supInvoice supInvoices { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supFamily{
public Guid? GuidFamily { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Int32? IdFamily { get; set; }		
		
			

public supFamilyLine supFamilyLines { get; set; }		
		
			

public supFamilyProvider supFamilyProviders { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supLine{
public Guid? GuidLine { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Int32? IdLine { get; set; }		
		
			

public supFamilyLine supFamilyLines { get; set; }		
		
			

public supLineMark supLineMarks { get; set; }		
		
			

public supProviderLine supProviderLines { get; set; }		
		
			

public supProduct supProducts { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supMark{
public Guid? GuidMark { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidProvider { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supProvider supProvider { get; set; }		
		
			

public supPromotion supPromotions { get; set; }		
		
			

public supLineMark supLineMarks { get; set; }		
		
			

public supProduct supProducts { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supOrder{
public Guid? GuidOrder { get; set; }		

			

public Decimal? TotalAmount { get; set; }		
		
			

public Decimal? TotalPayment { get; set; }		
		
			

public Guid? GuidUser { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Guid? GuidCustomer { get; set; }		
		
			

public String IdOrder { get; set; }		
		
			

public String Comments { get; set; }		
		
			

public String SaleType { get; set; }		
		
			

public supProxyUser supProxyUser { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supOrderProduct supOrderProducts { get; set; }		
		
			

public supCustomer supCustomer { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supOrderProduct{
public Guid? GuidOrderproduct { get; set; }		

			

public Guid? GuidOrder { get; set; }		
		
			

public Guid? GuidProduct { get; set; }		
		
			

public Int32? Packs { get; set; }		
		
			

public Int32? TotalProducts { get; set; }		
		
			

public Int32? ProductsByPack { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Decimal? UnitPrice { get; set; }		
		
			

public Decimal? TotalPrice { get; set; }		
		
			

public String IdOrder { get; set; }		
		
			

public supOrder supOrder { get; set; }		
		
			

public supProduct supProduct { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supPromotion{
public Guid? GuidPromotion { get; set; }		

			

public DateTime? FromDate { get; set; }		
		
			

public DateTime? ToDate { get; set; }		
		
			

public String PromotionText { get; set; }		
		
			

public Guid? GuidMark { get; set; }		
		
			

public Guid? GuidProduct { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supMark supMark { get; set; }		
		
			

public supStorePromotion supStorePromotions { get; set; }		
		
			

public supProduct supProduct { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProvider{
public Guid? GuidProvider { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Int32? IdProvider { get; set; }		
		
			

public supMark supMarks { get; set; }		
		
			

public supFamilyProvider supFamilyProviders { get; set; }		
		
			

public supProviderLine supProviderLines { get; set; }		
		
			

public supProduct supProducts { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProxyUser{
public Guid? GuidUser { get; set; }		

			

public String UserName { get; set; }		
		
			

public String Email { get; set; }		
		
			

public String FirstName { get; set; }		
		
			

public String LastName { get; set; }		
		
			

public String DisplayName { get; set; }		
		
			

public String LastToken { get; set; }		
		
			

public supOrder supOrders { get; set; }		
		
			

public supAgent supAgents { get; set; }		
		
			

public supRouteCustomer supRouteCustomers { get; set; }		
		
			

public supUserRoute supUserRoutes { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supReusableCatalog{
public Guid? GuidReusableCatalog { get; set; }		

			

public String NameKey { get; set; }		
		
			

public String Title { get; set; }		
		
			

public supReusableCatalogValue supReusableCatalogValues { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supReusableCatalogValue{
public Guid? GuidReusableCatalogValue { get; set; }		

			

public String Title { get; set; }		
		
			

public String ValueString { get; set; }		
		
			

public Guid? GuidReusableCatalog { get; set; }		
		
			

public supReusableCatalog supReusableCatalog { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supRouteCustomer{
public Guid? GuidRouteCustomer { get; set; }		

			

public Guid? GuidUserRote { get; set; }		
		
			

public Guid? GuidCustomer { get; set; }		
		
			

public Int32? OrderRoute { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidUser { get; set; }		
		
			

public supCustomer supCustomer { get; set; }		
		
			

public supProxyUser supProxyUser { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supUserRoute supUserRoute { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supState{
public Guid? GuidState { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supCity supCities { get; set; }		
		
			

public supCustomer supCustomers { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supStore{
public Guid? GuidStore { get; set; }		

			

public String Name { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Int32? IdStore { get; set; }		
		
			

public supOrder supOrders { get; set; }		
		
			

public supStoreCustomer supStoreCustomers { get; set; }		
		
			

public supStoreProduct supStoreProducts { get; set; }		
		
			

public supStorePromotion supStorePromotions { get; set; }		
		
			

public supAgent supAgents { get; set; }		
		
			

public supRouteCustomer supRouteCustomers { get; set; }		
		
			

public supInvoice supInvoices { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supStoreCustomer{
public Guid? GuidStoreCustomer { get; set; }		

			

public Guid? GuidCustomer { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Decimal? Balance { get; set; }		
		
			

public Decimal? CreditLimit { get; set; }		
		
			

public Int32? DaysCredit { get; set; }		
		
			

public supCustomer supCustomer { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supInvoice supInvoices { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supStoreProduct{
public Guid? GuidStoreProduct { get; set; }		

			

public Int32? ItemsByPack { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidProduct { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Decimal? Price { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supProduct supProduct { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supStorePromotion{
public Guid? GuidStorePromotion { get; set; }		

			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidPromotion { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supPromotion supPromotion { get; set; }		
		
			

public supStore supStore { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supDetalleSaldo{
public Guid? GuidDetalleSaldo { get; set; }		

			

public Int32? numtda { get; set; }		
		
			

public String numcte { get; set; }		
		
			

public String factura { get; set; }		
		
			

public Decimal? importe { get; set; }		
		
			

public Decimal? saldo { get; set; }		
		
			

public DateTime? fecha { get; set; }		
		
			

public DateTime? fecven { get; set; }		
		
			

public Int32? estado { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supPedido{
public Guid? GuidPedido { get; set; }		

			

public String CodigoPedido { get; set; }		
		
			

public Guid? OidCliente { get; set; }		
		
			

public String Cuenta { get; set; }		
		
			

public Int32? Anio { get; set; }		
		
			

public Int32? Mes { get; set; }		
		
			

public Int32? Dia { get; set; }		
		
			

public Int32? OidTipoVenta { get; set; }		
		
			

public Int32? OidRegion { get; set; }		
		
			

public Int32? IDUsuario { get; set; }		
		
			

public String Observaciones { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supPrecio{
public Guid? GuidPrecio { get; set; }		

			

public Int32? numtda { get; set; }		
		
			

public String codart { get; set; }		
		
			

public Decimal? precuni { get; set; }		
		
			

public Int32? atado { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProveedor{
public Guid? GuidProveedor { get; set; }		

			

public Int32? numpro { get; set; }		
		
			

public String nompro { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supRegion{
public Guid? GuidRegion { get; set; }		

			

public Int32? numtda { get; set; }		
		
			

public String nombre { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public String promociones { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supSaldo{
			

public Int32? diacre { get; set; }		
		
public Guid? GuidSaldo { get; set; }		

			

public Int32? numtda { get; set; }		
		
			

public String numcte { get; set; }		
		
			

public Decimal? salcte { get; set; }		
		
			

public Decimal? limcre { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supVenta{
			

public Int32? IDUsuario { get; set; }		
		
			

public String IDSemana { get; set; }		
		
			

public Int32? Anio { get; set; }		
		
			

public Decimal? Monto { get; set; }		
		
public Guid? GuiVenta { get; set; }		

			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supAgente{
			

public Int32? numtda { get; set; }		
		
public Guid? GuidAgente { get; set; }		

			

public Int32? numagt { get; set; }		
		
			

public String nombre { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public String password { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProducto{
public Guid? GuidProducto { get; set; }		

			

public String codart { get; set; }		
		
			

public String descri1 { get; set; }		
		
			

public String descri { get; set; }		
		
			

public Int32? sfam { get; set; }		
		
			

public String unialt { get; set; }		
		
			

public String simcom { get; set; }		
		
			

public Int32? existe { get; set; }		
		
			

public Int32? numpro { get; set; }		
		
			

public String marca { get; set; }		
		
			

public String codbar { get; set; }		
		
			

public String familias { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public DateTime? FechaCambio { get; set; }		
		
			

public DateTime? FechaCreado { get; set; }		
		
			

public Int32? lineanum { get; set; }		
		
			

public String imagen { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supCatalogChange{
public Guid? GuidCatalogChange { get; set; }		

			

public DateTime? StartLastChange { get; set; }		
		
			

public DateTime? EndLastChange { get; set; }		
		
			

public Int32? NewItems { get; set; }		
		
			

public Int32? ChangedItems { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supFamilyLine{
public Guid? GuidFamilyLine { get; set; }		

			

public Guid? GuidFamily { get; set; }		
		
			

public Guid? GuidLine { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supFamily supFamily { get; set; }		
		
			

public supLine supLine { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supAgent{
public Guid? GuidAgent { get; set; }		

			

public Guid? GuidUser { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Boolean Disabled { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Int32? IdAgent { get; set; }		
		
			

public supProxyUser supProxyUser { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supUserRoute supUserRoutes { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supUserRoute{
public Guid? GuidUserRote { get; set; }		

			

public Int32? Day { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Guid? GuidAgent { get; set; }		
		
			

public Guid? GuidUser { get; set; }		
		
			

public supAgent supAgent { get; set; }		
		
			

public supRouteCustomer supRouteCustomers { get; set; }		
		
			

public supProxyUser supProxyUser { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supFamilyProvider{
public Guid? GuidFamilyProvider { get; set; }		

			

public Guid? GuidFamily { get; set; }		
		
			

public Guid? GuidProvider { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supFamily supFamily { get; set; }		
		
			

public supProvider supProvider { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supLineMark{
public Guid? GuidLineMark { get; set; }		

			

public Guid? GuidLine { get; set; }		
		
			

public Guid? GuidMark { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supLine supLine { get; set; }		
		
			

public supMark supMark { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supLinea{
			

public Int32 lineanum { get; set; }		
		
			

public String nombre { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
public Guid? GuidLinea { get; set; }		

	  }

	  [Serializable()]
	  public partial class supCliente{
public Guid? GuidCliente { get; set; }		

			

public Int32? numtda { get; set; }		
		
			

public String numcte { get; set; }		
		
			

public Int32? agente { get; set; }		
		
			

public String nomcte { get; set; }		
		
			

public String contacto { get; set; }		
		
			

public String direccion { get; set; }		
		
			

public String codpos { get; set; }		
		
			

public String ciudad { get; set; }		
		
			

public String colonia { get; set; }		
		
			

public String estado { get; set; }		
		
			

public String telefono { get; set; }		
		
			

public String rfc { get; set; }		
		
			

public String tipcte { get; set; }		
		
			

public String tpocte { get; set; }		
		
			

public String fecultv { get; set; }		
		
			

public Boolean? moroso { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public String diasvisita { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supFamilia{
public Guid? GuidFamilia { get; set; }		

			

public Int32? subfam { get; set; }		
		
			

public String nombre { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supLineaPedido{
public Guid? GuidLineaPedido { get; set; }		

			

public Guid? OidLineaPedido { get; set; }		
		
			

public String CodigoPedido { get; set; }		
		
			

public String OidProducto { get; set; }		
		
			

public Int32? OidRegion { get; set; }		
		
			

public Int32? Cantidad { get; set; }		
		
			

public Int32? Promocion { get; set; }		
		
			

public Int32? Recomendado { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supInvoice{
public Guid? GuidInvoice { get; set; }		

			

public String IdInvoice { get; set; }		
		
			

public Guid? GuidStore { get; set; }		
		
			

public Guid? GuidCustomer { get; set; }		
		
			

public Decimal? Amount { get; set; }		
		
			

public Decimal? Balance { get; set; }		
		
			

public DateTime? InvoiceDate { get; set; }		
		
			

public DateTime? SaleDate { get; set; }		
		
			

public Int32? State { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Guid? GuidStoreCustomer { get; set; }		
		
			

public supCustomer supCustomer { get; set; }		
		
			

public supStore supStore { get; set; }		
		
			

public supStoreCustomer supStoreCustomer { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProviderLine{
public Guid? GuidProviderLine { get; set; }		

			

public Guid? GuidProvider { get; set; }		
		
			

public Guid? GuidLine { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supLine supLine { get; set; }		
		
			

public supProvider supProvider { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProductoOpcion{
public Guid? GuidProductoOpcion { get; set; }		

			

public String subcodart { get; set; }		
		
			

public String codart { get; set; }		
		
			

public String descri { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProductOption{
public Guid? GuidProductOption { get; set; }		

			

public Guid? GuidProduct { get; set; }		
		
			

public String ProductCode { get; set; }		
		
			

public String Description { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public supProduct supProduct { get; set; }		
		
	  }

	  [Serializable()]
	  public partial class supProduct{
public Guid? GuidProduct { get; set; }		

			

public String Name { get; set; }		
		
			

public String UrlImage { get; set; }		
		
			

public Decimal? Price { get; set; }		
		
			

public String ProductCode { get; set; }		
		
			

public String SKU { get; set; }		
		
			

public Guid? GuidProvider { get; set; }		
		
			

public Guid? GuidMark { get; set; }		
		
			

public Guid? GuidCompany { get; set; }		
		
			

public DateTime? CreatedDate { get; set; }		
		
			

public DateTime? UpdatedDate { get; set; }		
		
			

public Guid? CreatedBy { get; set; }		
		
			

public Guid? UpdatedBy { get; set; }		
		
			

public Int32? Bytes { get; set; }		
		
			

public Boolean? IsDeleted { get; set; }		
		
			

public Guid? GuidLine { get; set; }		
		
			

public Int32? Stock { get; set; }		
		
			

public supLine supLine { get; set; }		
		
			

public supMark supMark { get; set; }		
		
			

public supOrderProduct supOrderProducts { get; set; }		
		
			

public supProvider supProvider { get; set; }		
		
			

public supProductOption supProductOptions { get; set; }		
		
			

public supPromotion supPromotions { get; set; }		
		
			

public supStoreProduct supStoreProducts { get; set; }		
		
	  }
	
}
