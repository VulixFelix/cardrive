using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        
    }
}
