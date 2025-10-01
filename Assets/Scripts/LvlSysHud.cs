using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvlSysHud : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI xpText;
    [SerializeField] private Image PowerSelection;
    void UpdateXPHud(float currentXp, float maxXP)
    {
        xpText.text = currentXp + " / " + maxXP;
    }
    void ActivatePowerSelectionPanel()
    {
        PowerSelection.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    void DisactivatePowerSelectionPanel()
    {
        Time.timeScale = 1.0f;
        PowerSelection.gameObject.SetActive(false);
        Debug.Log("Hola, seleccionaste una habilidad");
    }
    private void OnEnable()
    {
        LevelSystem.OnXpUpdate += UpdateXPHud;
        LevelSystem.OnReachMaxXP += ActivatePowerSelectionPanel;
        LevelSystem.OnPulsePowerButton += DisactivatePowerSelectionPanel;
    }
    private void OnDisable()
    {
        LevelSystem.OnXpUpdate -= UpdateXPHud;
        LevelSystem.OnReachMaxXP -= ActivatePowerSelectionPanel;
        LevelSystem.OnPulsePowerButton -= DisactivatePowerSelectionPanel;
    }
}
