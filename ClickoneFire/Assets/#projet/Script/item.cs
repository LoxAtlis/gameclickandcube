using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public int id = -1;
    public LevelManager manager;
    public bool mouseOver = false;
    //private int score = 0;
    
    //private float timer=0;



    void OnMouseOver(){
        
        mouseOver = true;
       
    }
    void OnMouseExit(){
        
        mouseOver = false;
        
    }


    void Start()
    {
        float time = PlayerPrefs.GetFloat("timer",0f);
        //gameObject. GetComponent<Renderer>().enabled = false;
        
    }
 
   
    
    void Update()
    {
        
        if (Input.GetMouseButtonUp(0 )&& mouseOver){
            Destroy(gameObject);
            
        }
    }
    
}

