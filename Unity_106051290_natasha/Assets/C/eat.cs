using UnityEngine;

public class eat : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag=="角錐")

        {
            Destroy(collision.gameObject);
        }
       
    }
}
