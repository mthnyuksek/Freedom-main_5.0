using UnityEngine;
using TMPro;

public class RobotManager : MonoBehaviour
{
    public static RobotManager Instance;

    public int totalRobots = 0;
    public int rescuedRobots = 0;

    public TMP_Text robotCounterText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Tüm robotları say
        totalRobots = GameObject.FindGameObjectsWithTag("Robot").Length;
        UpdateHUD();
    }

    public void RescueRobot()
    {
        rescuedRobots++;
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        robotCounterText.text = $"{rescuedRobots}/{totalRobots}";
    }
}
