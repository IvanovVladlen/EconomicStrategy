using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneConfig
{
    public abstract Dictionary<Type, Model> CreateAllModels();
    public abstract Dictionary<Type, Controller> CreateAllControllers();

    public void CreateController<T>(Dictionary<Type, Controller> controllersMap) where T : Controller, new()
    {
        var controller = new T();
        var type = typeof(T);
        controllersMap[type] = controller;
    }

    public void CreateModel<T>(Dictionary<Type, Model> modelsMap) where T : Model, new()
    {
        var model = new T();
        var type = typeof(T);
        modelsMap[type] = model;
    }
}
