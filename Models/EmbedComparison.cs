using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;

namespace EmbedComparison.Models
{
    public class EmbedComparisonRecord : ContentPartRecord
    {
        public virtual String EmbedKey { get; set; }
        public virtual String Guid { get; set; }
        public virtual int FrameWidth { get; set; }
        public virtual int FrameHeight { get; set; }
    }

    public class EmbedComparisonPart : ContentPart<EmbedComparisonRecord>
    {
        [Required]
        [DisplayName("Embed Key")]
        public String EmbedKey
        {
            get { return Record.EmbedKey; }
            set { Record.EmbedKey = value; }
        }

        [Required]
        [DisplayName("Compare Guid")]
        public String Guid
        {
            get { return Record.Guid; }
            set { Record.Guid = value; }
        }

        [DisplayName("Frame Width")]
        public int FrameWidth
        {
            get { return Record.FrameWidth; }
            set { Record.FrameWidth = value; }
        }

        [DisplayName("Frame Height")]
        public int FrameHeight
        {
            get { return Record.FrameHeight; }
            set { Record.FrameHeight = value; }
        }
    }
}
