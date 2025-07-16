using UnityEngine;
using UnityEngine.SceneManagement;


public class oyna_button_script : MonoBehaviour
{
    
[SerializeField] private GameObject birtaneisim;

public bool yontem = true;

public void bolumYukle (string isim) 
{
if(yontem){

SceneManager.LoadScene (1);

}
else{

SceneManager.LoadScene (isim);

}
    
}

public void test(string isim2) {}

}
