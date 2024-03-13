using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Content.Server.Database.Migrations.Postgres
{
    /// <inheritdoc />
    public partial class VulpkaninTailMarkingRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"
                UPDATE profile
                SET markings = REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(markings,
                    'VulpTailWag', 'VulpTail'),
                    'VulpTailWagTip', 'VulpTailTip'),
                    'VulpTailFoxWag', 'VulpTailFox'),
                    'VulpTailFoxWagTip', 'VulpTailFoxTip'),
                    'VulpTailBushyWag', 'VulpTailBushy'),
                    'VulpTailCoyoteWag', 'VulpTailCoyote'),
                    'VulpTailCorgiWag', 'VulpTailCorgi'),
                    'VulpTailDalmationWag', 'VulpTailDalmation')
                WHERE species = 'Vulpkanin';
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
