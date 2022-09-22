using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsBase
{
    private Dictionary<Type, Model> _modelsMap;
    private SceneConfig _sceneConfig;

    public ModelsBase(SceneConfig sceneConfig)
    {
        _sceneConfig = sceneConfig;
    }

    public void CreateAllModels()
    {
        _modelsMap = _sceneConfig.CreateAllModels();
    }

    public void SendOnCreateToAllModels()
    {
        var allModels = _modelsMap.Values;
        foreach (var model in allModels)
        {
            model.OnCreate();
        }
    }

    public void InitializeAllModels()
    {
        var allModels = _modelsMap.Values;
        foreach (var model in allModels)
        {
            model.Initialize();
        }
    }

    public void SendOnStartToAllModels()
    {
        var allModels = _modelsMap.Values;
        foreach (var model in allModels)
        {
            model.OnStart();
        }
    }

    public T GetModel<T>() where T : Model
    {
        var type = typeof(T);
        return (T)_modelsMap[type];
    }
}
