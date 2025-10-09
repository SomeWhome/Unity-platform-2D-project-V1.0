using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_transition : MonoBehaviour
{
    static int level = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelProgress();
    }

    public void LevelProgress()
    {
        level++;
        SceneManager.LoadScene(level);
        Debug.Log(level);
    }
}
