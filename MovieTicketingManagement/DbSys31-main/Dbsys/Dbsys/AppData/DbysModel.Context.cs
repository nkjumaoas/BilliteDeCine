﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Dbsys.AppData
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class DBSYSEntities : DbContext
{
    public DBSYSEntities()
        : base("name=DBSYSEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Role> Role { get; set; }

    public DbSet<UserAccount> UserAccount { get; set; }

    public DbSet<vw_all_user_role> vw_all_user_role { get; set; }

    public DbSet<SalesMaster> SalesMaster { get; set; }

    public DbSet<Movies> Movies { get; set; }

    public DbSet<SalesDetails> SalesDetails { get; set; }

    public DbSet<Ticket> Ticket { get; set; }

    public DbSet<vw_all_ticket> vw_all_ticket { get; set; }


    public virtual int sp_newUser(string username, string password, Nullable<int> roleId, Nullable<int> createdBy)
    {

        var usernameParameter = username != null ?
            new ObjectParameter("username", username) :
            new ObjectParameter("username", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var roleIdParameter = roleId.HasValue ?
            new ObjectParameter("roleId", roleId) :
            new ObjectParameter("roleId", typeof(int));


        var createdByParameter = createdBy.HasValue ?
            new ObjectParameter("createdBy", createdBy) :
            new ObjectParameter("createdBy", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_newUser", usernameParameter, passwordParameter, roleIdParameter, createdByParameter);
    }


    public virtual int InsertUserInformation(Nullable<int> movieNo, string description, string customerName, string contactNo, string emailAddress, Nullable<decimal> price, Nullable<int> quantity, Nullable<long> totalSales)
    {

        var movieNoParameter = movieNo.HasValue ?
            new ObjectParameter("MovieNo", movieNo) :
            new ObjectParameter("MovieNo", typeof(int));


        var descriptionParameter = description != null ?
            new ObjectParameter("Description", description) :
            new ObjectParameter("Description", typeof(string));


        var customerNameParameter = customerName != null ?
            new ObjectParameter("CustomerName", customerName) :
            new ObjectParameter("CustomerName", typeof(string));


        var contactNoParameter = contactNo != null ?
            new ObjectParameter("ContactNo", contactNo) :
            new ObjectParameter("ContactNo", typeof(string));


        var emailAddressParameter = emailAddress != null ?
            new ObjectParameter("EmailAddress", emailAddress) :
            new ObjectParameter("EmailAddress", typeof(string));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(decimal));


        var quantityParameter = quantity.HasValue ?
            new ObjectParameter("Quantity", quantity) :
            new ObjectParameter("Quantity", typeof(int));


        var totalSalesParameter = totalSales.HasValue ?
            new ObjectParameter("TotalSales", totalSales) :
            new ObjectParameter("TotalSales", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUserInformation", movieNoParameter, descriptionParameter, customerNameParameter, contactNoParameter, emailAddressParameter, priceParameter, quantityParameter, totalSalesParameter);
    }


    public virtual int vw_user_information(Nullable<int> movieNo, string description, string customerName, string contactNo, string emailAddress, Nullable<decimal> price, Nullable<int> quantity, Nullable<long> totalSales)
    {

        var movieNoParameter = movieNo.HasValue ?
            new ObjectParameter("MovieNo", movieNo) :
            new ObjectParameter("MovieNo", typeof(int));


        var descriptionParameter = description != null ?
            new ObjectParameter("Description", description) :
            new ObjectParameter("Description", typeof(string));


        var customerNameParameter = customerName != null ?
            new ObjectParameter("CustomerName", customerName) :
            new ObjectParameter("CustomerName", typeof(string));


        var contactNoParameter = contactNo != null ?
            new ObjectParameter("ContactNo", contactNo) :
            new ObjectParameter("ContactNo", typeof(string));


        var emailAddressParameter = emailAddress != null ?
            new ObjectParameter("EmailAddress", emailAddress) :
            new ObjectParameter("EmailAddress", typeof(string));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(decimal));


        var quantityParameter = quantity.HasValue ?
            new ObjectParameter("Quantity", quantity) :
            new ObjectParameter("Quantity", typeof(int));


        var totalSalesParameter = totalSales.HasValue ?
            new ObjectParameter("TotalSales", totalSales) :
            new ObjectParameter("TotalSales", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vw_user_information", movieNoParameter, descriptionParameter, customerNameParameter, contactNoParameter, emailAddressParameter, priceParameter, quantityParameter, totalSalesParameter);
    }


    public virtual int vw_userinformation(Nullable<int> movieNo, string description, string customerName, string contactNo, string emailAddress, Nullable<decimal> price, Nullable<int> quantity, Nullable<long> totalSales)
    {

        var movieNoParameter = movieNo.HasValue ?
            new ObjectParameter("MovieNo", movieNo) :
            new ObjectParameter("MovieNo", typeof(int));


        var descriptionParameter = description != null ?
            new ObjectParameter("Description", description) :
            new ObjectParameter("Description", typeof(string));


        var customerNameParameter = customerName != null ?
            new ObjectParameter("CustomerName", customerName) :
            new ObjectParameter("CustomerName", typeof(string));


        var contactNoParameter = contactNo != null ?
            new ObjectParameter("ContactNo", contactNo) :
            new ObjectParameter("ContactNo", typeof(string));


        var emailAddressParameter = emailAddress != null ?
            new ObjectParameter("EmailAddress", emailAddress) :
            new ObjectParameter("EmailAddress", typeof(string));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(decimal));


        var quantityParameter = quantity.HasValue ?
            new ObjectParameter("Quantity", quantity) :
            new ObjectParameter("Quantity", typeof(int));


        var totalSalesParameter = totalSales.HasValue ?
            new ObjectParameter("TotalSales", totalSales) :
            new ObjectParameter("TotalSales", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vw_userinformation", movieNoParameter, descriptionParameter, customerNameParameter, contactNoParameter, emailAddressParameter, priceParameter, quantityParameter, totalSalesParameter);
    }


    public virtual int InsertSalesDetails(Nullable<int> movie, Nullable<int> quantity, Nullable<decimal> price, Nullable<decimal> totalAmount, Nullable<int> ticketNo)
    {

        var movieParameter = movie.HasValue ?
            new ObjectParameter("Movie", movie) :
            new ObjectParameter("Movie", typeof(int));


        var quantityParameter = quantity.HasValue ?
            new ObjectParameter("Quantity", quantity) :
            new ObjectParameter("Quantity", typeof(int));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(decimal));


        var totalAmountParameter = totalAmount.HasValue ?
            new ObjectParameter("TotalAmount", totalAmount) :
            new ObjectParameter("TotalAmount", typeof(decimal));


        var ticketNoParameter = ticketNo.HasValue ?
            new ObjectParameter("TicketNo", ticketNo) :
            new ObjectParameter("TicketNo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSalesDetails", movieParameter, quantityParameter, priceParameter, totalAmountParameter, ticketNoParameter);
    }

}

}

