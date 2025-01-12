using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsAggregator.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddKeyForWordAggregationRule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AggregationRules_WordAggregationPatternId",
                table: "AggregationRules",
                column: "WordAggregationPatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_AggregationRules_WordAggregationPatterns_WordAggregationPatternId",
                table: "AggregationRules",
                column: "WordAggregationPatternId",
                principalTable: "WordAggregationPatterns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AggregationRules_WordAggregationPatterns_WordAggregationPatternId",
                table: "AggregationRules");

            migrationBuilder.DropIndex(
                name: "IX_AggregationRules_WordAggregationPatternId",
                table: "AggregationRules");
        }
    }
}
