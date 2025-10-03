﻿namespace MmaSolution.Core
{
    public class BaseEntity<T> : IAuditEntity
    {
        public T Id { get;  set; }
        public Guid? CreatedBy { get;  set; }
        public DateTime? CreatedDate { get;  set; }
        public Guid? ModifiedBy { get;  set; }
        public DateTime? ModifiedDate { get;  set; }
        public bool? IsDeleted { get;  set; }
        public Guid? DeletedBy { get;  set; }
        public DateTime? DeletedDate { get;  set; }
    }
}
