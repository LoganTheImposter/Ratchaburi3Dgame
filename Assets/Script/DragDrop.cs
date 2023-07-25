using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDrop : MonoBehaviour
{
    [SerializeField] private TMP_Text EndText;
    public int Go;
    
    Vector3 offset;   
    public string destinationTag = "DropArea";  
    public GameObject OBJ1;
    public GameObject OBJ2;
    public GameObject OBJ3;
    public GameObject OBJ4;
      
     
    int DropLate;
    public int EndLate;
    public int EndLate2;
    public int EndLate3;
    public int EndLate4;

    
 

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }

    void OnMouseDrag()
    {
        if(DropLate == 0)
        {
        transform.position = MouseWorldPosition() + offset;
      
        }
    }

    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if(Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {       
            if(DropLate == 1){}
            if(DropLate ==0){
            if(hitInfo.transform.tag == destinationTag)
            {                
                transform.position = hitInfo.transform.position;
                DropLate = 1;                
                if(destinationTag == "DropArea")
                {OBJ1.SetActive (false);EndLate = 1;}                
                if(destinationTag == "DATrees")
                {OBJ2.SetActive (false);EndLate2 = 1;}
                if(destinationTag == "DropFrend")
                {OBJ3.SetActive (false);EndLate3 = 1;}
                if(destinationTag == "DAU-turn")
                {OBJ4.SetActive (false);EndLate4 = 1;}                
            }
            }
        }
        if(EndLate >= 1){ 
            
            EndText.text = EndText.text + EndLate;                         
            Debug.Log(EndLate + "-----" + EndLate2 +"-----" + EndLate3 + "-----" + EndLate4); 
            Destroy(this);                                 
        }
        if(EndLate2 >= 1){   
               
            EndText.text = EndText.text + EndLate2;                        
            Debug.Log(EndLate + "-----" + EndLate2 +"-----" + EndLate3 + "-----" + EndLate4); 
            Destroy(this);                                  
        } 
        if(EndLate3 >= 1){   
               
            EndText.text = EndText.text + EndLate3;                        
            Debug.Log(EndLate + "-----" + EndLate2 +"-----" + EndLate3 + "-----" + EndLate4);  
            Destroy(this);                                 
        }   
        if(EndLate4 >= 1){   
              
            EndText.text = EndText.text + EndLate4;                        
            Debug.Log(EndLate + "-----" + EndLate2 +"-----" + EndLate3 + "-----" + EndLate4);     
            Destroy(this);                               
        }
        if(EndText.text == "01111"){
            SceneManager.LoadScene(Go); 
        }
              
        transform.GetComponent<Collider>().enabled = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseSceenPos = Input.mousePosition;
        mouseSceenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseSceenPos);
    }
}
