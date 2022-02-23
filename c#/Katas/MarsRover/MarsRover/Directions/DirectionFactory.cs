using MarsRover.Directions;

namespace MarsRover.Directions
{
    public static class DirectionFactory
    {
        public static IDirection CreateFrom(string direction)
        {
            return direction switch
            {
                "N" => new North(),
                "W" => new West(),
                "E" => new East(),
                "S" => new South(),
                _ => throw new NotSupportedException($"Direction {direction} is not supported")
            };
        }
    }
}