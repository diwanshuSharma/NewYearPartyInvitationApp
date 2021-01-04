using NewYearPartyInvitation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPartyInvitation.Models.DataAccess
{
    public interface IGuestRepository
    {
        GuestInfo SaveGuest(GuestInfo guestInfo);
        List<GuestInfo> GetAllGuests();
    }
}
