using UnityEngine;

public class game_manager_script : MonoBehaviour
{
    

// Tüm sahnelerden erişebileceğimiz statik instance (singleton)

    public static game_manager_script Instance;



    // veriler
    public bool muzikAcik = true;











    void Awake()
    {
        // Eğer daha önce oluşturulmamışsa, bu nesne Singleton olarak atanır
        if (Instance == null)
        {
            Instance = this;

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Bu obje sahne değişse bile yok olmasın
            DontDestroyOnLoad(gameObject);

            ////////////////////////////////////////////////////// bu önemli /////////////////////////////////////////////////////////
        
        }
        else
        {
            // Eğer bu script sahnede tekrar oluşursa (örneğin başka sahnede tekrar eklendiyse),
            // zaten bir tane olduğu için bu yenisini sil
            Destroy(gameObject);
        }
    }



}
