﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Data
{
    public class Packages
    {
        //Author: Yasin Habib
        public int PackgeId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }

        //Making a backup Package before updating
        public Packages PackageBackup()
        {
            Packages backup = new Packages();
            backup.PackgeId = PackgeId;
            backup.PkgName = PkgName;
            backup.PkgStartDate = PkgStartDate;
            backup.PkgEndDate = PkgEndDate;
            backup.PkgDesc = PkgDesc;
            backup.PkgBasePrice = PkgBasePrice;
            backup.PkgAgencyCommission = PkgAgencyCommission;
            return backup;
        }
    }
}
