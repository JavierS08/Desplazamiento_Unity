using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPlay : MonoBehaviour
{
    public GameObject gamer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gamer.transform.position+new Vector3(0,5,-9);
    }
}
