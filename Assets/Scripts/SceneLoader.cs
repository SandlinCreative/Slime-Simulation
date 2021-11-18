using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(FadeLoadingScreen(30f));
        Invoke("LoadSlimeScene", 3.0f);
    }

    void LoadSlimeScene()
    {
        SceneManager.LoadScene("Slime");
    }

    IEnumerator FadeLoadingScreen(float duration)
    {
        float startValue = canvasGroup.alpha;
        float time = 0;

        while (time < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(startValue, 1, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
