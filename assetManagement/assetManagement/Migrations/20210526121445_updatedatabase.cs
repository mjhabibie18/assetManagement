using Microsoft.EntityFrameworkCore.Migrations;

namespace assetManagement.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionItems_TB_T_Condition_ConditionId",
                table: "ConditionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionItems_TB_M_Item_ItemId",
                table: "ConditionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionItems",
                table: "ConditionItems");

            migrationBuilder.RenameTable(
                name: "ConditionItems",
                newName: "TB_M_ConditionItem");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionItems_ItemId",
                table: "TB_M_ConditionItem",
                newName: "IX_TB_M_ConditionItem_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionItems_ConditionId",
                table: "TB_M_ConditionItem",
                newName: "IX_TB_M_ConditionItem_ConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_M_ConditionItem",
                table: "TB_M_ConditionItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_ConditionItem_TB_T_Condition_ConditionId",
                table: "TB_M_ConditionItem",
                column: "ConditionId",
                principalTable: "TB_T_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_ConditionItem_TB_M_Item_ItemId",
                table: "TB_M_ConditionItem",
                column: "ItemId",
                principalTable: "TB_M_Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_ConditionItem_TB_T_Condition_ConditionId",
                table: "TB_M_ConditionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_ConditionItem_TB_M_Item_ItemId",
                table: "TB_M_ConditionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_M_ConditionItem",
                table: "TB_M_ConditionItem");

            migrationBuilder.RenameTable(
                name: "TB_M_ConditionItem",
                newName: "ConditionItems");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_ConditionItem_ItemId",
                table: "ConditionItems",
                newName: "IX_ConditionItems_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_M_ConditionItem_ConditionId",
                table: "ConditionItems",
                newName: "IX_ConditionItems_ConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionItems",
                table: "ConditionItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionItems_TB_T_Condition_ConditionId",
                table: "ConditionItems",
                column: "ConditionId",
                principalTable: "TB_T_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionItems_TB_M_Item_ItemId",
                table: "ConditionItems",
                column: "ItemId",
                principalTable: "TB_M_Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
