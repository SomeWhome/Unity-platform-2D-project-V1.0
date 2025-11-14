using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_transition : MonoBehaviour
{
    public static int LevelToLoad = 0;

    

    public void LevelProgress()
    {
      
        if(LevelToLoad == 0)
        {
            SceneManager.LoadScene("level 1 (MIM)");
            LevelToLoad = 1;
        }
        else if (LevelToLoad == 1)
        {
            SceneManager.LoadScene("Level 2");
            LevelToLoad = 2;
        }
        else if (LevelToLoad == 2)
        {
            SceneManager.LoadScene("Credits");
            LevelToLoad = 3;
        }
        else
        {
            SceneManager.LoadScene("MM 2.0");
            LevelToLoad = 0;
        }
    }
}

