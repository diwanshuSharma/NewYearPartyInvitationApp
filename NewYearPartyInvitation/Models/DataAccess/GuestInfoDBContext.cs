using NewYearPartyInvitation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewYearPartyInvitation.Models.DataAccess
{
    public class GuestInfoDBContext : DbContext
    {
        public GuestInfoDBContext() : base("GuestInfoDB")
        {

        }
        public DbSet<GuestInfo> GuestInfos { get; set; }
    }
}