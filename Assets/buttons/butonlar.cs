using UnityEngine;
using UnityEngine.SceneManagement;

public class butonlar : MonoBehaviour
{

    bool muzik = true;

    //oyna butonu
    public void OyunBaslat()
    {
        SceneManager.LoadScene(1);
    }

    //cikis butonu
    public void OyundanCik()
    {
        Application.Quit();
        Debug.Log("Oyun kapatiliyor...");
    }

    //muzik butonu
    public void muzikDegis()
    {
        if (muzik)
        {
            muzik = false;
        }
        else
        {
            muzik = true;
        }
    }
}
