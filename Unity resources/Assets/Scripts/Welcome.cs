using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void ShowOptions() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +7);
    }
}
