using JetBrains.Annotations;
//using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Questionmanager : MonoBehaviour
{
    [SerializeField] private GameObject m_questionInput;

    public string m_question;
    public string m_Correctanswer;
    public Text m_questionText;
    private bool GotQuestion = false;
    private int m_currentQuestion;

    //public TMP_InputField m_questionInput;
   
    static int level = 2;
    public int num1 = 0;
    public int num2 = 0;
    public int counter = 0; 
    public int lives = 3;
    public bool OnPlatform = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        m_questionInput.SetActive(true);
        OnPlatform = true;
        while (GotQuestion == false && OnPlatform == true )
        {
            PickRandomNumber(12);

        }
        
    
    }

    public void Offplatform()
    {
       m_questionInput.SetActive(false);
        Debug.Log("Question ended");
        OnPlatform = false;
        GotQuestion = false;
        m_questionText.text = "";

    }
//largeText.text = "Hi there!";

private void PickRandomNumber(int maxint) 
    {
        int randomNum = Random.Range(1, maxint + 1);
        num1 = randomNum;


        int randomNum2 = Random.Range(1, maxint + 1);
        num2 = randomNum2;
        m_questionText.text = "what is " + num1 + " X " + num2 + "= ?";
        m_Correctanswer = (num1 * num2).ToString();
        GotQuestion = true;
        Debug.Log(m_Correctanswer);
        Debug.Log(m_questionText.ToString());
    }
    
    
    public void GetInputText(string userInput)
    {
        if (m_questionInput.GetComponent<InputField>().text.ToString() == m_Correctanswer)
        {
            counter += 1;
            GotQuestion = false;
            OnPlatform = true;
            Debug.Log("counter:"+ counter);
            PickRandomNumber(12);
        }
        else
        {
            lives -= 1;
            GotQuestion = false;
            Debug.Log("Lives:" +lives);
            
        
        }
       if(counter == 20)
        {
            level++;
            SceneManager.LoadScene(level);
            Debug.Log(level);

        }
    
    }
}


    

    

