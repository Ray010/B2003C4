using Microsoft.EntityFrameworkCore.Migrations;

namespace B2003C4.Server.Migrations
{
    public partial class B2003C4Server : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokusya",
                columns: table => new
                {
                    dokuCode = table.Column<double>(nullable: false),
                    kuiki = table.Column<double>(nullable: true),
                    junro = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    addressRyaku = table.Column<string>(nullable: true),
                    banti = table.Column<string>(nullable: true),
                    tel = table.Column<string>(nullable: true),
                    build = table.Column<string>(nullable: true),
                    misebi1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokusya", x => x.dokuCode);
                });

            migrationBuilder.CreateTable(
                name: "Iri",
                columns: table => new
                {
                    dokuCode = table.Column<double>(nullable: false),
                    kuiki = table.Column<double>(nullable: true),
                    nengetu = table.Column<double>(nullable: true),
                    junro = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    tel = table.Column<string>(nullable: true),
                    meig = table.Column<string>(nullable: true),
                    iri = table.Column<string>(nullable: true),
                    tome = table.Column<string>(nullable: true),
                    tantokbn = table.Column<double>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    build = table.Column<string>(nullable: true),
                    MgCode = table.Column<double>(nullable: true),
                    MgNo = table.Column<string>(nullable: true),
                    IriRiyuu = table.Column<string>(nullable: true),
                    KeizokuTuki = table.Column<double>(nullable: true),
                    DispNengetu = table.Column<string>(nullable: true),
                    NextKeiyaku = table.Column<double>(nullable: true),
                    GaitoNo = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iri", x => x.dokuCode);
                });

            migrationBuilder.CreateTable(
                name: "Kakuzai",
                columns: table => new
                {
                    DokuCode = table.Column<double>(nullable: false),
                    MgCode = table.Column<double>(nullable: false),
                    SeqNo = table.Column<double>(nullable: false),
                    KetteisyaCD = table.Column<double>(nullable: true),
                    KetteisyaName = table.Column<string>(nullable: true),
                    KansaCd = table.Column<double>(nullable: true),
                    KansaName = table.Column<string>(nullable: true),
                    Cardryo = table.Column<double>(nullable: true),
                    HinmeiCD1 = table.Column<double>(nullable: true),
                    HinmeiName1 = table.Column<string>(nullable: true),
                    HinmeiDate1 = table.Column<string>(nullable: true),
                    HinmeiCnt1 = table.Column<double>(nullable: true),
                    HinmeiCD2 = table.Column<double>(nullable: true),
                    HinmeiName2 = table.Column<string>(nullable: true),
                    HinmeiDate2 = table.Column<string>(nullable: true),
                    HinmeiCnt2 = table.Column<double>(nullable: true),
                    HinmeiCD3 = table.Column<double>(nullable: true),
                    HinmeiName3 = table.Column<string>(nullable: true),
                    HinmeiDate3 = table.Column<string>(nullable: true),
                    HinmeiCnt3 = table.Column<double>(nullable: true),
                    HinmeiCD4 = table.Column<double>(nullable: true),
                    HinmeiName4 = table.Column<string>(nullable: true),
                    HinmeiDate4 = table.Column<string>(nullable: true),
                    HinmeiCnt4 = table.Column<double>(nullable: true),
                    HinmeiCD5 = table.Column<double>(nullable: true),
                    HinmeiName5 = table.Column<string>(nullable: true),
                    HinmeiDate5 = table.Column<string>(nullable: true),
                    HinmeiCnt5 = table.Column<double>(nullable: true),
                    HinmeiCD6 = table.Column<double>(nullable: true),
                    HinmeiName6 = table.Column<string>(nullable: true),
                    HinmeiDate6 = table.Column<string>(nullable: true),
                    HinmeiCnt6 = table.Column<double>(nullable: true),
                    HinmeiCD7 = table.Column<double>(nullable: true),
                    HinmeiName7 = table.Column<string>(nullable: true),
                    HinmeiDate7 = table.Column<string>(nullable: true),
                    HinmeiCnt7 = table.Column<double>(nullable: true),
                    HinmeiCD8 = table.Column<double>(nullable: true),
                    HinmeiName8 = table.Column<string>(nullable: true),
                    HinmeiDate8 = table.Column<string>(nullable: true),
                    HinmeiCnt8 = table.Column<double>(nullable: true),
                    HinmeiCD9 = table.Column<double>(nullable: true),
                    HinmeiName9 = table.Column<string>(nullable: true),
                    HinmeiDate9 = table.Column<string>(nullable: true),
                    HinmeiCnt9 = table.Column<double>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    MgNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kakuzai", x => new { x.DokuCode, x.MgCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "Koudoku",
                columns: table => new
                {
                    DokuCode = table.Column<double>(nullable: false),
                    OyaMgCode = table.Column<double>(nullable: false),
                    MgNo = table.Column<string>(nullable: false),
                    No = table.Column<double>(nullable: false),
                    MgCode = table.Column<double>(nullable: false),
                    MgName = table.Column<string>(nullable: true),
                    MgFullName = table.Column<string>(nullable: true),
                    KeiyakuSt = table.Column<string>(nullable: true),
                    KeiyakuEd = table.Column<string>(nullable: true),
                    KeiyakuKbn = table.Column<string>(nullable: true),
                    Keiyakusya = table.Column<string>(nullable: true),
                    KeiyakuDay = table.Column<string>(nullable: true),
                    IriRiyuu = table.Column<string>(nullable: true),
                    haitatubi = table.Column<double>(nullable: true),
                    TomeRiyuu = table.Column<string>(nullable: true),
                    TomeDay = table.Column<string>(nullable: true),
                    tukisu = table.Column<double>(nullable: true),
                    KakuzaiNo = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koudoku", x => new { x.DokuCode, x.OyaMgCode, x.MgNo, x.No, x.MgCode });
                });

            migrationBuilder.CreateTable(
                name: "Kuiki",
                columns: table => new
                {
                    kuiki = table.Column<double>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kuiki", x => x.kuiki);
                });

            migrationBuilder.CreateTable(
                name: "Nengetu",
                columns: table => new
                {
                    no = table.Column<double>(nullable: false),
                    nengetu = table.Column<double>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nengetu", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    KeyMobileNo = table.Column<string>(nullable: false),
                    FtpIp = table.Column<string>(nullable: true),
                    LicenseCount = table.Column<double>(nullable: false),
                    MobilePw = table.Column<string>(nullable: true),
                    MobileCount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.KeyMobileNo);
                });

            migrationBuilder.CreateTable(
                name: "TakeOutCount",
                columns: table => new
                {
                    Idx = table.Column<string>(nullable: false),
                    ValidTerm = table.Column<string>(nullable: true),
                    MobileCnt = table.Column<string>(nullable: true),
                    SyoriYMD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeOutCount", x => x.Idx);
                });

            migrationBuilder.CreateTable(
                name: "Tome",
                columns: table => new
                {
                    dokuCode = table.Column<double>(nullable: false),
                    kuiki = table.Column<double>(nullable: true),
                    nengetu = table.Column<double>(nullable: true),
                    junro = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    tel = table.Column<string>(nullable: true),
                    meig = table.Column<string>(nullable: true),
                    iri = table.Column<string>(nullable: true),
                    tome = table.Column<string>(nullable: true),
                    tantokbn = table.Column<double>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    build = table.Column<string>(nullable: true),
                    MgCode = table.Column<double>(nullable: true),
                    MgNo = table.Column<string>(nullable: true),
                    IriRiyuu = table.Column<string>(nullable: true),
                    KeizokuTuki = table.Column<double>(nullable: true),
                    DispNengetu = table.Column<string>(nullable: true),
                    NextKeiyaku = table.Column<double>(nullable: true),
                    GaitoNo = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tome", x => x.dokuCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokusya");

            migrationBuilder.DropTable(
                name: "Iri");

            migrationBuilder.DropTable(
                name: "Kakuzai");

            migrationBuilder.DropTable(
                name: "Koudoku");

            migrationBuilder.DropTable(
                name: "Kuiki");

            migrationBuilder.DropTable(
                name: "Nengetu");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "TakeOutCount");

            migrationBuilder.DropTable(
                name: "Tome");
        }
    }
}
