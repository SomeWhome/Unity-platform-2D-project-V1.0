using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text m_ScoreText;
    private int m_Score;

    // Update is called once per frame
    void Update()
    {
        UpdateScoreUI();
    }


    public void AddScore (int amount)
    {
        m_Score += amount;
        UpdateScoreUI();

    }

    void UpdateScoreUI()
    {
       
        m_ScoreText.text = "score " + m_Score;
        //M_ScoreText = "score" + m_Score;
    
    }
}
