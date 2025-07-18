using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public Slider healthBar;
    public GameObject deathPanel; // Ölüm paneli
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        deathPanel.SetActive(false); // Başta kapalı
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        deathPanel.SetActive(true);
        // İstersen hareketi/dalgaları/düşmanları durdurabilirsin
        Time.timeScale = 0f; // Oyunu durdur (isteğe bağlı)
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            AudioManager.Instance.Play("Hurt");
             Debug.Log("Çarpıştı: " + collision.gameObject.name);
            TakeDamage(25); // Diken 25 can götürsün
        }
    }
}
