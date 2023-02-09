using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Resume();
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
