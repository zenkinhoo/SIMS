using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    public class AnnouncementController
    {
        AnnouncementService announcementService = new AnnouncementService();
        public bool Update(Announcement changedAnnouncement) {
            return announcementService.Update(changedAnnouncement);
        }
        public void Save(Announcement newAnnouncement)
        {
            announcementService.Save(newAnnouncement);
        }
        public void Delete(Announcement deleteAnnouncement)
        {
            announcementService.Delete(deleteAnnouncement);
        }
    }
}
