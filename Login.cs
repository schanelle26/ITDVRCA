using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public TMP_Text errorMessage;

    public string correctPassword = "2468";     
    public string nextSceneName = "SampleScene"; 

    void Start()
    {
        errorMessage.gameObject.SetActive(false);
    }

    public void LogIn()
    {
        string pw = passwordInput.text;

        if (pw == correctPassword)
        {
            
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            
            errorMessage.text = "Incorrect password!";
            errorMessage.gameObject.SetActive(true);
        }



    }
}
