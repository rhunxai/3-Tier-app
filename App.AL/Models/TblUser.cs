using System;
using System.Collections.Generic;

namespace App.DAL.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
