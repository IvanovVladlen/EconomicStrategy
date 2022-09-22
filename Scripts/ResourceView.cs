using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ResourceView : MonoBehaviour
{
    [SerializeField]
    public Text ResoursText;

    private Scene _scene;
    void Start()
    {
        var sceneConfig = new MainSceneConfig();
        Scene _scene = new Scene(sceneConfig);

        StartCoroutine(_scene.InitializeRoutine());
        Debug.Log("Initialize Routine");
        Debug.Log("Initialized" + Resource.IsInitialized);
    }
    void Update()
    {
        Debug.Log("Initialized" + Resource.IsInitialized);
        UpdateResourses();
    }

    private void UpdateResourses()
    {
        ResoursText.text = $"Wood: {Resource.Wood}. Stone: {Resource.Stone}.  Gold: {Resource.Gold}.";
    }
}
