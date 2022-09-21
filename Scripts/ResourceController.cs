using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{
    public Text ResoursText;

    public int wood;
    public int stone;
    public int gold;

    void Update()
    {
        UpdateResourses();
    }

    private void UpdateResourses()
    {
        ResoursText.text = $"Wood: {wood}. Stone: {stone}.  Gold: {gold}.";
    }
}
