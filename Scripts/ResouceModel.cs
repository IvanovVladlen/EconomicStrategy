public class ResouceModel : Model
{
    public int Gold { get; set; }
    public int Wood { get; set; }
    public int Stone { get; set; }

    public override void Initialize()
    {
        Gold = 100;
        Wood = 100;
        Stone = 100;
    }

    // метод на будущее 
    public override void Save()
    {
        
    }
}
