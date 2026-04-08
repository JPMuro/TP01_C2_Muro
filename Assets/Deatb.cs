using UnityEngine;

public class KillOnWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            gameObject.SetActive(false);

            Time.timeScale = 0f;
        }
    }
}