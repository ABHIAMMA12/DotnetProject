﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce_Udemy_Practice.Migrations
{
    /// <inheritdoc />
    public partial class firststep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    QuantityInStock = table.Column<int>(type: "integer", nullable: false),
                    PublicId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
