using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour
{
    public void GoBackToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
