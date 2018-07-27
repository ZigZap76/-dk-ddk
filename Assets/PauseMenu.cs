using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour

{

    public static bool GameIsPaused;
    public GameObject PauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            
            if (GameIsPaused)
            {

                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("loading menu");
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Debug.Log("QUIT !!");
        Application.Quit();
    }
}