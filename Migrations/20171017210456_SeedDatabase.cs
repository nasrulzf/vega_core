using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            String sqlInsertMake = "INSERT INTO Makes ( Name ) values ('{0}');";
            String sqlInsertModel = "INSERT INTO Models ( Name, MakeId ) values ('{0}', (select Id from Makes where Name = '{1}'));";

            migrationBuilder.Sql(String.Format(sqlInsertMake, "Make1"));
            migrationBuilder.Sql(String.Format(sqlInsertMake, "Make2"));
            migrationBuilder.Sql(String.Format(sqlInsertMake, "Make3"));

            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make1-Model1", "Make1"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make1-Model1", "Make1"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make1-Model1", "Make1"));

            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make2-Model1", "Make2"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make2-Model1", "Make2"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make2-Model1", "Make2"));

            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make3-Model1", "Make3"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make3-Model1", "Make3"));
            migrationBuilder.Sql(String.Format(sqlInsertModel, "Make3-Model1", "Make3"));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Models where MakeId in (select Id from Makes where Name in ('Make1', 'Make2', 'Make3'))");
            migrationBuilder.Sql("DELETE FROM Makes where Name in ('Make1', 'Make2', 'Make3');");            
        }
    }
}
