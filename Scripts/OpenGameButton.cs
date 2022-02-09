using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenGameButton : MonoBehaviour
{
    public void OpenGame()
    {
        FindObjectOfType<AudioManager>().Play("Ding");
        SceneManager.LoadScene("GameScene");
    }
}
