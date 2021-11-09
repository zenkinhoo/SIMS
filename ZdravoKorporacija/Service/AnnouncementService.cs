using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    public class AnnouncementService
    {
        AnnouncementRepository announcementRepository = new AnnouncementRepository();
        public bool Update(Announcement changedAnnouncement)
        {
            Announcement oldAnnouncement = announcementRepository.GetOne(changedAnnouncement.Id);
            String oldRow = oldAnnouncement.Id + "," + oldAnnouncement.Title + "," + oldAnnouncement.Text + "," + oldAnnouncement.Date;
            String newRow = changedAnnouncement.Id + "," + changedAnnouncement.Title + "," + changedAnnouncement.Text + "," + changedAnnouncement.Date;
            return announcementRepository.UpdateRowInFile(oldRow, newRow);
        }
        public void Save(Announcement newAnnouncement) {
            announcementRepository.Save(newAnnouncement);
        }
        public void Delete(Announcement delteAnnouncement) {
            String deleteRow = delteAnnouncement.Id + "," + delteAnnouncement.Title + "," + delteAnnouncement.Text + "," + delteAnnouncement.Date;
            announcementRepository.DeleteRowInFile(deleteRow);
        }
    }
}
