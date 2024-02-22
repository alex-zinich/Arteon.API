using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arteon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM Rooms)
                BEGIN
                    DELETE FROM RoomTypes;
                    DBCC CHECKIDENT ('RoomTypes', RESEED, 1);
                    INSERT INTO RoomTypes (Name)
                    VALUES
                        (N'Звичайний'),
                        (N'Напівлюкс'),
                        (N'Люкс');
                    INSERT INTO Rooms (Id, RoomTypeId, RoomNumber, Occupacity, PricePerDay, CreatedOn, ModifiedOn)
                    VALUES 
                        (NEWID(), 1, 101, 1, 1000, GETDATE(), GETDATE()),
                        (NEWID(), 1, 102, 2, 1200, GETDATE(), GETDATE()),
                        (NEWID(), 1, 103, 3, 1400, GETDATE(), GETDATE()),
                        (NEWID(), 1, 104, 4, 1600, GETDATE(), GETDATE()),
                        (NEWID(), 1, 105, 5, 1800, GETDATE(), GETDATE()),
                        (NEWID(), 2, 201, 1, 1400, GETDATE(), GETDATE()),
                        (NEWID(), 2, 202, 2, 1800, GETDATE(), GETDATE()),
                        (NEWID(), 2, 203, 3, 2200, GETDATE(), GETDATE()),
                        (NEWID(), 2, 204, 4, 2600, GETDATE(), GETDATE()),
                        (NEWID(), 2, 205, 5, 3000, GETDATE(), GETDATE()),
                        (NEWID(), 3, 301, 1, 1800, GETDATE(), GETDATE()),
                        (NEWID(), 3, 302, 2, 2300, GETDATE(), GETDATE()),
                        (NEWID(), 3, 303, 3, 2800, GETDATE(), GETDATE()),
                        (NEWID(), 3, 304, 4, 3300, GETDATE(), GETDATE()),
                        (NEWID(), 3, 305, 5, 3800, GETDATE(), GETDATE());
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM Services)
                BEGIN
                    INSERT INTO Services (Id, PricePerDay, Name, CreatedOn, ModifiedOn)
                    VALUES
                        (NEWID(), 150, N'Користування басейном', GETDATE(), GETDATE()),
                        (NEWID(), 100, N'Користування спортивним залом', GETDATE(), GETDATE()),
                        (NEWID(), 200, N'Сніданок', GETDATE(), GETDATE()),
                        (NEWID(), 250, N'Оренда конференц-зали', GETDATE(), GETDATE()),
                        (NEWID(), 50, N'Доступ до Wi-Fi', GETDATE(), GETDATE()),
                        (NEWID(), 125, N'Парковка', GETDATE(), GETDATE());
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Rooms;
                DELETE FROM RoomTypes;
                DBCC CHECKIDENT ('RoomTypes', RESEED, 1);
            ");
        }
    }
}
