using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCA.Migrations
{
    public partial class JobTaskadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RewardPKR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartingReward = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompletionProofs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StallionComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetAudienceLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberStallionsRequired = table.Column<int>(type: "int", nullable: false),
                    TaskCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetStallionSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedDurationOfTask = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsRelatedToMarketing = table.Column<bool>(type: "bit", nullable: false),
                    TargetAudience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaChannels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedOutputResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTasks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTasks");
        }
    }
}
