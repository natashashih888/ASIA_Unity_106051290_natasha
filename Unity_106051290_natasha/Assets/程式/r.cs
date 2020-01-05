using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator ani;
    private void Update()
    {
        run();
    }
    private void run()
    {
        //print("水平" + Input.GetAxis("horizontal"));
        //print("垂直" + Input.GetAxis("vertical"));

        float h = Input.GetAxis("horizontal");
        float v = Input.GetAxis("vertical");

        ani.SetBool("跑步", h != 0 || v != 0);
    }



}
