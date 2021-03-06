using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneManager : MonoBehaviour
{
    public static string nextScene;
    public GameObject backImage;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    [SerializeField]
    Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneProcess());
        if (nextScene == "Indigo")
        {
            backImage.GetComponent<Image>().sprite = Resources.Load("images/Indigo", typeof(Sprite)) as Sprite;
        }
        else if (nextScene == "Yellow")
        {
            backImage.GetComponent<Image>().sprite = Resources.Load("images/Yellow", typeof(Sprite)) as Sprite;
        }
        else
        {
            backImage.GetComponent<Image>().sprite = Resources.Load("images/EireneLogo3", typeof(Sprite)) as Sprite;
        }
        
    }

    

    IEnumerator LoadSceneProcess()
    {
        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;

        float timer = 0.0f;
        while (!op.isDone)
        {
            yield return null;

            if (op.progress < 0.9f)
            {
                progressBar.fillAmount = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                progressBar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);

                if (progressBar.fillAmount >= 1.0f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
