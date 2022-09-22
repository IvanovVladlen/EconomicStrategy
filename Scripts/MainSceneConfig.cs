using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneConfig : SceneConfig
{
    public override Dictionary<Type, Controller> CreateAllControllers()
    {
        var controllersMap = new Dictionary<Type, Controller>();

        //controllers
        CreateController<ResouceController>(controllersMap);

        return controllersMap;
    }

    public override Dictionary<Type, Model> CreateAllModels()
    {
        var modelsMap = new Dictionary<Type, Model>();

        //models
        CreateModel<ResouceModel>(modelsMap);

        return modelsMap;
    }
}
