using UnityEngine;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public TextMeshProUGUI healthText;
    public GameObject gameOverText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();

        gameOverText.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentHealth--;
        UpdateUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    void UpdateUI()
    {
        healthText.text = "Vida: " + currentHealth;
    }

    void Die()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
        gameObject.SetActive(false);
    }
}