using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALC_MVC.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string contactName { get; set; }
        public string contactPhone { get; set; }
        public string contactEmail { get; set; }
        public string contactBestDatetoCall { get; set; }
        public string contactBestTimetoCall { get; set; }
        public string contactApprovalCode { get; set; }
        public string contactMessage { get; set; }
      
    }


}