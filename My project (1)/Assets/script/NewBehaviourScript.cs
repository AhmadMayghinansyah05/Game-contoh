using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    public int health = 100;
    float speed = 5.5f;
    bool isAlive = true;
    string namaPlayer = "SJLK";
    char grade = 'A';
    // Start is called before the first frame update
    void Start()
    {
        string status = GetPlayerStatus(80);    
        Debug.Log("Status Pemain" + status);

    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

   string GetPlayerStatus(int darah)
   {
    if (darah > 50)
        return "hidup";
    else if (darah > 0)
        return "lemah";
    else
        return "mati";
   }
}
