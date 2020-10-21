using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChaosInitiative.Web.ControlPanel.Model
{
    [Table("Releases")]
    public class Release
    {
        [Key]
        public Game Game { get; set; }
        [Key]
        public int VersionId { get; set; }
        public List<Feature> Features { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}