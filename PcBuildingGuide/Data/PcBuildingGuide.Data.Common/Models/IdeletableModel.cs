namespace PcBuildingGuide.Data.Common.Models
{
    using System;

    public interface IdeletableModel
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
