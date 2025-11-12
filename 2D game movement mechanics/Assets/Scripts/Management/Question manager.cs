using JetBrains.Annotations;
//using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;


public class Questionmanager : MonoBehaviour
{
    //creating variables
    [SerializeField] private GameObject m_questionInput;
    public string m_question;
    public string m_Correctanswer;
    public Text m_questionText;
    private bool GotQuestion = false;
    private int m_currentQuestion;
    public boss_fight m_Boss;
    public Camerafollow m_cam;
    //public TMP_InputField m_questionInput;
    public Text m_Answer;
    static int level = 2;
    public int num1 = 0;
    public int num2 = 0;
    public int counter = 0; 
    public bool OnPlatform = false;
    public int remaning;
    private void Start()
    {
        // Sets the maount of questions left
        remaning = 20 - counter;
        string text = remaning.ToString();
        //m_Answer.text = "";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       //zooms out the camera
        m_cam.ZoomOut();
        //makes the input and question text visable 
        m_questionInput.SetActive(true);
        m_Answer.text = ("Questions remaining :");
        OnPlatform = true;
        while (GotQuestion == false && OnPlatform == true )
        {
            //prosidual generation of question
            PickRandomNumber(12);

        }
        
    
    }

    public void Offplatform()
    {
        // if left platform turns off question system
       m_questionInput.SetActive(false);
        OnPlatform = false;
        GotQuestion = false;
        m_questionText.text = "";
        m_cam.ZoomIn();
    }
//largeText.text = "Hi there!";

private void PickRandomNumber(int maxint) 
    {
        //prosidual generation
        int randomNum = Random.Range(1, maxint + 1);
        num1 = randomNum;


        int randomNum2 = Random.Range(1, maxint + 1);
        num2 = randomNum2;
        m_questionText.text = "what is " + num1 + " X " + num2 + "= ?";
        m_Correctanswer = (num1 * num2).ToString();
        GotQuestion = true;
        Debug.Log(m_Correctanswer);
       
    }
    
    
    public void GetInputText(string userInput)
    {
        //when question answered
        if (m_questionInput.GetComponent<InputField>().text.ToString() == m_Correctanswer)
        {
            // if correct
            counter += 1;
            GotQuestion = false;
            OnPlatform = true;
            Debug.Log("counter:"+ counter);
            PickRandomNumber(12);
            remaning = 20 - counter;
            string left = remaning.ToString();
            m_Answer.text = "Questions remaining;"+ left;
        }
        else
        {
            //if wrong
            Debug.Log("incorrect");
            GotQuestion = false;
            OnPlatform = true;
            PickRandomNumber(12);
            m_Boss.AttackPlayer();
        
        }
       if(counter == 20)
        {
            //increases level when 20 questions answer correctly 
            level++;
            SceneManager.LoadScene(level);
            Debug.Log(level);

        }
    
    }
}


    

    

