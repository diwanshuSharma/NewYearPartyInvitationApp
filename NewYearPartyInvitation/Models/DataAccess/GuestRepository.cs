using NewYearPartyInvitation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYearPartyInvitation.Models.DataAccess
{
    public class GuestRepository : IGuestRepository
    {
        private GuestInfoDBContext db = new GuestInfoDBContext();

        public List<GuestInfo> GetAllGuests()
        {
            return db.GuestInfos.ToList();
        }

        public GuestInfo SaveGuest(GuestInfo guestInfo)
        {
            db.GuestInfos.Add(guestInfo);
            db.SaveChanges();
            return guestInfo;
        }
    }
}