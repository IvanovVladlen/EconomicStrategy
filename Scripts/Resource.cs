using System;

public static class Resource
{
    public static event Action OnResourceInitializedEvent;
    private static ResouceController _resouceController;

    public static int Gold 
    {
        get
        {
            CheckInitialized();
            return _resouceController.gold;
        }
    }
    public static int Wood
    {
        get
        {
            CheckInitialized();
            return _resouceController.wood;
        }
    }
    public static int Stone
    {
        get
        {
            CheckInitialized();
            return _resouceController.stone;
        }
    }

    public static bool IsInitialized { get; private set; }

    public static void Initialize(ResouceController resouceController)
    {
        _resouceController = resouceController;
        IsInitialized = true;
        OnResourceInitializedEvent?.Invoke();
    }

    public static bool IsEnougthGold(int value)
    {
        CheckInitialized();
        return _resouceController.IsEnougthGold(value);
    }

    public static void AddGold(object sender, int value)
    {
        CheckInitialized();
        _resouceController.AddGold(sender, value);
    }

    public static void SpendGold(object sender, int value)
    {
        CheckInitialized();
        _resouceController.SpendGold(sender, value);
    }
    public static void AddWood(object sender, int value)
    {
        CheckInitialized();
        _resouceController.AddWood(sender, value);
    }

    public static void SpendWood(object sender, int value)
    {
        CheckInitialized();
        _resouceController.SpendWood(sender, value);
    }

    public static void AddStone(object sender, int value)
    {
        CheckInitialized();
        _resouceController.AddStone(sender, value);
    }

    public static void SpendStone(object sender, int value)
    {
        CheckInitialized();
        _resouceController.SpendStone(sender, value);
    }

    private static void CheckInitialized()
    {
        if (!IsInitialized)
        {
            throw new Exception("Resouce is not initialized yet");
        }
    }
}

