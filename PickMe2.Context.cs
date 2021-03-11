﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PickMe2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PickMe2Entities : DbContext
    {
        public PickMe2Entities()
            : base("name=PickMe2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CompanyDB> CompanyDBs { get; set; }
        public virtual DbSet<EmployeeDB> EmployeeDBs { get; set; }
        public virtual DbSet<VehiclesDB> VehiclesDBs { get; set; }
        public virtual DbSet<DriversDB> DriversDBs { get; set; }
    
        public virtual int CompanyInsert(Nullable<int> company_id, string company_name, string company_address, string company_vendor_name, string company_email, string company_contact)
        {
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var company_nameParameter = company_name != null ?
                new ObjectParameter("Company_name", company_name) :
                new ObjectParameter("Company_name", typeof(string));
    
            var company_addressParameter = company_address != null ?
                new ObjectParameter("Company_address", company_address) :
                new ObjectParameter("Company_address", typeof(string));
    
            var company_vendor_nameParameter = company_vendor_name != null ?
                new ObjectParameter("Company_vendor_name", company_vendor_name) :
                new ObjectParameter("Company_vendor_name", typeof(string));
    
            var company_emailParameter = company_email != null ?
                new ObjectParameter("Company_email", company_email) :
                new ObjectParameter("Company_email", typeof(string));
    
            var company_contactParameter = company_contact != null ?
                new ObjectParameter("Company_contact", company_contact) :
                new ObjectParameter("Company_contact", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CompanyInsert", company_idParameter, company_nameParameter, company_addressParameter, company_vendor_nameParameter, company_emailParameter, company_contactParameter);
        }
    
        public virtual ObjectResult<CompanyDB> CompanyAdd(Nullable<int> company_id, string company_name, string company_address, string company_vendor_name, string company_email, string company_contact)
        {
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var company_nameParameter = company_name != null ?
                new ObjectParameter("Company_name", company_name) :
                new ObjectParameter("Company_name", typeof(string));
    
            var company_addressParameter = company_address != null ?
                new ObjectParameter("Company_address", company_address) :
                new ObjectParameter("Company_address", typeof(string));
    
            var company_vendor_nameParameter = company_vendor_name != null ?
                new ObjectParameter("Company_vendor_name", company_vendor_name) :
                new ObjectParameter("Company_vendor_name", typeof(string));
    
            var company_emailParameter = company_email != null ?
                new ObjectParameter("Company_email", company_email) :
                new ObjectParameter("Company_email", typeof(string));
    
            var company_contactParameter = company_contact != null ?
                new ObjectParameter("Company_contact", company_contact) :
                new ObjectParameter("Company_contact", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CompanyDB>("CompanyAdd", company_idParameter, company_nameParameter, company_addressParameter, company_vendor_nameParameter, company_emailParameter, company_contactParameter);
        }
    
        public virtual ObjectResult<CompanyDB> CompanyAdd(Nullable<int> company_id, string company_name, string company_address, string company_vendor_name, string company_email, string company_contact, MergeOption mergeOption)
        {
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var company_nameParameter = company_name != null ?
                new ObjectParameter("Company_name", company_name) :
                new ObjectParameter("Company_name", typeof(string));
    
            var company_addressParameter = company_address != null ?
                new ObjectParameter("Company_address", company_address) :
                new ObjectParameter("Company_address", typeof(string));
    
            var company_vendor_nameParameter = company_vendor_name != null ?
                new ObjectParameter("Company_vendor_name", company_vendor_name) :
                new ObjectParameter("Company_vendor_name", typeof(string));
    
            var company_emailParameter = company_email != null ?
                new ObjectParameter("Company_email", company_email) :
                new ObjectParameter("Company_email", typeof(string));
    
            var company_contactParameter = company_contact != null ?
                new ObjectParameter("Company_contact", company_contact) :
                new ObjectParameter("Company_contact", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CompanyDB>("CompanyAdd", mergeOption, company_idParameter, company_nameParameter, company_addressParameter, company_vendor_nameParameter, company_emailParameter, company_contactParameter);
        }
    
        public virtual int DriverInsertUpdate(Nullable<int> driver_id, string driver_name, string driver_address, string driver_Pan, string driver_license, string company_contact, string driver_photo)
        {
            var driver_idParameter = driver_id.HasValue ?
                new ObjectParameter("Driver_id", driver_id) :
                new ObjectParameter("Driver_id", typeof(int));
    
            var driver_nameParameter = driver_name != null ?
                new ObjectParameter("Driver_name", driver_name) :
                new ObjectParameter("Driver_name", typeof(string));
    
            var driver_addressParameter = driver_address != null ?
                new ObjectParameter("Driver_address", driver_address) :
                new ObjectParameter("Driver_address", typeof(string));
    
            var driver_PanParameter = driver_Pan != null ?
                new ObjectParameter("Driver_Pan", driver_Pan) :
                new ObjectParameter("Driver_Pan", typeof(string));
    
            var driver_licenseParameter = driver_license != null ?
                new ObjectParameter("Driver_license", driver_license) :
                new ObjectParameter("Driver_license", typeof(string));
    
            var company_contactParameter = company_contact != null ?
                new ObjectParameter("Company_contact", company_contact) :
                new ObjectParameter("Company_contact", typeof(string));
    
            var driver_photoParameter = driver_photo != null ?
                new ObjectParameter("Driver_photo", driver_photo) :
                new ObjectParameter("Driver_photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DriverInsertUpdate", driver_idParameter, driver_nameParameter, driver_addressParameter, driver_PanParameter, driver_licenseParameter, company_contactParameter, driver_photoParameter);
        }
    
        public virtual int DriverAddUpdate(Nullable<int> driver_id, string driver_name, string driver_address, string driver_Pan, string driver_license, string company_contact, string driver_photo)
        {
            var driver_idParameter = driver_id.HasValue ?
                new ObjectParameter("Driver_id", driver_id) :
                new ObjectParameter("Driver_id", typeof(int));
    
            var driver_nameParameter = driver_name != null ?
                new ObjectParameter("Driver_name", driver_name) :
                new ObjectParameter("Driver_name", typeof(string));
    
            var driver_addressParameter = driver_address != null ?
                new ObjectParameter("Driver_address", driver_address) :
                new ObjectParameter("Driver_address", typeof(string));
    
            var driver_PanParameter = driver_Pan != null ?
                new ObjectParameter("Driver_Pan", driver_Pan) :
                new ObjectParameter("Driver_Pan", typeof(string));
    
            var driver_licenseParameter = driver_license != null ?
                new ObjectParameter("Driver_license", driver_license) :
                new ObjectParameter("Driver_license", typeof(string));
    
            var company_contactParameter = company_contact != null ?
                new ObjectParameter("Company_contact", company_contact) :
                new ObjectParameter("Company_contact", typeof(string));
    
            var driver_photoParameter = driver_photo != null ?
                new ObjectParameter("Driver_photo", driver_photo) :
                new ObjectParameter("Driver_photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DriverAddUpdate", driver_idParameter, driver_nameParameter, driver_addressParameter, driver_PanParameter, driver_licenseParameter, company_contactParameter, driver_photoParameter);
        }
    
        public virtual int EmployeeInsert(Nullable<int> emp_id, Nullable<int> company_id, string emp_fname, string emp_lname, string emp_contact, string emp_email, string emp_address)
        {
            var emp_idParameter = emp_id.HasValue ?
                new ObjectParameter("Emp_id", emp_id) :
                new ObjectParameter("Emp_id", typeof(int));
    
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var emp_fnameParameter = emp_fname != null ?
                new ObjectParameter("Emp_fname", emp_fname) :
                new ObjectParameter("Emp_fname", typeof(string));
    
            var emp_lnameParameter = emp_lname != null ?
                new ObjectParameter("Emp_lname", emp_lname) :
                new ObjectParameter("Emp_lname", typeof(string));
    
            var emp_contactParameter = emp_contact != null ?
                new ObjectParameter("Emp_contact", emp_contact) :
                new ObjectParameter("Emp_contact", typeof(string));
    
            var emp_emailParameter = emp_email != null ?
                new ObjectParameter("Emp_email", emp_email) :
                new ObjectParameter("Emp_email", typeof(string));
    
            var emp_addressParameter = emp_address != null ?
                new ObjectParameter("Emp_address", emp_address) :
                new ObjectParameter("Emp_address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmployeeInsert", emp_idParameter, company_idParameter, emp_fnameParameter, emp_lnameParameter, emp_contactParameter, emp_emailParameter, emp_addressParameter);
        }
    
        public virtual ObjectResult<EmployeeDB> EmployeeAdd(Nullable<int> emp_id, Nullable<int> company_id, string emp_fname, string emp_lname, string emp_contact, string emp_email, string emp_address)
        {
            var emp_idParameter = emp_id.HasValue ?
                new ObjectParameter("Emp_id", emp_id) :
                new ObjectParameter("Emp_id", typeof(int));
    
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var emp_fnameParameter = emp_fname != null ?
                new ObjectParameter("Emp_fname", emp_fname) :
                new ObjectParameter("Emp_fname", typeof(string));
    
            var emp_lnameParameter = emp_lname != null ?
                new ObjectParameter("Emp_lname", emp_lname) :
                new ObjectParameter("Emp_lname", typeof(string));
    
            var emp_contactParameter = emp_contact != null ?
                new ObjectParameter("Emp_contact", emp_contact) :
                new ObjectParameter("Emp_contact", typeof(string));
    
            var emp_emailParameter = emp_email != null ?
                new ObjectParameter("Emp_email", emp_email) :
                new ObjectParameter("Emp_email", typeof(string));
    
            var emp_addressParameter = emp_address != null ?
                new ObjectParameter("Emp_address", emp_address) :
                new ObjectParameter("Emp_address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmployeeDB>("EmployeeAdd", emp_idParameter, company_idParameter, emp_fnameParameter, emp_lnameParameter, emp_contactParameter, emp_emailParameter, emp_addressParameter);
        }
    
        public virtual ObjectResult<EmployeeDB> EmployeeAdd(Nullable<int> emp_id, Nullable<int> company_id, string emp_fname, string emp_lname, string emp_contact, string emp_email, string emp_address, MergeOption mergeOption)
        {
            var emp_idParameter = emp_id.HasValue ?
                new ObjectParameter("Emp_id", emp_id) :
                new ObjectParameter("Emp_id", typeof(int));
    
            var company_idParameter = company_id.HasValue ?
                new ObjectParameter("Company_id", company_id) :
                new ObjectParameter("Company_id", typeof(int));
    
            var emp_fnameParameter = emp_fname != null ?
                new ObjectParameter("Emp_fname", emp_fname) :
                new ObjectParameter("Emp_fname", typeof(string));
    
            var emp_lnameParameter = emp_lname != null ?
                new ObjectParameter("Emp_lname", emp_lname) :
                new ObjectParameter("Emp_lname", typeof(string));
    
            var emp_contactParameter = emp_contact != null ?
                new ObjectParameter("Emp_contact", emp_contact) :
                new ObjectParameter("Emp_contact", typeof(string));
    
            var emp_emailParameter = emp_email != null ?
                new ObjectParameter("Emp_email", emp_email) :
                new ObjectParameter("Emp_email", typeof(string));
    
            var emp_addressParameter = emp_address != null ?
                new ObjectParameter("Emp_address", emp_address) :
                new ObjectParameter("Emp_address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmployeeDB>("EmployeeAdd", mergeOption, emp_idParameter, company_idParameter, emp_fnameParameter, emp_lnameParameter, emp_contactParameter, emp_emailParameter, emp_addressParameter);
        }
    }
}
