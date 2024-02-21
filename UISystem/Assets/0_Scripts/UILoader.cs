using UnityEngine.SceneManagement;
using UnityEngine;

public class UILoader : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (!SceneManager.GetSceneByName("UI").isLoaded)
                SceneManager.LoadSceneAsync("UI", LoadSceneMode.Additive);
            else
                SceneManager.UnloadSceneAsync("UI");
        }
    }
}
