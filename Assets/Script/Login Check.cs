using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField usernameInput;
    [SerializeField]
    public TMP_InputField passwordInput;
    [SerializeField]
    public TMP_Text errorText;

    public string correctUsername = "tyt"; 
    public string correctPassword = "1234"; 
    public string nextSceneName = "MyScene"; // Scene to load if correct

    // This function will be called when the button is clicked
    public void WhenClicked()
    {
        if (usernameInput.text == correctUsername && passwordInput.text == correctPassword)
        {
            // Password is correct → load next scene
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // Password is incorrect → show error
            errorText.text = "Incorrect Username or Password!";
        }
    }
}
