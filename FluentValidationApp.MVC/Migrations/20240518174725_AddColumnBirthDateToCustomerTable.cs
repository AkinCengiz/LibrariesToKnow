﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentValidationApp.MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnBirthDateToCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Customers");
        }
    }
}
