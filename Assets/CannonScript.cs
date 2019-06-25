using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    // Start is called before the first frame update'
    public  GameObject bullet;
    public GameObject place;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(bullet, place.transform.position, place.transform.rotation);
            
        }
    }
    private Vector3 updatePositon()
    {
        Vector3 position = transform.position;
        return position;
    }
}
