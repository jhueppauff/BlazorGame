namespace BlazorGame.Model
{
    public class Token
    {
        public int Row { get; set; }
        
        public int Column { get; set; }

        public Color Color { get; set; }
        
        public Direction Direction { get; set; }
    } 
}
