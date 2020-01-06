using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class eat : MonoBehaviour
    
{
    [Header("角錐數量")]
    public Text textCount;
    [Header("勝利畫面")]
    public GameObject ObjectTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;
    private void OnCollisionEnter(Collision collision)
    
{
        print(collision.gameObject);
     
        if (collision.gameObject.tag == "角錐")
        {
            Destroy(collision.gameObject);

            propCount++;
            textCount.text ="角錐"+propCount+"獲得   個角椎";

            if (propCount == propTotal)
            {
                finish = true;
                ObjectTip.SetActive(true);
            
            }
        }
       
    }

    private void Update()

    {
        GameOver();
    }

    private void GameOver()
    {
        if(finish)
        { 
            if(Input.GetKeyDown(KeyCode.E))
            {
                Application.Quit();
            }

            if(Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
