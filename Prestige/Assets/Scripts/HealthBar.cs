using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillbar;
    public int maxHealth = 100;
    private int currentHealth;
    public int damageAmount;
    public Animator animator;

    private bool isDead = false;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    private void Update()
    {
        if (!isDead)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                TakeDamage(25);
            }
        }
    }

    public void TakeDamage(int damageAmount)
    {
        if (isDead)
            return;

        currentHealth -= damageAmount;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        animator.SetTrigger("Death");
        Debug.Log("You died!");
        // Add your game over logic here
    }

    private void UpdateHealthBar()
    {
        // Update the health bar UI based on currentHealth
        float fillAmount = (float)currentHealth / maxHealth;
        fillbar.fillAmount = fillAmount;
    }
}
