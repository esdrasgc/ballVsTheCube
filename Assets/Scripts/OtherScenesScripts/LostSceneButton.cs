
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostSceneButton : MonoBehaviour
{
    public void GoBackToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
