using project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ViewModel
{
    class ReminderViewModel
    {
        public MyICommand CreateReminderCommand { get; set; }
        public MyICommand UpdateReminderCommand { get; set; }
        public MyICommand DeleteReminderCommand { get; set; }

        public ReminderViewModel()
        {
        }
    }
}
