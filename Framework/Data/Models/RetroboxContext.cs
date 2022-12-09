using Microsoft.EntityFrameworkCore;
using Toolkit.Foundation;

namespace Data
{
    public class RetroboxContext : DbContext, IInitializable
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<PlatformFamily> PlatformFamilies { get; set; }

        public RetroboxContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=test.db");
        }

        public async Task InitializeAsync()
        {
            await Database.MigrateAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlatformFamily>().HasData(new PlatformFamily { Id = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652"), Name = "Atari" },
                new PlatformFamily { Id = new Guid("0DECC41D-4572-4C29-ACF1-71F015A60271"), Name = "Commodore" },
                new PlatformFamily { Id = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187"), Name = "Nintendo" },
                new PlatformFamily { Id = new Guid("188D8BBF-9409-4B60-BA46-962A41272220"), Name = "Other" },
                new PlatformFamily { Id = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447"), Name = "PlayStation" },
                new PlatformFamily { Id = new Guid("50260204-167A-47EA-A9E7-97C55711F02D"), Name = "Sega" },
                new PlatformFamily { Id = new Guid("58659264-61A8-476A-ACB5-948DC65F638A"), Name = "Xbox" });
            
            modelBuilder.Entity<Platform>().HasData(new Platform { Id = new Guid("4098C8BF-895E-4D6A-A218-53691A798689"), Name = "3DO", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("6EE2A004-C0EF-4F26-B2A2-D07FA0E9E4F5"), Name = "Arcade", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("8CC47E09-6AC1-4108-99CE-038463861D48"), Name = "Atari 2600", FamilyId = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652") },
                new Platform { Id = new Guid("874461F9-9D6D-42F7-B4F6-D4BD24DB2A52"), Name = "Atari 5200", FamilyId = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652") },
                new Platform { Id = new Guid("3472484E-80AE-4BA9-A3AA-9B04E8A9A140"), Name = "Atari 7800", FamilyId = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652") },
                new Platform { Id = new Guid("E570D238-FBDA-4B30-B7F6-1E119611744B"), Name = "Atari Jaguar", FamilyId = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652") },
                new Platform { Id = new Guid("1E3B9C54-893C-4AA4-9F7C-B023D99327FC"), Name = "Atari Lynx", FamilyId = new Guid("F87CDFB8-4A4A-46DD-B299-35CDC4989652") },
                new Platform { Id = new Guid("6AA76185-ECFF-4BD4-BCCC-64A6DB187346"), Name = "ColecoVision", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("634F1FF7-676E-4B74-868B-A3735C5E640A"), Name = "Commodore 64", FamilyId = new Guid("0DECC41D-4572-4C29-ACF1-71F015A60271") },
                new Platform { Id = new Guid("AA423D51-A65E-41A7-ABA4-37D21F3C24E4"), Name = "Commodore Amiga", FamilyId = new Guid("0DECC41D-4572-4C29-ACF1-71F015A60271") },
                new Platform { Id = new Guid("B5AECD72-2341-419C-8E37-DEB310E0F0CD"), Name = "Famicom", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("A728D061-2B61-43DB-94CA-4CDEDC7D12EA"), Name = "Game Boy", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("DAC9980E-8F60-40E6-9C07-41A2A54A7AF2"), Name = "Game Boy Advance", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("55AE0B01-9628-4B3F-94DC-CDADF83D8FE1"), Name = "Google Stadia", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("AEFCDD4C-78B1-4C8B-B7E7-6B1D2C0E3326"), Name = "Intellivision", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("F5BD6BCA-9153-4072-A393-ABDBC48E38AF"), Name = "Magnavox Odyssey", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("4F350651-1CE6-49A7-94C2-AA5A95D4BF58"), Name = "Mobile Devices", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("1DAA870E-6B9E-468B-B25B-80DC78C9B2D6"), Name = "N-Gage", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("78E25C31-DC73-4D21-B7CC-B278AF708A36"), Name = "Neo Geo", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("F52F7EE5-AC8E-4492-9C4F-C1E345E3348B"), Name = "Nintendo 3DS", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("19682024-3656-4ED6-BF35-981961C46519"), Name = "Nintendo 64", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("8352EC10-FF36-4DA3-815D-720BDA4DD55C"), Name = "Nintendo DS", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("476A47DA-0AFA-4D3C-9F0F-E62DAAF5F5B4"), Name = "Nintendo Entertainment System", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("6E8C742D-A7B5-43E6-9E9C-4A0B95F61205"), Name = "Nintendo GameCube", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("5770ABA7-86DB-4C0D-9032-7EF25D25364A"), Name = "Nintendo Switch", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("5E97B8E8-909B-4ACF-8CB1-54CCD949E27A"), Name = "Oculus Quest", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("B1812FAB-AA29-4550-9BC3-4E21BDCF347F"), Name = "Oculus Rift", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("8782AB71-97D5-4E15-8BE3-9E6A99444682"), Name = "PC", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("926C779A-7D7F-4CE9-9B82-9B7BA13D4480"), Name = "PlayStation", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("87C71D93-FA6F-437F-87E6-E803F0AC1998"), Name = "PlayStation 2", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("74E1686D-998F-4CC9-830A-C3A6D8883A09"), Name = "PlayStation 3", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("B31FC5CA-053D-4932-97F0-7305D4040C32"), Name = "PlayStation 4", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("275FF961-7DB8-41AF-A1CE-82D834B92F70"), Name = "PlayStation 5", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("5AB09C01-3229-44C8-B754-9B93C096D665"), Name = "PlayStation Portable (PSP)", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("78D5A146-0B0B-49C8-981D-EFD984760EB0"), Name = "PlayStation Vita", FamilyId = new Guid("DE6C97F9-4D0E-4F29-9D0B-B43423B18447") },
                new Platform { Id = new Guid("73E444B4-00AA-483C-87A5-C375D5E501B2"), Name = "Sega 32x", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("CCF7101E-1361-469D-A4B4-C1BF8120D9CB"), Name = "Sega CD", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("B851F6FD-1197-4DD1-8B14-78FD6EA266D1"), Name = "Sega Dreamcast", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("370F84D8-2C3D-487F-998B-83E94FB1B43B"), Name = "Sega Game Gear", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("B5055FF3-2498-4CB2-A233-58CC60143D92"), Name = "Sega Genesis", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("11794B62-33D4-4AC9-A690-3A9B42AEC909"), Name = "Sega Master System", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("80FA596A-683A-479D-97BC-C6A1B8A492DC"), Name = "Sega Saturn", FamilyId = new Guid("50260204-167A-47EA-A9E7-97C55711F02D") },
                new Platform { Id = new Guid("2CB76FD5-5E97-4446-9846-15E20E39950A"), Name = "Super Famicom", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("C96F13F3-662C-4F63-9704-E90C0CC8D34B"), Name = "Super Nintendo Entertainment System", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("6760EEAE-EDE2-43A3-B64B-9A8D450F81F2"), Name = "TurboGrafx-16", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("03A63B2B-6848-48F3-B513-D4AD76F32554"), Name = "VIC-20", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") },
                new Platform { Id = new Guid("C7B92277-3B71-4A0E-94CE-4AFA4EB0AAB3"), Name = "Wii", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("17321AE1-E7F0-415E-91A0-3283D92E2D18"), Name = "Wii U", FamilyId = new Guid("179348AF-C199-4810-ABBB-98A8D6A40187") },
                new Platform { Id = new Guid("0374EB77-6199-4B52-9B2F-03096D782253"), Name = "Xbox", FamilyId = new Guid("58659264-61A8-476A-ACB5-948DC65F638A") },
                new Platform { Id = new Guid("C89AB82E-654D-43CF-B76B-BCA785CB3B0F"), Name = "Xbox 360", FamilyId = new Guid("58659264-61A8-476A-ACB5-948DC65F638A") },
                new Platform { Id = new Guid("CDA4604D-1DC8-4860-80E7-E198D9D2457F"), Name = "Xbox One", FamilyId = new Guid("58659264-61A8-476A-ACB5-948DC65F638A") },
                new Platform { Id = new Guid("B0623FA7-337C-4A5F-A024-015AE4DF6E1C"), Name = "Xbox Series X/S", FamilyId = new Guid("58659264-61A8-476A-ACB5-948DC65F638A") },
                new Platform { Id = new Guid("699F47F5-9E7F-437E-B10D-757C4AF584EB"), Name = "ZX Spectrum", FamilyId = new Guid("188D8BBF-9409-4B60-BA46-962A41272220") });

            base.OnModelCreating(modelBuilder);
        }
    }
}
