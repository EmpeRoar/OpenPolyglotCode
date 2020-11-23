using CSharp.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Api.Data
{
    public class TestItemConfig : IEntityTypeConfiguration<TestItem>
    {
        public void Configure(EntityTypeBuilder<TestItem> builder)
        {
            builder.ToTable("TestItem", Constant.DEFAULT_SCHEMA);
            builder.HasKey(k => new { k.ID });

            builder.Property(p => p.Name).HasMaxLength(255);
        }
    }
}
