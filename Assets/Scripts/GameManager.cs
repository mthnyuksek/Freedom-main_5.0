using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalRobots;
    public int rescuedRobots;

    public Text robotCountText; // UI Text
    public GameObject portal;   // Portala referans

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        UpdateRobotText();
    }

    public void RobotRescued()
    {
        rescuedRobots++;
        UpdateRobotText();

        if (rescuedRobots >= totalRobots)
        {
            portal.GetComponent<PortalController>().ActivatePortal();
        }
    }

    void UpdateRobotText()
    {
        robotCountText.text = $"Robotlar: {rescuedRobots}/{totalRobots}";
    }
}