using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Tahalil.API.Data.SeedData
{
    public class AnalSeedData : IEntityTypeConfiguration<Anal>
    {
        public void Configure(EntityTypeBuilder<Anal> builder)
        {
            builder.Property(e => e.codeAnal)
                    .HasMaxLength(10);

            List<Anal> anals;
            anals = new List<Anal> {
                new Anal {Id = 01,codeAnal = "2301000001", PrescriptId = 01, UserId = 4,Jour = new DateTime(2023,01,01), Mnt = 25000 },
                new Anal {Id = 02,codeAnal = "2301000002", PrescriptId = 01, UserId = 4,Jour = new DateTime(2023,01,01), Mnt = 05000 },
                new Anal {Id = 03,codeAnal = "2301000003", PrescriptId = 02, UserId = 4,Jour = new DateTime(2023,01,01), Mnt = 15000 },
                new Anal {Id = 04,codeAnal = "2301000004", PrescriptId = 02, UserId = 5,Jour = new DateTime(2023,01,03), Mnt = 07500 },
                new Anal {Id = 05,codeAnal = "2301000005", PrescriptId = 01, UserId = 6,Jour = new DateTime(2023,01,03), Mnt = 08000 },
                new Anal {Id = 06,codeAnal = "2301000006", PrescriptId = 02, UserId = 4,Jour = new DateTime(2023,01,03), Mnt = 02500 },
                new Anal {Id = 07,codeAnal = "2301000007", PrescriptId = 01, UserId = 5,Jour = new DateTime(2023,01,03), Mnt = 00500 },
                new Anal {Id = 08,codeAnal = "2301000008", PrescriptId = 02, UserId = 4,Jour = new DateTime(2023,01,03), Mnt = 00300 },
                new Anal {Id = 09,codeAnal = "2301000009", PrescriptId = 02, UserId = 6,Jour = new DateTime(2023,01,15), Mnt = 01200 },
                new Anal {Id = 10,codeAnal = "2301000010", PrescriptId = 02, UserId = 6,Jour = new DateTime(2023,01,15), Mnt = 01600 },
                new Anal {Id = 11,codeAnal = "2301000011", PrescriptId = 01, UserId = 5,Jour = new DateTime(2023,01,15), Mnt = 25000 },
            };
          
            builder.HasData(anals);
        }
    }
}
