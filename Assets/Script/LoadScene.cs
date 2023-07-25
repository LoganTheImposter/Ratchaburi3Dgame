using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private TMP_Text BestTimeText;
    [SerializeField] private TMP_Text BestTimeText2;
    [SerializeField] private TMP_Text BestTimeText3;            
    private void Start()
    {
        int bestTime = PlayerPrefs.GetInt(ScoreSystem.BestTimeKey, 0);
        Debug.Log("Best 1 Time:" + bestTime);

        BestTimeText.text = $"Time: {bestTime}";   

        int bestTime2 = PlayerPrefs.GetInt(ScoreSystem2.BestTimeKey2, 0);
        Debug.Log("Best 2 Time:" + bestTime2);
        BestTimeText2.text = $"Time: {bestTime2}";

        int bestTime3 = PlayerPrefs.GetInt(ScoreSystem3.BestTimeKey3, 0);
        Debug.Log("Best 3 Time:" + bestTime3);
        BestTimeText3.text = $"Time: {bestTime3}";

    }
    public float progress;
    public void LoadSceneGame(string sceneName){
        StartCoroutine(SceneStart(sceneName));

        //BestTimeSystem
        
    }

    public IEnumerator SceneStart(string sceneName){
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName,LoadSceneMode.Single);
        asyncOperation.allowSceneActivation = false;
        while(!asyncOperation.isDone){
            progress = Mathf.Clamp01(asyncOperation.progress/0.9f);
            if(progress == 1){
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

}
