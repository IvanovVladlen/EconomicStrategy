using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{
    public Text ResoursText;

    public int wood;
    public int stone;
    public int gold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateResourses();
    }

    private void UpdateResourses()
    {
        ResoursText.text = $"Wood: {wood}. Stone: {stone}.  Gold: {gold}.";
    }
}
