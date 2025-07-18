using UnityEngine;

public class Robot : MonoBehaviour
{
    private bool isPlayerNearby = false;
    public GameObject textObject; // Inspector'dan atamayı unutma

    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.Instance.Play("RobotFree");
            RobotManager.Instance.RescueRobot();
            if (textObject != null)
                textObject.SetActive(false); // Yazıyı kapat
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            if (textObject != null)
                textObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            if (textObject != null)
                textObject.SetActive(false);
        }
    }
}
