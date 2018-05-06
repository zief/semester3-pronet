﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kantinAmikom
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="kantinAmikom")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertmenu(menu instance);
    partial void Updatemenu(menu instance);
    partial void Deletemenu(menu instance);
    partial void Insertpedagang(pedagang instance);
    partial void Updatepedagang(pedagang instance);
    partial void Deletepedagang(pedagang instance);
    partial void Inserttransaksi(transaksi instance);
    partial void Updatetransaksi(transaksi instance);
    partial void Deletetransaksi(transaksi instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::kantinAmikom.Properties.Settings.Default.sqlconnection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<admin> admins
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<detailTransaksi> detailTransaksis
		{
			get
			{
				return this.GetTable<detailTransaksi>();
			}
		}
		
		public System.Data.Linq.Table<menu> menus
		{
			get
			{
				return this.GetTable<menu>();
			}
		}
		
		public System.Data.Linq.Table<pedagang> pedagangs
		{
			get
			{
				return this.GetTable<pedagang>();
			}
		}
		
		public System.Data.Linq.Table<transaksi> transaksis
		{
			get
			{
				return this.GetTable<transaksi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userId;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(string value);
    partial void OnuserIdChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idCustomer;
		
		private string _namaCustomer;
		
		private int _nominalIsi;
		
		private EntitySet<transaksi> _transaksis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCustomerChanging(string value);
    partial void OnidCustomerChanged();
    partial void OnnamaCustomerChanging(string value);
    partial void OnnamaCustomerChanged();
    partial void OnnominalIsiChanging(int value);
    partial void OnnominalIsiChanged();
    #endregion
		
		public customer()
		{
			this._transaksis = new EntitySet<transaksi>(new Action<transaksi>(this.attach_transaksis), new Action<transaksi>(this.detach_transaksis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCustomer", DbType="VarChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idCustomer
		{
			get
			{
				return this._idCustomer;
			}
			set
			{
				if ((this._idCustomer != value))
				{
					this.OnidCustomerChanging(value);
					this.SendPropertyChanging();
					this._idCustomer = value;
					this.SendPropertyChanged("idCustomer");
					this.OnidCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namaCustomer", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string namaCustomer
		{
			get
			{
				return this._namaCustomer;
			}
			set
			{
				if ((this._namaCustomer != value))
				{
					this.OnnamaCustomerChanging(value);
					this.SendPropertyChanging();
					this._namaCustomer = value;
					this.SendPropertyChanged("namaCustomer");
					this.OnnamaCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nominalIsi", DbType="Int NOT NULL")]
		public int nominalIsi
		{
			get
			{
				return this._nominalIsi;
			}
			set
			{
				if ((this._nominalIsi != value))
				{
					this.OnnominalIsiChanging(value);
					this.SendPropertyChanging();
					this._nominalIsi = value;
					this.SendPropertyChanged("nominalIsi");
					this.OnnominalIsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_transaksi", Storage="_transaksis", ThisKey="idCustomer", OtherKey="idCustomer")]
		public EntitySet<transaksi> transaksis
		{
			get
			{
				return this._transaksis;
			}
			set
			{
				this._transaksis.Assign(value);
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
		
		private void attach_transaksis(transaksi entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_transaksis(transaksi entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.detailTransaksi")]
	public partial class detailTransaksi
	{
		
		private string _idTransaksi;
		
		private string _idMenu;
		
		public detailTransaksi()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTransaksi", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string idTransaksi
		{
			get
			{
				return this._idTransaksi;
			}
			set
			{
				if ((this._idTransaksi != value))
				{
					this._idTransaksi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMenu", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string idMenu
		{
			get
			{
				return this._idMenu;
			}
			set
			{
				if ((this._idMenu != value))
				{
					this._idMenu = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.menu")]
	public partial class menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idMenu;
		
		private string _namaMenu;
		
		private int _harga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidMenuChanging(string value);
    partial void OnidMenuChanged();
    partial void OnnamaMenuChanging(string value);
    partial void OnnamaMenuChanged();
    partial void OnhargaChanging(int value);
    partial void OnhargaChanged();
    #endregion
		
		public menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMenu", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idMenu
		{
			get
			{
				return this._idMenu;
			}
			set
			{
				if ((this._idMenu != value))
				{
					this.OnidMenuChanging(value);
					this.SendPropertyChanging();
					this._idMenu = value;
					this.SendPropertyChanged("idMenu");
					this.OnidMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namaMenu", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string namaMenu
		{
			get
			{
				return this._namaMenu;
			}
			set
			{
				if ((this._namaMenu != value))
				{
					this.OnnamaMenuChanging(value);
					this.SendPropertyChanging();
					this._namaMenu = value;
					this.SendPropertyChanged("namaMenu");
					this.OnnamaMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_harga", DbType="Int NOT NULL")]
		public int harga
		{
			get
			{
				return this._harga;
			}
			set
			{
				if ((this._harga != value))
				{
					this.OnhargaChanging(value);
					this.SendPropertyChanging();
					this._harga = value;
					this.SendPropertyChanged("harga");
					this.OnhargaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pedagang")]
	public partial class pedagang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nama;
		
		private string _alamat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnalamatChanging(string value);
    partial void OnalamatChanged();
    #endregion
		
		public pedagang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alamat", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string alamat
		{
			get
			{
				return this._alamat;
			}
			set
			{
				if ((this._alamat != value))
				{
					this.OnalamatChanging(value);
					this.SendPropertyChanging();
					this._alamat = value;
					this.SendPropertyChanged("alamat");
					this.OnalamatChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.transaksi")]
	public partial class transaksi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idTransaksi;
		
		private string _tglTransaksi;
		
		private string _idCustomer;
		
		private System.Nullable<int> _total;
		
		private EntityRef<customer> _customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTransaksiChanging(string value);
    partial void OnidTransaksiChanged();
    partial void OntglTransaksiChanging(string value);
    partial void OntglTransaksiChanged();
    partial void OnidCustomerChanging(string value);
    partial void OnidCustomerChanged();
    partial void OntotalChanging(System.Nullable<int> value);
    partial void OntotalChanged();
    #endregion
		
		public transaksi()
		{
			this._customer = default(EntityRef<customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTransaksi", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idTransaksi
		{
			get
			{
				return this._idTransaksi;
			}
			set
			{
				if ((this._idTransaksi != value))
				{
					this.OnidTransaksiChanging(value);
					this.SendPropertyChanging();
					this._idTransaksi = value;
					this.SendPropertyChanged("idTransaksi");
					this.OnidTransaksiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tglTransaksi", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string tglTransaksi
		{
			get
			{
				return this._tglTransaksi;
			}
			set
			{
				if ((this._tglTransaksi != value))
				{
					this.OntglTransaksiChanging(value);
					this.SendPropertyChanging();
					this._tglTransaksi = value;
					this.SendPropertyChanged("tglTransaksi");
					this.OntglTransaksiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCustomer", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string idCustomer
		{
			get
			{
				return this._idCustomer;
			}
			set
			{
				if ((this._idCustomer != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCustomerChanging(value);
					this.SendPropertyChanging();
					this._idCustomer = value;
					this.SendPropertyChanged("idCustomer");
					this.OnidCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Int")]
		public System.Nullable<int> total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this.OntotalChanging(value);
					this.SendPropertyChanging();
					this._total = value;
					this.SendPropertyChanged("total");
					this.OntotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_transaksi", Storage="_customer", ThisKey="idCustomer", OtherKey="idCustomer", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.transaksis.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.transaksis.Add(this);
						this._idCustomer = value.idCustomer;
					}
					else
					{
						this._idCustomer = default(string);
					}
					this.SendPropertyChanged("customer");
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
}
#pragma warning restore 1591
