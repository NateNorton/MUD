namespace Mud
{
    // Class holds the index of a room and provides a coordinate position within the room
    public class Position 
    {
        public uint Room { get; set; } = 0;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Position() {}
        public Position(uint room) 
        { 
            this.Room = room; 
        }
        public Position(uint room, int x, int y)
        {
            this.Room = room; this.X = X; this.Y = y;
        }
    }
}