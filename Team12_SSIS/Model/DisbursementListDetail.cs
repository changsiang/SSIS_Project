namespace Team12_SSIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DisbursementListDetail
    {
        public int ID { get; set; }

        public int DisbursementID { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemID { get; set; }

        public int? ActualQuantity { get; set; }

        public int? QuantityRequested { get; set; }

        public int? QuantityCollected { get; set; }

        [StringLength(255)]
        public string UOM { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        public virtual DisbursementList DisbursementList { get; set; }

        public virtual InventoryCatalogue InventoryCatalogue { get; set; }
    }
}
