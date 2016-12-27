 
 

#region using
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBK.Time.Client.Models;

using System.Configuration;
using System.Collections.Generic;

#endregion
namespace MBK.Time.Tests
{

	 [TestClass]
	  public class AllBasicTests
	  {
	    private string url = null;
        public AllBasicTests()
        {
            url = ConfigurationManager.AppSettings["urlApp"];
        }
		private ApiWrapper<TModel> GetWrapper<TModel>() where TModel:class 
        {
            
            ApiWrapper<TModel> apiWrapper = new ApiWrapper<TModel>();
            apiWrapper.Username = ConfigurationManager.AppSettings["username"];
            apiWrapper.Password = ConfigurationManager.AppSettings["password"];
            apiWrapper.CompanyId = ConfigurationManager.AppSettings["companyId"];
            return apiWrapper;
        }
	public supFamily supFamilySample(){
		 supFamily item = new supFamily();
            item.GuidFamily = Guid.NewGuid();

            item.Name = Utils.GetString(10);








            item.IdFamily = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supFamilyCreate( List<supFamily> items, supFamily item )
        {
            var apiWrapper = GetWrapper<supFamily>();
            apiWrapper.EntityKeyName = "supFamily";
            apiWrapper.EntitySetName  = "supFamilies";
			if (item == null && items == null)
            {
				apiWrapper.Item = supFamilySample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidFamily;
				var existent = Services.ApiGetByKey<supFamily>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supLine supLineSample(){
		 supLine item = new supLine();
            item.GuidLine = Guid.NewGuid();

            item.Name = Utils.GetString(10);








            item.IdLine = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supLineCreate( List<supLine> items, supLine item )
        {
            var apiWrapper = GetWrapper<supLine>();
            apiWrapper.EntityKeyName = "supLine";
            apiWrapper.EntitySetName  = "supLines";
			if (item == null && items == null)
            {
				apiWrapper.Item = supLineSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidLine;
				var existent = Services.ApiGetByKey<supLine>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProvider supProviderSample(){
		 supProvider item = new supProvider();
            item.GuidProvider = Guid.NewGuid();

            item.Name = Utils.GetString(10);








            item.IdProvider = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supProviderCreate( List<supProvider> items, supProvider item )
        {
            var apiWrapper = GetWrapper<supProvider>();
            apiWrapper.EntityKeyName = "supProvider";
            apiWrapper.EntitySetName  = "supProviders";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProviderSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProvider;
				var existent = Services.ApiGetByKey<supProvider>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProxyUser supProxyUserSample(){
		 supProxyUser item = new supProxyUser();
            item.GuidUser = Guid.NewGuid();

            item.UserName = Utils.GetString(10);

            item.Email = Utils.GetString(10);

            item.FirstName = Utils.GetString(10);

            item.LastName = Utils.GetString(10);

            item.DisplayName = Utils.GetString(10);

            item.LastToken = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supProxyUserCreate( List<supProxyUser> items, supProxyUser item )
        {
            var apiWrapper = GetWrapper<supProxyUser>();
            apiWrapper.EntityKeyName = "supProxyUser";
            apiWrapper.EntitySetName  = "supProxyUsers";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProxyUserSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidUser;
				var existent = Services.ApiGetByKey<supProxyUser>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supReusableCatalog supReusableCatalogSample(){
		 supReusableCatalog item = new supReusableCatalog();
            item.GuidReusableCatalog = Guid.NewGuid();

            item.NameKey = Utils.GetString(10);

            item.Title = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supReusableCatalogCreate( List<supReusableCatalog> items, supReusableCatalog item )
        {
            var apiWrapper = GetWrapper<supReusableCatalog>();
            apiWrapper.EntityKeyName = "supReusableCatalog";
            apiWrapper.EntitySetName  = "supReusableCatalogs";
			if (item == null && items == null)
            {
				apiWrapper.Item = supReusableCatalogSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidReusableCatalog;
				var existent = Services.ApiGetByKey<supReusableCatalog>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supState supStateSample(){
		 supState item = new supState();
            item.GuidState = Guid.NewGuid();

            item.Name = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supStateCreate( List<supState> items, supState item )
        {
            var apiWrapper = GetWrapper<supState>();
            apiWrapper.EntityKeyName = "supState";
            apiWrapper.EntitySetName  = "supStates";
			if (item == null && items == null)
            {
				apiWrapper.Item = supStateSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidState;
				var existent = Services.ApiGetByKey<supState>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supStore supStoreSample(){
		 supStore item = new supStore();
            item.GuidStore = Guid.NewGuid();

            item.Name = Utils.GetString(10);








            item.IdStore = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supStoreCreate( List<supStore> items, supStore item )
        {
            var apiWrapper = GetWrapper<supStore>();
            apiWrapper.EntityKeyName = "supStore";
            apiWrapper.EntitySetName  = "supStores";
			if (item == null && items == null)
            {
				apiWrapper.Item = supStoreSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidStore;
				var existent = Services.ApiGetByKey<supStore>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supDetalleSaldo supDetalleSaldoSample(){
		 supDetalleSaldo item = new supDetalleSaldo();
            item.GuidDetalleSaldo = Guid.NewGuid();

            item.numtda = Utils.GetInt();


            item.numcte = Utils.GetString(10);

            item.factura = Utils.GetString(10);

            item.importe = Utils.GetDecimal();


            item.saldo = Utils.GetDecimal();


            item.fecha = Utils.GetDateTime();
			

            item.fecven = Utils.GetDateTime();
			

            item.estado = Utils.GetInt();









		return item;
	}
	[TestMethod]
	 public void supDetalleSaldoCreate( List<supDetalleSaldo> items, supDetalleSaldo item )
        {
            var apiWrapper = GetWrapper<supDetalleSaldo>();
            apiWrapper.EntityKeyName = "supDetalleSaldo";
            apiWrapper.EntitySetName  = "supDetalleSaldoes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supDetalleSaldoSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidDetalleSaldo;
				var existent = Services.ApiGetByKey<supDetalleSaldo>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supPedido supPedidoSample(){
		 supPedido item = new supPedido();
            item.GuidPedido = Guid.NewGuid();

            item.CodigoPedido = Utils.GetString(10);


            item.Cuenta = Utils.GetString(10);

            item.Anio = Utils.GetInt();


            item.Mes = Utils.GetInt();


            item.Dia = Utils.GetInt();


            item.OidTipoVenta = Utils.GetInt();


            item.OidRegion = Utils.GetInt();


            item.IDUsuario = Utils.GetInt();


            item.Observaciones = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supPedidoCreate( List<supPedido> items, supPedido item )
        {
            var apiWrapper = GetWrapper<supPedido>();
            apiWrapper.EntityKeyName = "supPedido";
            apiWrapper.EntitySetName  = "supPedidoes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supPedidoSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidPedido;
				var existent = Services.ApiGetByKey<supPedido>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supPrecio supPrecioSample(){
		 supPrecio item = new supPrecio();
            item.GuidPrecio = Guid.NewGuid();

            item.numtda = Utils.GetInt();


            item.codart = Utils.GetString(10);

            item.precuni = Utils.GetDecimal();


            item.atado = Utils.GetInt();









		return item;
	}
	[TestMethod]
	 public void supPrecioCreate( List<supPrecio> items, supPrecio item )
        {
            var apiWrapper = GetWrapper<supPrecio>();
            apiWrapper.EntityKeyName = "supPrecio";
            apiWrapper.EntitySetName  = "supPrecios";
			if (item == null && items == null)
            {
				apiWrapper.Item = supPrecioSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidPrecio;
				var existent = Services.ApiGetByKey<supPrecio>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProveedor supProveedorSample(){
		 supProveedor item = new supProveedor();
            item.GuidProveedor = Guid.NewGuid();

            item.numpro = Utils.GetInt();


            item.nompro = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supProveedorCreate( List<supProveedor> items, supProveedor item )
        {
            var apiWrapper = GetWrapper<supProveedor>();
            apiWrapper.EntityKeyName = "supProveedor";
            apiWrapper.EntitySetName  = "supProveedors";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProveedorSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProveedor;
				var existent = Services.ApiGetByKey<supProveedor>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supRegion supRegionSample(){
		 supRegion item = new supRegion();
            item.GuidRegion = Guid.NewGuid();

            item.numtda = Utils.GetInt();


            item.nombre = Utils.GetString(10);








            item.promociones = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supRegionCreate( List<supRegion> items, supRegion item )
        {
            var apiWrapper = GetWrapper<supRegion>();
            apiWrapper.EntityKeyName = "supRegion";
            apiWrapper.EntitySetName  = "supRegions";
			if (item == null && items == null)
            {
				apiWrapper.Item = supRegionSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidRegion;
				var existent = Services.ApiGetByKey<supRegion>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supSaldo supSaldoSample(){
		 supSaldo item = new supSaldo();
            item.diacre = Utils.GetInt();


            item.GuidSaldo = Guid.NewGuid();

            item.numtda = Utils.GetInt();


            item.numcte = Utils.GetString(10);

            item.salcte = Utils.GetDecimal();


            item.limcre = Utils.GetDecimal();









		return item;
	}
	[TestMethod]
	 public void supSaldoCreate( List<supSaldo> items, supSaldo item )
        {
            var apiWrapper = GetWrapper<supSaldo>();
            apiWrapper.EntityKeyName = "supSaldo";
            apiWrapper.EntitySetName  = "supSaldoes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supSaldoSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidSaldo;
				var existent = Services.ApiGetByKey<supSaldo>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supVenta supVentaSample(){
		 supVenta item = new supVenta();
            item.IDUsuario = Utils.GetInt();


            item.IDSemana = Utils.GetString(10);

            item.Anio = Utils.GetInt();


            item.Monto = Utils.GetDecimal();


            item.GuiVenta = Guid.NewGuid();








		return item;
	}
	[TestMethod]
	 public void supVentaCreate( List<supVenta> items, supVenta item )
        {
            var apiWrapper = GetWrapper<supVenta>();
            apiWrapper.EntityKeyName = "supVenta";
            apiWrapper.EntitySetName  = "supVentas";
			if (item == null && items == null)
            {
				apiWrapper.Item = supVentaSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuiVenta;
				var existent = Services.ApiGetByKey<supVenta>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supAgente supAgenteSample(){
		 supAgente item = new supAgente();
            item.numtda = Utils.GetInt();


            item.GuidAgente = Guid.NewGuid();

            item.numagt = Utils.GetInt();


            item.nombre = Utils.GetString(10);








            item.password = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supAgenteCreate( List<supAgente> items, supAgente item )
        {
            var apiWrapper = GetWrapper<supAgente>();
            apiWrapper.EntityKeyName = "supAgente";
            apiWrapper.EntitySetName  = "supAgentes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supAgenteSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidAgente;
				var existent = Services.ApiGetByKey<supAgente>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProducto supProductoSample(){
		 supProducto item = new supProducto();
            item.GuidProducto = Guid.NewGuid();

            item.codart = Utils.GetString(10);

            item.descri1 = Utils.GetString(10);

            item.descri = Utils.GetString(10);

            item.sfam = Utils.GetInt();


            item.unialt = Utils.GetString(10);

            item.simcom = Utils.GetString(10);

            item.existe = Utils.GetInt();


            item.numpro = Utils.GetInt();


            item.marca = Utils.GetString(10);

            item.codbar = Utils.GetString(10);

            item.familias = Utils.GetString(10);








            item.FechaCambio = Utils.GetDateTime();
			

            item.FechaCreado = Utils.GetDateTime();
			

            item.lineanum = Utils.GetInt();


            item.imagen = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supProductoCreate( List<supProducto> items, supProducto item )
        {
            var apiWrapper = GetWrapper<supProducto>();
            apiWrapper.EntityKeyName = "supProducto";
            apiWrapper.EntitySetName  = "supProductos";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProductoSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProducto;
				var existent = Services.ApiGetByKey<supProducto>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supCatalogChange supCatalogChangeSample(){
		 supCatalogChange item = new supCatalogChange();
            item.GuidCatalogChange = Guid.NewGuid();

            item.StartLastChange = Utils.GetDateTime();
			

            item.EndLastChange = Utils.GetDateTime();
			

            item.NewItems = Utils.GetInt();


            item.ChangedItems = Utils.GetInt();









		return item;
	}
	[TestMethod]
	 public void supCatalogChangeCreate( List<supCatalogChange> items, supCatalogChange item )
        {
            var apiWrapper = GetWrapper<supCatalogChange>();
            apiWrapper.EntityKeyName = "supCatalogChange";
            apiWrapper.EntitySetName  = "supCatalogChanges";
			if (item == null && items == null)
            {
				apiWrapper.Item = supCatalogChangeSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidCatalogChange;
				var existent = Services.ApiGetByKey<supCatalogChange>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supLinea supLineaSample(){
		 supLinea item = new supLinea();
            item.lineanum = Utils.GetInt();


            item.nombre = Utils.GetString(10);








            item.GuidLinea = Guid.NewGuid();

		return item;
	}
	[TestMethod]
	 public void supLineaCreate( List<supLinea> items, supLinea item )
        {
            var apiWrapper = GetWrapper<supLinea>();
            apiWrapper.EntityKeyName = "supLinea";
            apiWrapper.EntitySetName  = "supLineas";
			if (item == null && items == null)
            {
				apiWrapper.Item = supLineaSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidLinea;
				var existent = Services.ApiGetByKey<supLinea>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supCliente supClienteSample(){
		 supCliente item = new supCliente();
            item.GuidCliente = Guid.NewGuid();

            item.numtda = Utils.GetInt();


            item.numcte = Utils.GetString(10);

            item.agente = Utils.GetInt();


            item.nomcte = Utils.GetString(10);

            item.contacto = Utils.GetString(10);

            item.direccion = Utils.GetString(10);

            item.codpos = Utils.GetString(5);

            item.ciudad = Utils.GetString(10);

            item.colonia = Utils.GetString(10);

            item.estado = Utils.GetString(10);

            item.telefono = Utils.GetString(10);

            item.rfc = Utils.GetString(10);

            item.tipcte = Utils.GetString(10);

            item.tpocte = Utils.GetString(10);

            item.fecultv = Utils.GetString(10);


            item.moroso = Utils.GetBool();








            item.diasvisita = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supClienteCreate( List<supCliente> items, supCliente item )
        {
            var apiWrapper = GetWrapper<supCliente>();
            apiWrapper.EntityKeyName = "supCliente";
            apiWrapper.EntitySetName  = "supClientes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supClienteSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidCliente;
				var existent = Services.ApiGetByKey<supCliente>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supFamilia supFamiliaSample(){
		 supFamilia item = new supFamilia();
            item.GuidFamilia = Guid.NewGuid();

            item.subfam = Utils.GetInt();


            item.nombre = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supFamiliaCreate( List<supFamilia> items, supFamilia item )
        {
            var apiWrapper = GetWrapper<supFamilia>();
            apiWrapper.EntityKeyName = "supFamilia";
            apiWrapper.EntitySetName  = "supFamilias";
			if (item == null && items == null)
            {
				apiWrapper.Item = supFamiliaSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidFamilia;
				var existent = Services.ApiGetByKey<supFamilia>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supLineaPedido supLineaPedidoSample(){
		 supLineaPedido item = new supLineaPedido();
            item.GuidLineaPedido = Guid.NewGuid();


            item.CodigoPedido = Utils.GetString(10);

            item.OidProducto = Utils.GetString(10);

            item.OidRegion = Utils.GetInt();


            item.Cantidad = Utils.GetInt();


            item.Promocion = Utils.GetInt();


            item.Recomendado = Utils.GetInt();









		return item;
	}
	[TestMethod]
	 public void supLineaPedidoCreate( List<supLineaPedido> items, supLineaPedido item )
        {
            var apiWrapper = GetWrapper<supLineaPedido>();
            apiWrapper.EntityKeyName = "supLineaPedido";
            apiWrapper.EntitySetName  = "supLineaPedidoes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supLineaPedidoSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidLineaPedido;
				var existent = Services.ApiGetByKey<supLineaPedido>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProductoOpcion supProductoOpcionSample(){
		 supProductoOpcion item = new supProductoOpcion();
            item.GuidProductoOpcion = Guid.NewGuid();

            item.subcodart = Utils.GetString(10);

            item.codart = Utils.GetString(10);

            item.descri = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supProductoOpcionCreate( List<supProductoOpcion> items, supProductoOpcion item )
        {
            var apiWrapper = GetWrapper<supProductoOpcion>();
            apiWrapper.EntityKeyName = "supProductoOpcion";
            apiWrapper.EntitySetName  = "supProductoOpcions";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProductoOpcionSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProductoOpcion;
				var existent = Services.ApiGetByKey<supProductoOpcion>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supCity supCitySample(){
		 supCity item = new supCity();
            item.GuidCity = Guid.NewGuid();

            item.Name = Utils.GetString(10);









		return item;
	}
	[TestMethod]
	 public void supCityCreate( List<supCity> items, supCity item )
        {
            var apiWrapper = GetWrapper<supCity>();
            apiWrapper.EntityKeyName = "supCity";
            apiWrapper.EntitySetName  = "supCities";
			if (item == null && items == null)
            {
				apiWrapper.Item = supCitySample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidCity;
				var existent = Services.ApiGetByKey<supCity>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supCustomer supCustomerSample(){
		 supCustomer item = new supCustomer();
            item.GuidCustomer = Guid.NewGuid();

            item.Name = Utils.GetString(10);

            item.Address = Utils.GetString(10);

            item.ZipCode = Utils.GetString(5);

            item.Telephone = Utils.GetString(10);

            item.CustomerCode = Utils.GetString(10);

            item.ContactName = Utils.GetString(10);

            item.ContactEmail = Utils.GetString(10);

            item.RFC = Utils.GetString(10);











            item.Address2 = Utils.GetString(10);

            item.Comments = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supCustomerCreate( List<supCustomer> items, supCustomer item )
        {
            var apiWrapper = GetWrapper<supCustomer>();
            apiWrapper.EntityKeyName = "supCustomer";
            apiWrapper.EntitySetName  = "supCustomers";
			if (item == null && items == null)
            {
				apiWrapper.Item = supCustomerSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidCustomer;
				var existent = Services.ApiGetByKey<supCustomer>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supMark supMarkSample(){
		 supMark item = new supMark();
            item.GuidMark = Guid.NewGuid();

            item.Name = Utils.GetString(10);









		return item;
	}
	[TestMethod]
	 public void supMarkCreate( List<supMark> items, supMark item )
        {
            var apiWrapper = GetWrapper<supMark>();
            apiWrapper.EntityKeyName = "supMark";
            apiWrapper.EntitySetName  = "supMarks";
			if (item == null && items == null)
            {
				apiWrapper.Item = supMarkSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidMark;
				var existent = Services.ApiGetByKey<supMark>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supOrder supOrderSample(){
		 supOrder item = new supOrder();
            item.GuidOrder = Guid.NewGuid();

            item.TotalAmount = Utils.GetDecimal();


            item.TotalPayment = Utils.GetDecimal();












            item.IdOrder = Utils.GetString(10);

            item.Comments = Utils.GetString(10);

            item.SaleType = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supOrderCreate( List<supOrder> items, supOrder item )
        {
            var apiWrapper = GetWrapper<supOrder>();
            apiWrapper.EntityKeyName = "supOrder";
            apiWrapper.EntitySetName  = "supOrders";
			if (item == null && items == null)
            {
				apiWrapper.Item = supOrderSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidOrder;
				var existent = Services.ApiGetByKey<supOrder>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProduct supProductSample(){
		 supProduct item = new supProduct();
            item.GuidProduct = Guid.NewGuid();

            item.Name = Utils.GetString(10);

            item.UrlImage = Utils.GetString(10);

            item.Price = Utils.GetDecimal();


            item.ProductCode = Utils.GetString(10);

            item.SKU = Utils.GetString(10);











            item.Stock = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supProductCreate( List<supProduct> items, supProduct item )
        {
            var apiWrapper = GetWrapper<supProduct>();
            apiWrapper.EntityKeyName = "supProduct";
            apiWrapper.EntitySetName  = "supProducts";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProductSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProduct;
				var existent = Services.ApiGetByKey<supProduct>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supOrderProduct supOrderProductSample(){
		 supOrderProduct item = new supOrderProduct();
            item.GuidOrderproduct = Guid.NewGuid();



            item.Packs = Utils.GetInt();


            item.TotalProducts = Utils.GetInt();


            item.ProductsByPack = Utils.GetInt();









            item.UnitPrice = Utils.GetDecimal();


            item.TotalPrice = Utils.GetDecimal();


            item.IdOrder = Utils.GetString(10);

		return item;
	}
	[TestMethod]
	 public void supOrderProductCreate( List<supOrderProduct> items, supOrderProduct item )
        {
            var apiWrapper = GetWrapper<supOrderProduct>();
            apiWrapper.EntityKeyName = "supOrderProduct";
            apiWrapper.EntitySetName  = "supOrderProducts";
			if (item == null && items == null)
            {
				apiWrapper.Item = supOrderProductSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidOrderproduct;
				var existent = Services.ApiGetByKey<supOrderProduct>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supPromotion supPromotionSample(){
		 supPromotion item = new supPromotion();
            item.GuidPromotion = Guid.NewGuid();

            item.FromDate = Utils.GetDateTime();
			

            item.ToDate = Utils.GetDateTime();
			

            item.PromotionText = Utils.GetString(10);










		return item;
	}
	[TestMethod]
	 public void supPromotionCreate( List<supPromotion> items, supPromotion item )
        {
            var apiWrapper = GetWrapper<supPromotion>();
            apiWrapper.EntityKeyName = "supPromotion";
            apiWrapper.EntitySetName  = "supPromotions";
			if (item == null && items == null)
            {
				apiWrapper.Item = supPromotionSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidPromotion;
				var existent = Services.ApiGetByKey<supPromotion>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supReusableCatalogValue supReusableCatalogValueSample(){
		 supReusableCatalogValue item = new supReusableCatalogValue();
            item.GuidReusableCatalogValue = Guid.NewGuid();

            item.Title = Utils.GetString(10);

            item.ValueString = Utils.GetString(10);


		return item;
	}
	[TestMethod]
	 public void supReusableCatalogValueCreate( List<supReusableCatalogValue> items, supReusableCatalogValue item )
        {
            var apiWrapper = GetWrapper<supReusableCatalogValue>();
            apiWrapper.EntityKeyName = "supReusableCatalogValue";
            apiWrapper.EntitySetName  = "supReusableCatalogValues";
			if (item == null && items == null)
            {
				apiWrapper.Item = supReusableCatalogValueSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidReusableCatalogValue;
				var existent = Services.ApiGetByKey<supReusableCatalogValue>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supUserRoute supUserRouteSample(){
		 supUserRoute item = new supUserRoute();
            item.GuidUserRote = Guid.NewGuid();

            item.Day = Utils.GetInt();











		return item;
	}
	[TestMethod]
	 public void supUserRouteCreate( List<supUserRoute> items, supUserRoute item )
        {
            var apiWrapper = GetWrapper<supUserRoute>();
            apiWrapper.EntityKeyName = "supUserRoute";
            apiWrapper.EntitySetName  = "supUserRoutes";
			if (item == null && items == null)
            {
				apiWrapper.Item = supUserRouteSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidUserRote;
				var existent = Services.ApiGetByKey<supUserRoute>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supRouteCustomer supRouteCustomerSample(){
		 supRouteCustomer item = new supRouteCustomer();
            item.GuidRouteCustomer = Guid.NewGuid();



            item.OrderRoute = Utils.GetInt();











		return item;
	}
	[TestMethod]
	 public void supRouteCustomerCreate( List<supRouteCustomer> items, supRouteCustomer item )
        {
            var apiWrapper = GetWrapper<supRouteCustomer>();
            apiWrapper.EntityKeyName = "supRouteCustomer";
            apiWrapper.EntitySetName  = "supRouteCustomers";
			if (item == null && items == null)
            {
				apiWrapper.Item = supRouteCustomerSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidRouteCustomer;
				var existent = Services.ApiGetByKey<supRouteCustomer>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supStoreCustomer supStoreCustomerSample(){
		 supStoreCustomer item = new supStoreCustomer();
            item.GuidStoreCustomer = Guid.NewGuid();










            item.Balance = Utils.GetDecimal();


            item.CreditLimit = Utils.GetDecimal();


            item.DaysCredit = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supStoreCustomerCreate( List<supStoreCustomer> items, supStoreCustomer item )
        {
            var apiWrapper = GetWrapper<supStoreCustomer>();
            apiWrapper.EntityKeyName = "supStoreCustomer";
            apiWrapper.EntitySetName  = "supStoreCustomers";
			if (item == null && items == null)
            {
				apiWrapper.Item = supStoreCustomerSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidStoreCustomer;
				var existent = Services.ApiGetByKey<supStoreCustomer>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supStoreProduct supStoreProductSample(){
		 supStoreProduct item = new supStoreProduct();
            item.GuidStoreProduct = Guid.NewGuid();

            item.ItemsByPack = Utils.GetInt();











            item.Price = Utils.GetDecimal();


		return item;
	}
	[TestMethod]
	 public void supStoreProductCreate( List<supStoreProduct> items, supStoreProduct item )
        {
            var apiWrapper = GetWrapper<supStoreProduct>();
            apiWrapper.EntityKeyName = "supStoreProduct";
            apiWrapper.EntitySetName  = "supStoreProducts";
			if (item == null && items == null)
            {
				apiWrapper.Item = supStoreProductSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidStoreProduct;
				var existent = Services.ApiGetByKey<supStoreProduct>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supStorePromotion supStorePromotionSample(){
		 supStorePromotion item = new supStorePromotion();
            item.GuidStorePromotion = Guid.NewGuid();










		return item;
	}
	[TestMethod]
	 public void supStorePromotionCreate( List<supStorePromotion> items, supStorePromotion item )
        {
            var apiWrapper = GetWrapper<supStorePromotion>();
            apiWrapper.EntityKeyName = "supStorePromotion";
            apiWrapper.EntitySetName  = "supStorePromotions";
			if (item == null && items == null)
            {
				apiWrapper.Item = supStorePromotionSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidStorePromotion;
				var existent = Services.ApiGetByKey<supStorePromotion>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supFamilyLine supFamilyLineSample(){
		 supFamilyLine item = new supFamilyLine();
            item.GuidFamilyLine = Guid.NewGuid();










		return item;
	}
	[TestMethod]
	 public void supFamilyLineCreate( List<supFamilyLine> items, supFamilyLine item )
        {
            var apiWrapper = GetWrapper<supFamilyLine>();
            apiWrapper.EntityKeyName = "supFamilyLine";
            apiWrapper.EntitySetName  = "supFamilyLines";
			if (item == null && items == null)
            {
				apiWrapper.Item = supFamilyLineSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidFamilyLine;
				var existent = Services.ApiGetByKey<supFamilyLine>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supAgent supAgentSample(){
		 supAgent item = new supAgent();
            item.GuidAgent = Guid.NewGuid();




            item.Disabled = Utils.GetBool();








            item.IdAgent = Utils.GetInt();


		return item;
	}
	[TestMethod]
	 public void supAgentCreate( List<supAgent> items, supAgent item )
        {
            var apiWrapper = GetWrapper<supAgent>();
            apiWrapper.EntityKeyName = "supAgent";
            apiWrapper.EntitySetName  = "supAgents";
			if (item == null && items == null)
            {
				apiWrapper.Item = supAgentSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidAgent;
				var existent = Services.ApiGetByKey<supAgent>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supFamilyProvider supFamilyProviderSample(){
		 supFamilyProvider item = new supFamilyProvider();
            item.GuidFamilyProvider = Guid.NewGuid();










		return item;
	}
	[TestMethod]
	 public void supFamilyProviderCreate( List<supFamilyProvider> items, supFamilyProvider item )
        {
            var apiWrapper = GetWrapper<supFamilyProvider>();
            apiWrapper.EntityKeyName = "supFamilyProvider";
            apiWrapper.EntitySetName  = "supFamilyProviders";
			if (item == null && items == null)
            {
				apiWrapper.Item = supFamilyProviderSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidFamilyProvider;
				var existent = Services.ApiGetByKey<supFamilyProvider>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supLineMark supLineMarkSample(){
		 supLineMark item = new supLineMark();
            item.GuidLineMark = Guid.NewGuid();










		return item;
	}
	[TestMethod]
	 public void supLineMarkCreate( List<supLineMark> items, supLineMark item )
        {
            var apiWrapper = GetWrapper<supLineMark>();
            apiWrapper.EntityKeyName = "supLineMark";
            apiWrapper.EntitySetName  = "supLineMarks";
			if (item == null && items == null)
            {
				apiWrapper.Item = supLineMarkSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidLineMark;
				var existent = Services.ApiGetByKey<supLineMark>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supInvoice supInvoiceSample(){
		 supInvoice item = new supInvoice();
            item.GuidInvoice = Guid.NewGuid();

            item.IdInvoice = Utils.GetString(10);



            item.Amount = Utils.GetDecimal();


            item.Balance = Utils.GetDecimal();


            item.InvoiceDate = Utils.GetDateTime();
			

            item.SaleDate = Utils.GetDateTime();
			

            item.State = Utils.GetInt();










		return item;
	}
	[TestMethod]
	 public void supInvoiceCreate( List<supInvoice> items, supInvoice item )
        {
            var apiWrapper = GetWrapper<supInvoice>();
            apiWrapper.EntityKeyName = "supInvoice";
            apiWrapper.EntitySetName  = "supInvoices";
			if (item == null && items == null)
            {
				apiWrapper.Item = supInvoiceSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidInvoice;
				var existent = Services.ApiGetByKey<supInvoice>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProviderLine supProviderLineSample(){
		 supProviderLine item = new supProviderLine();
            item.GuidProviderLine = Guid.NewGuid();










		return item;
	}
	[TestMethod]
	 public void supProviderLineCreate( List<supProviderLine> items, supProviderLine item )
        {
            var apiWrapper = GetWrapper<supProviderLine>();
            apiWrapper.EntityKeyName = "supProviderLine";
            apiWrapper.EntitySetName  = "supProviderLines";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProviderLineSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProviderLine;
				var existent = Services.ApiGetByKey<supProviderLine>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	public supProductOption supProductOptionSample(){
		 supProductOption item = new supProductOption();
            item.GuidProductOption = Guid.NewGuid();


            item.ProductCode = Utils.GetString(10);

            item.Description = Utils.GetString(10);








		return item;
	}
	[TestMethod]
	 public void supProductOptionCreate( List<supProductOption> items, supProductOption item )
        {
            var apiWrapper = GetWrapper<supProductOption>();
            apiWrapper.EntityKeyName = "supProductOption";
            apiWrapper.EntitySetName  = "supProductOptions";
			if (item == null && items == null)
            {
				apiWrapper.Item = supProductOptionSample();
			}else{
				apiWrapper.Item = item;
                apiWrapper.Items = items;
			}
            var resultCreate  = Services.ApiCreate(url, apiWrapper);
			Assert.IsTrue(resultCreate == "ok");
			if (apiWrapper.Item != null)
            {
				apiWrapper.ItemKey = apiWrapper.Item.GuidProductOption;
				var existent = Services.ApiGetByKey<supProductOption>(url, apiWrapper);
				Assert.IsNotNull(existent);
			}
            
        }
	  }
}
