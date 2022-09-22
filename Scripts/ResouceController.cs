public class ResouceController : Controller
{
    private ResouceModel _resouceModel;

    public int gold => _resouceModel.Gold;
    public int wood => _resouceModel.Wood;
    public int stone => _resouceModel.Stone;

    public ResouceController()
    {

    }

    public override void OnCreate()
    {
        base.OnCreate();
        _resouceModel = Scene.GetInstance().GetModel<ResouceModel>();
    }

    public override void Initialize()
    {
        Resource.Initialize(this);
    }

    public bool IsEnougthGold(int value)
    {
        return gold >= value;
    }

    public void AddGold(object sender, int value)
    {
        _resouceModel.Gold += value;
        _resouceModel.Save();
    }

    public void SpendGold(object sender, int value)
    {
        _resouceModel.Gold -= value;
        _resouceModel.Save();
    }
    public void AddWood(object sender, int value)
    {
        _resouceModel.Wood += value;
        _resouceModel.Save();
    }

    public void SpendWood(object sender, int value)
    {
        _resouceModel.Wood -= value;
        _resouceModel.Save();
    }

    public void AddStone(object sender, int value)
    {
        _resouceModel.Stone += value;
        _resouceModel.Save();
    }

    public void SpendStone(object sender, int value)
    {
        _resouceModel.Stone -= value;
        _resouceModel.Save();
    }
}
