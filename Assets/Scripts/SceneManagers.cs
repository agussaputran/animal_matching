using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitYesButton()
    {
        Application.Quit();
        Debug.Log("keluar");
    }
}
