namespace Arteon.Core.Common
{
    public static class RoomTypeHelper
    {
        public static string GetRoomTypeString(int roomTypeId)
        {
            return roomTypeId switch
            {
                1 => "Звичайний",
                2 => "Полулюкс",
                3 => "Люкс",
                _ => "Невідомо"
            };
        }
    }
}
