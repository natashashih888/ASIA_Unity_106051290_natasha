using UnityEngine;

public class NPC : MonoBehaviour
{
    private string Name = "Chicken";
    private string Content = "尋找10個角椎 它會讓你騎車不會遇到三寶 保重bro!我的教徒會幫你!";

    [Header("對話")]
    public SAY ds;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "ZO")
        {
            ds.ShowDialog(Name, Content);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.name);
        
        if (other.name == "ZO")
        {
            ds.HidDialog();
        }
    }
}
