using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UlkemWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Inıt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogYazisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotografUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogYazisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CicekTuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CicekTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GonderimAmaci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GonderimAmaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IletisimFormu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GonderimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimFormu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kampanya",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndirimOrani = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampanya", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OzelGun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzelGun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeslimatBolgesi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeslimatUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeslimatBolgesi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cicek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotografUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CicekTuruId = table.Column<int>(type: "int", nullable: false),
                    KampanyaId = table.Column<int>(type: "int", nullable: true),
                    OzelGunId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cicek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cicek_CicekTuru_CicekTuruId",
                        column: x => x.CicekTuruId,
                        principalTable: "CicekTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cicek_Kampanya_KampanyaId",
                        column: x => x.KampanyaId,
                        principalTable: "Kampanya",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cicek_OzelGun_OzelGunId",
                        column: x => x.OzelGunId,
                        principalTable: "OzelGun",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SepetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanici_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CicekGonderimAmaci",
                columns: table => new
                {
                    CiceklerId = table.Column<int>(type: "int", nullable: false),
                    GonderimAmaclariId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CicekGonderimAmaci", x => new { x.CiceklerId, x.GonderimAmaclariId });
                    table.ForeignKey(
                        name: "FK_CicekGonderimAmaci_Cicek_CiceklerId",
                        column: x => x.CiceklerId,
                        principalTable: "Cicek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CicekGonderimAmaci_GonderimAmaci_GonderimAmaclariId",
                        column: x => x.GonderimAmaclariId,
                        principalTable: "GonderimAmaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KargoFiyati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicekId = table.Column<int>(type: "int", nullable: false),
                    TeslimatBolgesiId = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoFiyati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KargoFiyati_Cicek_CicekId",
                        column: x => x.CicekId,
                        principalTable: "Cicek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KargoFiyati_TeslimatBolgesi_TeslimatBolgesiId",
                        column: x => x.TeslimatBolgesiId,
                        principalTable: "TeslimatBolgesi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SepetUrunu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SepetId = table.Column<int>(type: "int", nullable: false),
                    CicekId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    ToplamFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepetUrunu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SepetUrunu_Cicek_CicekId",
                        column: x => x.CicekId,
                        principalTable: "Cicek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SepetUrunu_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicekId = table.Column<int>(type: "int", nullable: false),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puan = table.Column<int>(type: "int", nullable: false),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogYazisiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorum_BlogYazisi_BlogYazisiId",
                        column: x => x.BlogYazisiId,
                        principalTable: "BlogYazisi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Yorum_Cicek_CicekId",
                        column: x => x.CicekId,
                        principalTable: "Cicek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparis_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SiparisUrunu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    CicekId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    ToplamFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisUrunu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiparisUrunu_Cicek_CicekId",
                        column: x => x.CicekId,
                        principalTable: "Cicek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisUrunu_Siparis_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cicek_CicekTuruId",
                table: "Cicek",
                column: "CicekTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Cicek_KampanyaId",
                table: "Cicek",
                column: "KampanyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cicek_OzelGunId",
                table: "Cicek",
                column: "OzelGunId");

            migrationBuilder.CreateIndex(
                name: "IX_CicekGonderimAmaci_GonderimAmaclariId",
                table: "CicekGonderimAmaci",
                column: "GonderimAmaclariId");

            migrationBuilder.CreateIndex(
                name: "IX_KargoFiyati_CicekId",
                table: "KargoFiyati",
                column: "CicekId");

            migrationBuilder.CreateIndex(
                name: "IX_KargoFiyati_TeslimatBolgesiId",
                table: "KargoFiyati",
                column: "TeslimatBolgesiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_SepetId",
                table: "Kullanici",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_SepetUrunu_CicekId",
                table: "SepetUrunu",
                column: "CicekId");

            migrationBuilder.CreateIndex(
                name: "IX_SepetUrunu_SepetId",
                table: "SepetUrunu",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_KullaniciId",
                table: "Siparis",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisUrunu_CicekId",
                table: "SiparisUrunu",
                column: "CicekId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisUrunu_SiparisId",
                table: "SiparisUrunu",
                column: "SiparisId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_BlogYazisiId",
                table: "Yorum",
                column: "BlogYazisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_CicekId",
                table: "Yorum",
                column: "CicekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CicekGonderimAmaci");

            migrationBuilder.DropTable(
                name: "Hakkimizda");

            migrationBuilder.DropTable(
                name: "IletisimFormu");

            migrationBuilder.DropTable(
                name: "KargoFiyati");

            migrationBuilder.DropTable(
                name: "SepetUrunu");

            migrationBuilder.DropTable(
                name: "SiparisUrunu");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "GonderimAmaci");

            migrationBuilder.DropTable(
                name: "TeslimatBolgesi");

            migrationBuilder.DropTable(
                name: "Siparis");

            migrationBuilder.DropTable(
                name: "BlogYazisi");

            migrationBuilder.DropTable(
                name: "Cicek");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "CicekTuru");

            migrationBuilder.DropTable(
                name: "Kampanya");

            migrationBuilder.DropTable(
                name: "OzelGun");

            migrationBuilder.DropTable(
                name: "Sepet");
        }
    }
}
