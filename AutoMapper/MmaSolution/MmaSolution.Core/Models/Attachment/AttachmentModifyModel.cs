﻿namespace MmaSolution.Core.Models.Attachment
{
    public partial class AttachmentModifyModel
    {
        public string AttachmentName { get; set; }
        public string FilePath { get; set; }
        public decimal? FileSize { get; set; }
        public string ContentType { get; set; }
        public string Key { get; set; }
        public Guid Id { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}