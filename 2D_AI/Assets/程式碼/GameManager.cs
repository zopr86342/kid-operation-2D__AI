
using UnityEngine;
using UnityEngine.SceneManagement; //引用 場景管理 API

public class GameManager : MonoBehaviour
{
    public void Replay()
    {
        // Application.LoadedLevel("遊戲"); //舊版 API
        SceneManager.LoadScene("場景");     //新版 API

    }
    public void Quit()
    {
        Application.Quit(); //應用程式.離開遊戲
    }
}
