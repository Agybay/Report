using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenCity.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OutboxMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReportType = table.Column<int>(type: "integer", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CoverLetterCondition = table.Column<int>(type: "integer", nullable: true),
                    DocumentMimeType = table.Column<string>(type: "text", nullable: false),
                    CorrelationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Processed = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Error = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboxMessages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutboxMessages");
        }
    }
}
