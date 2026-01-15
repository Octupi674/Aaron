using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void sceneChanger(string scene_Name)
    {
        SceneManager.LoadScene(scene_Name);
    }
}
