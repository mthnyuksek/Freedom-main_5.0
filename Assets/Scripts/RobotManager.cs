using UnityEngine;
using TMPro;

public class RobotManager : MonoBehaviour
{
    public static RobotManager Instance;
    public int totalRobots = 0;
    public int rescuedRobots = 0;
    public TMP_Text robotCounterText;
    public PortalController portalController; // Inspector'dan ata

    private void Awake()
    {
        AudioManager.Instance.Play("BGM");
        Instance = this;
        totalRobots = GameObject.FindGameObjectsWithTag("Robot").Length;
        UpdateHUD();
    }

    public void RescueRobot()
    {
        rescuedRobots++;
        UpdateHUD();

        // Tüm robotlar kurtarıldıysa portalı aktif et
        if (rescuedRobots >= totalRobots && portalController != null)
        {
            portalController.ActivatePortal();
        }
    }

    private void UpdateHUD()
    {
        robotCounterText.text = $"OZGURLESTIRILEN ROBOTLAR:    {rescuedRobots}/{totalRobots}";
    }
}