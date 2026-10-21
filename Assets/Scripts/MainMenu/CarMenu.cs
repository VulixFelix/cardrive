using UnityEngine;
using UnityEngine.SceneManagement;
public class CarMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        
    }
}
