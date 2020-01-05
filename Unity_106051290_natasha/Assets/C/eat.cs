using UnityEngine;
using UnityEngine.UI;
public class eat : MonoBehaviour
    
{
    [Header("角錐數量")]
    public Text textCount;
    [Header("勝利畫面")]
    public GameObject ObjectTip;

    public int propCount;
    public int propTotal = 10;

    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "角錐")
      {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text ="角錐:"+propCount+"獲得   個角椎";
      }
       
    }
}
