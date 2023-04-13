using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switchables.Domain.Switches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchables.Infrastructure.Switches
{
    internal class SwitchConfiguration : IEntityTypeConfiguration<Switch>
    {
        public void Configure(EntityTypeBuilder<Switch> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.On).IsRequired().HasDefaultValue(false);
        }
    }
}
