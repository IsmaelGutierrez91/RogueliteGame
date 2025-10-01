using System;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    float currentXP = 0;
    float maxXP = 10;

    int lvl = 1;

    public static event Action<float, float> OnXpUpdate;
    public static event Action OnReachMaxXP;

    //Temporal:
    public static event Action OnPulsePowerButton;

    public void PulsePowerButton()
    {
        OnPulsePowerButton?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BallXP")
        {
            currentXP = currentXP + 10;
            Destroy(collision.gameObject);

            if (currentXP >= maxXP)
            {
                currentXP = currentXP - maxXP;
                maxXP = 10 * Mathf.Pow(2, lvl);
                lvl = lvl + 1;
                OnReachMaxXP.Invoke();
            }
            OnXpUpdate?.Invoke(currentXP, maxXP);
        }
    }
}
