using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsAggregator.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "NotificationTemplates",
                newName: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersLogin_UserId",
                table: "UsersLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SourceNotificationSubscribes_SourceId",
                table: "SourceNotificationSubscribes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SourceNotificationSubscribes_UserId",
                table: "SourceNotificationSubscribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplates_SourceId",
                table: "NotificationTemplates",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeArticleRequestData_UserId",
                table: "ChangeArticleRequestData",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChangeArticleRequestData_Users_UserId",
                table: "ChangeArticleRequestData",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTemplates_Sources_SourceId",
                table: "NotificationTemplates",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceNotificationSubscribes_Sources_SourceId",
                table: "SourceNotificationSubscribes",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SourceNotificationSubscribes_Users_UserId",
                table: "SourceNotificationSubscribes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersLogin_Users_UserId",
                table: "UsersLogin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChangeArticleRequestData_Users_UserId",
                table: "ChangeArticleRequestData");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTemplates_Sources_SourceId",
                table: "NotificationTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceNotificationSubscribes_Sources_SourceId",
                table: "SourceNotificationSubscribes");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceNotificationSubscribes_Users_UserId",
                table: "SourceNotificationSubscribes");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersLogin_Users_UserId",
                table: "UsersLogin");

            migrationBuilder.DropIndex(
                name: "IX_UsersLogin_UserId",
                table: "UsersLogin");

            migrationBuilder.DropIndex(
                name: "IX_SourceNotificationSubscribes_SourceId",
                table: "SourceNotificationSubscribes");

            migrationBuilder.DropIndex(
                name: "IX_SourceNotificationSubscribes_UserId",
                table: "SourceNotificationSubscribes");

            migrationBuilder.DropIndex(
                name: "IX_NotificationTemplates_SourceId",
                table: "NotificationTemplates");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_ChangeArticleRequestData_UserId",
                table: "ChangeArticleRequestData");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "NotificationTemplates",
                newName: "ArticleId");
        }
    }
}
