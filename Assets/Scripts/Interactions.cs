using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextButtonClicked()
    {
        int camId = 0;
       if(camId == 0)
        {

            camId++;
            Camera.main.transform.Translate(cameras[camId].transform.position);
            cameras[camId-1].SetActive(false);
        }
       else if(camId == 1)
        {
            camId++;
            Camera.main.transform.Translate(cameras[camId].transform.position);
            cameras[camId - 1].SetActive(false);
            Debug.Log("CamId :" + camId);
        }
       else if(camId == 2)
       {
            camId++;
            Camera.main.transform.Translate(cameras[camId].transform.position);
            cameras[camId - 1].SetActive(false);
       }
    }
}
