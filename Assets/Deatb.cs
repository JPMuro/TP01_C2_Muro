using UnityEngine;
using TMPro;

public class KillOnWall : MonoBehaviour
{
    public GameObject textoPerdiste;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            textoPerdiste.SetActive(true); // muestra el texto
            Time.timeScale = 0f; // pausa el juego
            gameObject.SetActive(false); // desactiva jugador
        }
    }
}