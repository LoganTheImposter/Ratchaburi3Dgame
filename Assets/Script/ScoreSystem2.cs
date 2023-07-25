using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem2 : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText2;
    [SerializeField] private float scoreMultiplier2;
    [SerializeField] private TMP_Text Error2;

    public const string BestTimeKey2 = "BestTime2";

    private float score2;

    void Update()
    {
        score2 += Time.deltaTime * scoreMultiplier2;

        scoreText2.text = Mathf.FloorToInt(score2).ToString();
    }
  
    private void OnDestroy()
    {
        int BestTime2 = PlayerPrefs.GetInt(BestTimeKey2);
        if(BestTime2 == 0)
        {
            BestTime2 = 999;
        }

        if(score2 < BestTime2  && Error2.text != "01")
        {
            PlayerPrefs.SetInt(BestTimeKey2, Mathf.FloorToInt(score2));
        }
    }
}
