using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField] float fadeTime = 1.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Text>().DOFade(0, fadeTime);
        }
    }
}
