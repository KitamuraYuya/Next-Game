using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Load(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
