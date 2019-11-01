using example_dotnet_ef_firebird.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace example_dotnet_ef_firebird.Mapping
{
    class SMSMap
    {
        public SMSMap(EntityTypeBuilder<SMS> entityBuilder)
        {
            entityBuilder.ToTable("SMS");
            entityBuilder.HasKey(x => x.id);

            entityBuilder.Property(x => x.id).HasColumnName("ID_SMS");
            entityBuilder.Property(x => x.Origem).HasColumnName("ORIGEM_SMS");
            entityBuilder.Property(x => x.Fone).HasColumnName("FONE_SMS");
        }
    }
}
