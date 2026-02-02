using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class textUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    public float lives = 3f;

    public bool isZero;

    public Button button;
    
    void Start()
    {
        button.onClick.AddListener(useThis);
    }

   

    void useThis()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(1);
    }
}
