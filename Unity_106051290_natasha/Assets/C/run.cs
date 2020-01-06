using UnityEngine;

public class run : MonoBehaviour
{
    public Animator ani;
    private void Update()
    {
        Run();
    }
    private void Run()
    {
        //print("水平" + Input.GetAxis("horizontal"));
        //print("垂直" + Input.GetAxis("vertical"));

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步", h != 0 || v != 0);
    }



    private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳");
                ani.SetBool("跳", true);
            }
            else
            {
                ani.SetBool("跳躍", false);
            }
        }

}
