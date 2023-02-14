﻿using System;
using System.Collections.Generic;

namespace Reports;

public partial class Customer
{
    public int CustomerId { get; set; }

    public bool NameStyle { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string? CompanyName { get; set; }

    public string? SalesPerson { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; } = new List<CustomerAddress>();

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; } = new List<SalesOrderHeader>();
}
