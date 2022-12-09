using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlatformFamilies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformFamilies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platforms_PlatformFamilies_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "PlatformFamilies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    PlatformId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlatformFamilies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0decc41d-4572-4c29-acf1-71f015a60271"), "Commodore" },
                    { new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo" },
                    { new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Other" },
                    { new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega" },
                    { new Guid("58659264-61a8-476a-acb5-948dc65f638a"), "Xbox" },
                    { new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation" },
                    { new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("0374eb77-6199-4b52-9b2f-03096d782253"), new Guid("58659264-61a8-476a-acb5-948dc65f638a"), "Xbox" },
                    { new Guid("03a63b2b-6848-48f3-b513-d4ad76f32554"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "VIC-20" },
                    { new Guid("11794b62-33d4-4ac9-a690-3a9b42aec909"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega Master System" },
                    { new Guid("17321ae1-e7f0-415e-91a0-3283d92e2d18"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Wii U" },
                    { new Guid("19682024-3656-4ed6-bf35-981961c46519"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo 64" },
                    { new Guid("1daa870e-6b9e-468b-b25b-80dc78c9b2d6"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "N-Gage" },
                    { new Guid("1e3b9c54-893c-4aa4-9f7c-b023d99327fc"), new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari Lynx" },
                    { new Guid("275ff961-7db8-41af-a1ce-82d834b92f70"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation 5" },
                    { new Guid("2cb76fd5-5e97-4446-9846-15e20e39950a"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Super Famicom" },
                    { new Guid("3472484e-80ae-4ba9-a3aa-9b04e8a9a140"), new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari 7800" },
                    { new Guid("370f84d8-2c3d-487f-998b-83e94fb1b43b"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega Game Gear" },
                    { new Guid("4098c8bf-895e-4d6a-a218-53691a798689"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "3DO" },
                    { new Guid("476a47da-0afa-4d3c-9f0f-e62daaf5f5b4"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo Entertainment System" },
                    { new Guid("4f350651-1ce6-49a7-94c2-aa5a95d4bf58"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Mobile Devices" },
                    { new Guid("55ae0b01-9628-4b3f-94dc-cdadf83d8fe1"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Google Stadia" },
                    { new Guid("5770aba7-86db-4c0d-9032-7ef25d25364a"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo Switch" },
                    { new Guid("5ab09c01-3229-44c8-b754-9b93c096d665"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation Portable (PSP)" },
                    { new Guid("5e97b8e8-909b-4acf-8cb1-54ccd949e27a"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Oculus Quest" },
                    { new Guid("634f1ff7-676e-4b74-868b-a3735c5e640a"), new Guid("0decc41d-4572-4c29-acf1-71f015a60271"), "Commodore 64" },
                    { new Guid("6760eeae-ede2-43a3-b64b-9a8d450f81f2"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "TurboGrafx-16" },
                    { new Guid("699f47f5-9e7f-437e-b10d-757c4af584eb"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "ZX Spectrum" },
                    { new Guid("6aa76185-ecff-4bd4-bccc-64a6db187346"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "ColecoVision" },
                    { new Guid("6e8c742d-a7b5-43e6-9e9c-4a0b95f61205"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo GameCube" },
                    { new Guid("6ee2a004-c0ef-4f26-b2a2-d07fa0e9e4f5"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Arcade" },
                    { new Guid("73e444b4-00aa-483c-87a5-c375d5e501b2"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega 32x" },
                    { new Guid("74e1686d-998f-4cc9-830a-c3a6d8883a09"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation 3" },
                    { new Guid("78d5a146-0b0b-49c8-981d-efd984760eb0"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation Vita" },
                    { new Guid("78e25c31-dc73-4d21-b7cc-b278af708a36"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Neo Geo" },
                    { new Guid("80fa596a-683a-479d-97bc-c6a1b8a492dc"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega Saturn" },
                    { new Guid("8352ec10-ff36-4da3-815d-720bda4dd55c"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo DS" },
                    { new Guid("874461f9-9d6d-42f7-b4f6-d4bd24db2a52"), new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari 5200" },
                    { new Guid("8782ab71-97d5-4e15-8be3-9e6a99444682"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "PC" },
                    { new Guid("87c71d93-fa6f-437f-87e6-e803f0ac1998"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation 2" },
                    { new Guid("8cc47e09-6ac1-4108-99ce-038463861d48"), new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari 2600" },
                    { new Guid("926c779a-7d7f-4ce9-9b82-9b7ba13d4480"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation" },
                    { new Guid("a728d061-2b61-43db-94ca-4cdedc7d12ea"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Game Boy" },
                    { new Guid("aa423d51-a65e-41a7-aba4-37d21f3c24e4"), new Guid("0decc41d-4572-4c29-acf1-71f015a60271"), "Commodore Amiga" },
                    { new Guid("aefcdd4c-78b1-4c8b-b7e7-6b1d2c0e3326"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Intellivision" },
                    { new Guid("b0623fa7-337c-4a5f-a024-015ae4df6e1c"), new Guid("58659264-61a8-476a-acb5-948dc65f638a"), "Xbox Series X/S" },
                    { new Guid("b1812fab-aa29-4550-9bc3-4e21bdcf347f"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Oculus Rift" },
                    { new Guid("b31fc5ca-053d-4932-97f0-7305d4040c32"), new Guid("de6c97f9-4d0e-4f29-9d0b-b43423b18447"), "PlayStation 4" },
                    { new Guid("b5055ff3-2498-4cb2-a233-58cc60143d92"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega Genesis" },
                    { new Guid("b5aecd72-2341-419c-8e37-deb310e0f0cd"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Famicom" },
                    { new Guid("b851f6fd-1197-4dd1-8b14-78fd6ea266d1"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega Dreamcast" },
                    { new Guid("c7b92277-3b71-4a0e-94ce-4afa4eb0aab3"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Wii" },
                    { new Guid("c89ab82e-654d-43cf-b76b-bca785cb3b0f"), new Guid("58659264-61a8-476a-acb5-948dc65f638a"), "Xbox 360" },
                    { new Guid("c96f13f3-662c-4f63-9704-e90c0cc8d34b"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Super Nintendo Entertainment System" },
                    { new Guid("ccf7101e-1361-469d-a4b4-c1bf8120d9cb"), new Guid("50260204-167a-47ea-a9e7-97c55711f02d"), "Sega CD" },
                    { new Guid("cda4604d-1dc8-4860-80e7-e198d9d2457f"), new Guid("58659264-61a8-476a-acb5-948dc65f638a"), "Xbox One" },
                    { new Guid("dac9980e-8f60-40e6-9c07-41a2a54a7af2"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Game Boy Advance" },
                    { new Guid("e570d238-fbda-4b30-b7f6-1e119611744b"), new Guid("f87cdfb8-4a4a-46dd-b299-35cdc4989652"), "Atari Jaguar" },
                    { new Guid("f52f7ee5-ac8e-4492-9c4f-c1e345e3348b"), new Guid("179348af-c199-4810-abbb-98a8d6a40187"), "Nintendo 3DS" },
                    { new Guid("f5bd6bca-9153-4072-a393-abdbc48e38af"), new Guid("188d8bbf-9409-4b60-ba46-962a41272220"), "Magnavox Odyssey" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_FamilyId",
                table: "Platforms",
                column: "FamilyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "PlatformFamilies");
        }
    }
}
