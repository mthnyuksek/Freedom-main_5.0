using UnityEngine;

public class ShowRobotText : MonoBehaviour
{
    public GameObject textObject; // Inspector'dan atanacak

    void Start()
    {
        textObject.SetActive(false); // Başlangıçta gizle
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        Debug.Log("Player entered the trigger.");
        textObject.SetActive(true);
    }
}

void OnTriggerExit2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        textObject.SetActive(false);
    }
}
}