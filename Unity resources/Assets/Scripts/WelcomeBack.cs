using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeBack : MonoBehaviour
{
    public void Goback1() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
            AudioM.instance.GetComponent<AudioSource>().Play();
    }

        public void Goback2() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
            AudioM.instance.GetComponent<AudioSource>().Play();
    }

        public void Goback3() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
            AudioM.instance.GetComponent<AudioSource>().Play();
    }

        public void Goback4() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
             AudioM.instance.GetComponent<AudioSource>().Play();
    }

        public void Goback5() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
            AudioM.instance.GetComponent<AudioSource>().Play();
    }

    public void Goback6() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -6);
    }

        public void Goback7() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -7);
    }
}
