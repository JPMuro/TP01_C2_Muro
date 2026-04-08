using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    [SerializeField] private Text healthText; // UI

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    private void OnCollisionEnter(Collision collision)
    {
        float impact = collision.relativeVelocity.magnitude;

        // Opción 1: daño según velocidad
        float damage = impact * 2f;

        // Opción 2 (simple): descomentar si querés daño fijo
        // float damage = 34f;

        TakeDamage(damage);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateUI()
    {
        healthText.text = "Vida: " + Mathf.RoundToInt(currentHealth);
    }

    void Die()
    {
        Debug.Log("Jugador muerto");
        // Opciones:
        // Destroy(gameObject);
        // reiniciar escena, etc.
    }
}