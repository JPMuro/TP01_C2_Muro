using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // IMPORTANTE

public class KillOnWall : MonoBehaviour
{
    public GameObject textoPerdiste;

    private bool gameOver = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            textoPerdiste.SetActive(true);
            Time.timeScale = 0f;
            gameObject.SetActive(false);
            gameOver = true;
        }
    }

    private void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f; // reanuda el tiempo
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reinicia
        }
    }
}