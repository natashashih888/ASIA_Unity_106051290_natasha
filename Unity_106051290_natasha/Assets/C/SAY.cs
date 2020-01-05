using UnityEngine;
using UnityEngine.UI;

public class SAY : MonoBehaviour
{
    [Header("對話")]
    public Text Name;
    public Text Content;
    public CanvasGroup uiGroup;

    public void ShowDialog(string getName, string getContent)
    {
        uiGroup.alpha = 1;
        Name.text = getName;
        Content.text = getContent;
    }

    public void HidDialog()
    {
        uiGroup.alpha = 0;
    }

}
