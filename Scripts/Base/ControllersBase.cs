using System;
using System.Collections.Generic;

public class ControllersBase
{
    private Dictionary<Type, Controller> _controllersMap;
    private SceneConfig _sceneConfig;

    public ControllersBase(SceneConfig sceneConfig)
    {
        _sceneConfig = sceneConfig;
    }

    public void CreateAllControllers()
    {
        _controllersMap = _sceneConfig.CreateAllControllers();
    }


    public void SendOnCreateToAllControllers()
    {
        var allControllers = _controllersMap.Values;
        foreach (var controller in allControllers)
        {
            controller.OnCreate();
        }
    }

    public void InitializeAllControllers()
    {
        var allControllers = _controllersMap.Values;
        foreach (var controller in allControllers)
        {
            controller.Initialize();
        }
    }

    public void SendOnStartToAllControllers()
    {
        var allControllers = _controllersMap.Values;
        foreach (var controller in allControllers)
        {
            controller.OnStart();
        }
    }

    public T GetController<T>() where T : Controller
    {
        var type = typeof(T);
        return (T) _controllersMap[type];
    }
}
