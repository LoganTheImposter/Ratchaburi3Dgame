using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    [SerializeField] private TMP_Text ErrorText;   

    public void BackBTN(GameObject obj) 
    {
       ErrorText.text = ErrorText.text + "1";            
       SceneManager.LoadScene(1);      

    }
}
