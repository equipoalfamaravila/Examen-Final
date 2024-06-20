﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentas
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BDVentas")]
	public partial class VentasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertBoleta(Boleta instance);
    partial void UpdateBoleta(Boleta instance);
    partial void DeleteBoleta(Boleta instance);
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertDetalle(Detalle instance);
    partial void UpdateDetalle(Detalle instance);
    partial void DeleteDetalle(Detalle instance);
    partial void InsertProducto(Producto instance);
    partial void UpdateProducto(Producto instance);
    partial void DeleteProducto(Producto instance);
    partial void InsertVendedor(Vendedor instance);
    partial void UpdateVendedor(Vendedor instance);
    partial void DeleteVendedor(Vendedor instance);
    #endregion
		
		public VentasDataContext() : 
				base(global::SistemaVentas.Properties.Settings.Default.BDVentasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Boleta> Boleta
		{
			get
			{
				return this.GetTable<Boleta>();
			}
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Detalle> Detalle
		{
			get
			{
				return this.GetTable<Detalle>();
			}
		}
		
		public System.Data.Linq.Table<Producto> Producto
		{
			get
			{
				return this.GetTable<Producto>();
			}
		}
		
		public System.Data.Linq.Table<Vendedor> Vendedor
		{
			get
			{
				return this.GetTable<Vendedor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBoleta")]
	public partial class Boleta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NroBoleta;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private string _CodCliente;
		
		private string _CodVendedor;
		
		private System.Nullable<bool> _Anulado;
		
		private EntitySet<Detalle> _Detalle;
		
		private EntityRef<Cliente> _Cliente;
		
		private EntityRef<Vendedor> _Vendedor;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNroBoletaChanging(int value);
    partial void OnNroBoletaChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    partial void OnCodClienteChanging(string value);
    partial void OnCodClienteChanged();
    partial void OnCodVendedorChanging(string value);
    partial void OnCodVendedorChanged();
    partial void OnAnuladoChanging(System.Nullable<bool> value);
    partial void OnAnuladoChanged();
    #endregion
		
		public Boleta()
		{
			this._Detalle = new EntitySet<Detalle>(new Action<Detalle>(this.attach_Detalle), new Action<Detalle>(this.detach_Detalle));
			this._Cliente = default(EntityRef<Cliente>);
			this._Vendedor = default(EntityRef<Vendedor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NroBoleta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NroBoleta
		{
			get
			{
				return this._NroBoleta;
			}
			set
			{
				if ((this._NroBoleta != value))
				{
					this.OnNroBoletaChanging(value);
					this.SendPropertyChanging();
					this._NroBoleta = value;
					this.SendPropertyChanged("NroBoleta");
					this.OnNroBoletaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodCliente", DbType="Char(5)")]
		public string CodCliente
		{
			get
			{
				return this._CodCliente;
			}
			set
			{
				if ((this._CodCliente != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodClienteChanging(value);
					this.SendPropertyChanging();
					this._CodCliente = value;
					this.SendPropertyChanged("CodCliente");
					this.OnCodClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodVendedor", DbType="Char(5)")]
		public string CodVendedor
		{
			get
			{
				return this._CodVendedor;
			}
			set
			{
				if ((this._CodVendedor != value))
				{
					if (this._Vendedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodVendedorChanging(value);
					this.SendPropertyChanging();
					this._CodVendedor = value;
					this.SendPropertyChanged("CodVendedor");
					this.OnCodVendedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anulado", DbType="Bit")]
		public System.Nullable<bool> Anulado
		{
			get
			{
				return this._Anulado;
			}
			set
			{
				if ((this._Anulado != value))
				{
					this.OnAnuladoChanging(value);
					this.SendPropertyChanging();
					this._Anulado = value;
					this.SendPropertyChanged("Anulado");
					this.OnAnuladoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoleta_TDetalle", Storage="_Detalle", ThisKey="NroBoleta", OtherKey="NroBoleta")]
		public EntitySet<Detalle> Detalle
		{
			get
			{
				return this._Detalle;
			}
			set
			{
				this._Detalle.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCliente_TBoleta", Storage="_Cliente", ThisKey="CodCliente", OtherKey="CodCliente", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Boleta.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Boleta.Add(this);
						this._CodCliente = value.CodCliente;
					}
					else
					{
						this._CodCliente = default(string);
					}
					this.SendPropertyChanged("Cliente");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TVendedor_TBoleta", Storage="_Vendedor", ThisKey="CodVendedor", OtherKey="CodVendedor", IsForeignKey=true)]
		public Vendedor Vendedor
		{
			get
			{
				return this._Vendedor.Entity;
			}
			set
			{
				Vendedor previousValue = this._Vendedor.Entity;
				if (((previousValue != value) 
							|| (this._Vendedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Vendedor.Entity = null;
						previousValue.Boleta.Remove(this);
					}
					this._Vendedor.Entity = value;
					if ((value != null))
					{
						value.Boleta.Add(this);
						this._CodVendedor = value.CodVendedor;
					}
					else
					{
						this._CodVendedor = default(string);
					}
					this.SendPropertyChanged("Vendedor");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Detalle(Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Boleta = this;
		}
		
		private void detach_Detalle(Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Boleta = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TCategoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CodCategoria;
		
		private string _Nombre;
		
		private string _CategoriaPadre;
		
		private EntitySet<Categoria> _Categoria1;
		
		private EntitySet<Producto> _Producto;
		
		private EntityRef<Categoria> _TCategoria1;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodCategoriaChanging(string value);
    partial void OnCodCategoriaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnCategoriaPadreChanging(string value);
    partial void OnCategoriaPadreChanged();
    #endregion
		
		public Categoria()
		{
			this._Categoria1 = new EntitySet<Categoria>(new Action<Categoria>(this.attach_Categoria1), new Action<Categoria>(this.detach_Categoria1));
			this._Producto = new EntitySet<Producto>(new Action<Producto>(this.attach_Producto), new Action<Producto>(this.detach_Producto));
			this._TCategoria1 = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodCategoria", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodCategoria
		{
			get
			{
				return this._CodCategoria;
			}
			set
			{
				if ((this._CodCategoria != value))
				{
					this.OnCodCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodCategoria = value;
					this.SendPropertyChanged("CodCategoria");
					this.OnCodCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoriaPadre", DbType="Char(5)")]
		public string CategoriaPadre
		{
			get
			{
				return this._CategoriaPadre;
			}
			set
			{
				if ((this._CategoriaPadre != value))
				{
					if (this._TCategoria1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoriaPadreChanging(value);
					this.SendPropertyChanging();
					this._CategoriaPadre = value;
					this.SendPropertyChanged("CategoriaPadre");
					this.OnCategoriaPadreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategoria_TCategoria", Storage="_Categoria1", ThisKey="CodCategoria", OtherKey="CategoriaPadre")]
		public EntitySet<Categoria> Categoria1
		{
			get
			{
				return this._Categoria1;
			}
			set
			{
				this._Categoria1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategoria_TProducto", Storage="_Producto", ThisKey="CodCategoria", OtherKey="CodCategoria")]
		public EntitySet<Producto> Producto
		{
			get
			{
				return this._Producto;
			}
			set
			{
				this._Producto.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategoria_TCategoria", Storage="_TCategoria1", ThisKey="CategoriaPadre", OtherKey="CodCategoria", IsForeignKey=true)]
		public Categoria TCategoria1
		{
			get
			{
				return this._TCategoria1.Entity;
			}
			set
			{
				Categoria previousValue = this._TCategoria1.Entity;
				if (((previousValue != value) 
							|| (this._TCategoria1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TCategoria1.Entity = null;
						previousValue.Categoria1.Remove(this);
					}
					this._TCategoria1.Entity = value;
					if ((value != null))
					{
						value.Categoria1.Add(this);
						this._CategoriaPadre = value.CodCategoria;
					}
					else
					{
						this._CategoriaPadre = default(string);
					}
					this.SendPropertyChanged("TCategoria1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Categoria1(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.TCategoria1 = this;
		}
		
		private void detach_Categoria1(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.TCategoria1 = null;
		}
		
		private void attach_Producto(Producto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Producto(Producto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TCliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CodCliente;
		
		private string _Apellidos;
		
		private string _Nombres;
		
		private string _Direccion;
		
		private EntitySet<Boleta> _Boleta;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodClienteChanging(string value);
    partial void OnCodClienteChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnNombresChanging(string value);
    partial void OnNombresChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    #endregion
		
		public Cliente()
		{
			this._Boleta = new EntitySet<Boleta>(new Action<Boleta>(this.attach_Boleta), new Action<Boleta>(this.detach_Boleta));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodCliente", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodCliente
		{
			get
			{
				return this._CodCliente;
			}
			set
			{
				if ((this._CodCliente != value))
				{
					this.OnCodClienteChanging(value);
					this.SendPropertyChanging();
					this._CodCliente = value;
					this.SendPropertyChanged("CodCliente");
					this.OnCodClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50)")]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombres", DbType="VarChar(50)")]
		public string Nombres
		{
			get
			{
				return this._Nombres;
			}
			set
			{
				if ((this._Nombres != value))
				{
					this.OnNombresChanging(value);
					this.SendPropertyChanging();
					this._Nombres = value;
					this.SendPropertyChanged("Nombres");
					this.OnNombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCliente_TBoleta", Storage="_Boleta", ThisKey="CodCliente", OtherKey="CodCliente")]
		public EntitySet<Boleta> Boleta
		{
			get
			{
				return this._Boleta;
			}
			set
			{
				this._Boleta.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Boleta(Boleta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Boleta(Boleta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TDetalle")]
	public partial class Detalle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NroBoleta;
		
		private string _CodProducto;
		
		private System.Nullable<int> _Cantidad;
		
		private System.Nullable<decimal> _PrecioUnitario;
		
		private EntityRef<Boleta> _Boleta;
		
		private EntityRef<Producto> _Producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNroBoletaChanging(int value);
    partial void OnNroBoletaChanged();
    partial void OnCodProductoChanging(string value);
    partial void OnCodProductoChanged();
    partial void OnCantidadChanging(System.Nullable<int> value);
    partial void OnCantidadChanged();
    partial void OnPrecioUnitarioChanging(System.Nullable<decimal> value);
    partial void OnPrecioUnitarioChanged();
    #endregion
		
		public Detalle()
		{
			this._Boleta = default(EntityRef<Boleta>);
			this._Producto = default(EntityRef<Producto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NroBoleta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NroBoleta
		{
			get
			{
				return this._NroBoleta;
			}
			set
			{
				if ((this._NroBoleta != value))
				{
					if (this._Boleta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNroBoletaChanging(value);
					this.SendPropertyChanging();
					this._NroBoleta = value;
					this.SendPropertyChanged("NroBoleta");
					this.OnNroBoletaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodProducto", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodProducto
		{
			get
			{
				return this._CodProducto;
			}
			set
			{
				if ((this._CodProducto != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodProductoChanging(value);
					this.SendPropertyChanging();
					this._CodProducto = value;
					this.SendPropertyChanged("CodProducto");
					this.OnCodProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Int")]
		public System.Nullable<int> Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this.OnCantidadChanging(value);
					this.SendPropertyChanging();
					this._Cantidad = value;
					this.SendPropertyChanged("Cantidad");
					this.OnCantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioUnitario", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> PrecioUnitario
		{
			get
			{
				return this._PrecioUnitario;
			}
			set
			{
				if ((this._PrecioUnitario != value))
				{
					this.OnPrecioUnitarioChanging(value);
					this.SendPropertyChanging();
					this._PrecioUnitario = value;
					this.SendPropertyChanged("PrecioUnitario");
					this.OnPrecioUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoleta_TDetalle", Storage="_Boleta", ThisKey="NroBoleta", OtherKey="NroBoleta", IsForeignKey=true)]
		public Boleta Boleta
		{
			get
			{
				return this._Boleta.Entity;
			}
			set
			{
				Boleta previousValue = this._Boleta.Entity;
				if (((previousValue != value) 
							|| (this._Boleta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Boleta.Entity = null;
						previousValue.Detalle.Remove(this);
					}
					this._Boleta.Entity = value;
					if ((value != null))
					{
						value.Detalle.Add(this);
						this._NroBoleta = value.NroBoleta;
					}
					else
					{
						this._NroBoleta = default(int);
					}
					this.SendPropertyChanged("Boleta");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProducto_TDetalle", Storage="_Producto", ThisKey="CodProducto", OtherKey="CodProduto", IsForeignKey=true)]
		public Producto Producto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				Producto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.Detalle.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.Detalle.Add(this);
						this._CodProducto = value.CodProduto;
					}
					else
					{
						this._CodProducto = default(string);
					}
					this.SendPropertyChanged("Producto");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TProducto")]
	public partial class Producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CodProduto;
		
		private string _Nombre;
		
		private string _UnidadDeMedida;
		
		private System.Nullable<decimal> _Precio;
		
		private System.Nullable<int> _Stock;
		
		private string _CodCategoria;
		
		private EntitySet<Detalle> _Detalle;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodProdutoChanging(string value);
    partial void OnCodProdutoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnUnidadDeMedidaChanging(string value);
    partial void OnUnidadDeMedidaChanged();
    partial void OnPrecioChanging(System.Nullable<decimal> value);
    partial void OnPrecioChanged();
    partial void OnStockChanging(System.Nullable<int> value);
    partial void OnStockChanged();
    partial void OnCodCategoriaChanging(string value);
    partial void OnCodCategoriaChanged();
    #endregion
		
		public Producto()
		{
			this._Detalle = new EntitySet<Detalle>(new Action<Detalle>(this.attach_Detalle), new Action<Detalle>(this.detach_Detalle));
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodProduto", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodProduto
		{
			get
			{
				return this._CodProduto;
			}
			set
			{
				if ((this._CodProduto != value))
				{
					this.OnCodProdutoChanging(value);
					this.SendPropertyChanging();
					this._CodProduto = value;
					this.SendPropertyChanged("CodProduto");
					this.OnCodProdutoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnidadDeMedida", DbType="VarChar(50)")]
		public string UnidadDeMedida
		{
			get
			{
				return this._UnidadDeMedida;
			}
			set
			{
				if ((this._UnidadDeMedida != value))
				{
					this.OnUnidadDeMedidaChanging(value);
					this.SendPropertyChanging();
					this._UnidadDeMedida = value;
					this.SendPropertyChanged("UnidadDeMedida");
					this.OnUnidadDeMedidaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock", DbType="Int")]
		public System.Nullable<int> Stock
		{
			get
			{
				return this._Stock;
			}
			set
			{
				if ((this._Stock != value))
				{
					this.OnStockChanging(value);
					this.SendPropertyChanging();
					this._Stock = value;
					this.SendPropertyChanged("Stock");
					this.OnStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodCategoria", DbType="Char(5)")]
		public string CodCategoria
		{
			get
			{
				return this._CodCategoria;
			}
			set
			{
				if ((this._CodCategoria != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodCategoria = value;
					this.SendPropertyChanged("CodCategoria");
					this.OnCodCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProducto_TDetalle", Storage="_Detalle", ThisKey="CodProduto", OtherKey="CodProducto")]
		public EntitySet<Detalle> Detalle
		{
			get
			{
				return this._Detalle;
			}
			set
			{
				this._Detalle.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategoria_TProducto", Storage="_Categoria", ThisKey="CodCategoria", OtherKey="CodCategoria", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Producto.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Producto.Add(this);
						this._CodCategoria = value.CodCategoria;
					}
					else
					{
						this._CodCategoria = default(string);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Detalle(Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Producto = this;
		}
		
		private void detach_Detalle(Detalle entity)
		{
			this.SendPropertyChanging();
			entity.Producto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TVendedor")]
	public partial class Vendedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CodVendedor;
		
		private string _Apellidos;
		
		private string _Nombres;
		
		private EntitySet<Boleta> _Boleta;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodVendedorChanging(string value);
    partial void OnCodVendedorChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnNombresChanging(string value);
    partial void OnNombresChanged();
    #endregion
		
		public Vendedor()
		{
			this._Boleta = new EntitySet<Boleta>(new Action<Boleta>(this.attach_Boleta), new Action<Boleta>(this.detach_Boleta));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodVendedor", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodVendedor
		{
			get
			{
				return this._CodVendedor;
			}
			set
			{
				if ((this._CodVendedor != value))
				{
					this.OnCodVendedorChanging(value);
					this.SendPropertyChanging();
					this._CodVendedor = value;
					this.SendPropertyChanged("CodVendedor");
					this.OnCodVendedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50)")]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombres", DbType="VarChar(50)")]
		public string Nombres
		{
			get
			{
				return this._Nombres;
			}
			set
			{
				if ((this._Nombres != value))
				{
					this.OnNombresChanging(value);
					this.SendPropertyChanging();
					this._Nombres = value;
					this.SendPropertyChanged("Nombres");
					this.OnNombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TVendedor_TBoleta", Storage="_Boleta", ThisKey="CodVendedor", OtherKey="CodVendedor")]
		public EntitySet<Boleta> Boleta
		{
			get
			{
				return this._Boleta;
			}
			set
			{
				this._Boleta.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Boleta(Boleta entity)
		{
			this.SendPropertyChanging();
			entity.Vendedor = this;
		}
		
		private void detach_Boleta(Boleta entity)
		{
			this.SendPropertyChanging();
			entity.Vendedor = null;
		}
	}
}
#pragma warning restore 1591
