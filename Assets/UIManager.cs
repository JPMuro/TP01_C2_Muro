using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public HealthSystem player;

    void Update()
    {
        healthText.text = "Vida: " + player.GetHealth();
    }
}