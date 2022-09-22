using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene
{
    private ModelsBase _modelsBase;
    private ControllersBase _controllersBase;
    private SceneConfig _sceneConfig;

    private static Scene _instance;

    public Scene(SceneConfig config)
    {
        _sceneConfig = config;
        _controllersBase = new ControllersBase(config);
        _modelsBase = new ModelsBase(config);
    }

    public static Scene GetInstance()
    {
        return _instance;
    }
    public IEnumerator InitializeRoutine()
    {
        _controllersBase.CreateAllControllers();
        _modelsBase.CreateAllModels();
        Debug.Log("CreateAllModels");
        yield return null;

        _controllersBase.SendOnCreateToAllControllers();
        _modelsBase.SendOnCreateToAllModels();
        Debug.Log("SendOnCreateToAllModels");
        yield return null;

        _controllersBase.InitializeAllControllers();
        _modelsBase.InitializeAllModels();
        Debug.Log("InitializeAllModels");
        yield return null;

        _controllersBase.SendOnStartToAllControllers();
        _modelsBase.SendOnStartToAllModels();
        Debug.Log("SendOnStartToAllModels");
    }

    public T GetController<T>() where T : Controller
    {
        return _controllersBase.GetController<T>();
    }

    public T GetModel<T>() where T : Model
    {
        return _modelsBase.GetModel<T>();
    }
}
