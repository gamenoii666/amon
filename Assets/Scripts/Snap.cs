using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    public GameManager gameManager;
   
    [SerializeField]
    private string _NamePartSnap;

    public bool isSnap = false;
    public bool isPartCorrect = false;
    float countTime = 0f;
    public bool iSTime;

    // Start is called before the first frame update
    public int Score = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Part"))
        {

            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.rotation = transform.rotation;

            if (other.gameObject.name == _NamePartSnap)
            {
                isPartCorrect = true;
                
                
              
            }
            if (!isSnap)
            {
               
                isSnap = true;
                //gameManager.snapCheck();
                
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        

        if (other.gameObject.CompareTag("Part"))
        {
            isSnap = false;
            isPartCorrect = false;
            
        }
    }

}
