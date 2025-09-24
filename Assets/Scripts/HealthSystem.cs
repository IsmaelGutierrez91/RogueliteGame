using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    int playerhealth;
    int maxHealth;
    int currentMaxHealth;
    public void TakeDamage(int add)
    {
        playerhealth -= add;
    }
    public void SetMaxHP()
    {
        playerhealth = currentMaxHealth;
    }
    public int CurrentHP()
    {
        return playerhealth;
    }
    public void Heal(int add)
    {
        playerhealth += add;
    }
    public void ResetHP()
    {
        currentMaxHealth = maxHealth;
        SetMaxHP();
    }
    public bool IsDeath()
    {
        if(playerhealth <= 0)
        {
            return true;
        }
        return false;
    }
}
