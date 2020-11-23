using CSharp.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Api.Data
{
    public class ExistResultConfig : IEntityTypeConfiguration<ExistResult>
    {
        public void Configure(EntityTypeBuilder<ExistResult> builder)
        {
            builder.HasNoKey();
            builder.ToView("ExistResult");
        }
    }
}
