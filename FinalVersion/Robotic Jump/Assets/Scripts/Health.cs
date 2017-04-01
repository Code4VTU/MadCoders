using UnityEngine;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public void GoBack()
    {
        Application.LoadLevel("menu");
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= 50;
        if (currentHealth <= 0)
        {
            GoBack();
        }
    }
}