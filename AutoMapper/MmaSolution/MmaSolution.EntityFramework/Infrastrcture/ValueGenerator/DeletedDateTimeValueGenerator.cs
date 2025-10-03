﻿namespace MmaSolution.EntityFramework.Infrastrcture.ValueGenerator;
public class DeletedDateTimeValueGenerator : ValueGenerator<DateTime?>
{
    public override DateTime? Next(EntityEntry entry)
    {
        if (entry.State == EntityState.Deleted && entry.Property("IsDeleted").CurrentValue as bool? == true)
        {
            return DateTime.UtcNow;
        }
        return null;
    }

    public override bool GeneratesTemporaryValues => false;
}