using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
public static UIManager Instance;

    [SerializeField] private GameObject rescuePrompt;
    [SerializeField] private TMP_Text rescueCounterText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowRescuePrompt(bool show)
    {
        rescuePrompt.SetActive(show);
    }

    public void UpdateRescueCounter(int rescued, int total)
    {
        rescueCounterText.text = $"{rescued} / {total} Robot";
    }
}
