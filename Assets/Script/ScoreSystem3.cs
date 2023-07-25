using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem3 : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText3;
    [SerializeField] private float scoreMultiplier3;
    [SerializeField] private TMP_Text Error3;

    public const string BestTimeKey3 = "BestTime3";

    private float score3;

    void Update()
    {
        score3 += Time.deltaTime * scoreMultiplier3;

        scoreText3.text = Mathf.FloorToInt(score3).ToString();
    }
  
    private void OnDestroy()
    {
        int BestTime3 = PlayerPrefs.GetInt(BestTimeKey3);
        if(BestTime3 == 0)
        {
            BestTime3 = 999;
        }
        if(score3 < BestTime3 && Error3.text != "01")
        {
            PlayerPrefs.SetInt(BestTimeKey3, Mathf.FloorToInt(score3));
        }
    }
}
