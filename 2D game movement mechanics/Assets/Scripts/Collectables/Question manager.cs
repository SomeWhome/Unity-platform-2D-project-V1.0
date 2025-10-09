using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Questionmanager : MonoBehaviour
{
    [SerializeField] private GameObject textInput;

    public string m_question;
    public string m_Correctanswer;
    public Text m_questionText;
    private bool GotQuestion = false;
    private int m_currentQuestion;

    public TMP_InputField m_questionInput;
    static int level = 2;
    public int num1 = 0;
    public int num2 = 0;
    public int counter = 0; 
    public int lives = 3;
    private void OnTriggerStay2D(Collider2D collision)
    {
        while (GotQuestion == false)
        {
            PickRandomNumber(12);
            PickRandomNumber2(12);

        }

        textInput.SetActive(true);
    }

    //largeText.text = "Hi there!";

    private void PickRandomNumber(int maxint) 
    {
        int randomNum = Random.Range(1, maxint + 1);
        num1 = randomNum;
    }
    private void PickRandomNumber2(int maxint)
    {
        int randomNum = Random.Range(1, maxint + 1);
        num2 = randomNum;
        m_questionText.text = "what is " + num1 + " X " + num2 + "= ?";
        m_Correctanswer = (num1 * num2).ToString();
        GotQuestion = true;


    }
    public void GetInputText(string userInput)
    {

        if (m_questionInput.text.ToString() == m_Correctanswer)
        {
            counter += 1;
            GotQuestion = false;
            Debug.Log(counter);
        }
        else
        {
            lives -= 1;
            GotQuestion = false;
            Debug.Log(lives);
       
        
        }
       if(counter == 20)
        {
            level++;
            SceneManager.LoadScene(level);
            Debug.Log(level);

        }
    
    }   

}


    

    

