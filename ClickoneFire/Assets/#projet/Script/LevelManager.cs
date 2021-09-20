using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    //private int row;
    //private int col;
    //public float gapRow = 1.5f;
    //public float gapCol = 1.5f;
    
    public List<GameObject> items = new List<GameObject>();
    public int limitgauche = 12;
    public int limitdroit = 0;
    public int  limithaut = 16;
    public int limitbas = 10;
    public GameObject itemPrefab;
    public Material[] materials;
    public float time = 0f;
    public float cubepop = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }
    void OutputTime(){

    }
    void Update()
    {
        time += Time.deltaTime;
        // if (time>=1f){
        //     time = time%1f;
        //     OutputTime();
        // }

        if(items.Count < 10 && time >=1f){
            time = time%1f;
            OutputTime();
            Vector3 position = new Vector3(Random.Range(12,0-1),Random.Range(16,10-1),25);
            GameObject item = Instantiate(itemPrefab,position,Quaternion.identity);
            items.Add(item);
        }
        
        
        
    }
   

   // private IEnumerator cubepop()
    //{    
        //yield return new WaitForSeconds(5)       
    //}
}
