using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tower;
    public GameObject Cannon;
    public float speed;
    private Vector3 CannonRatation;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        CannonRatation.x = Cannon.transform.rotation.x;
        CannonRatation.y = Cannon.transform.rotation.y;
        CannonRatation.z = Cannon.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            tower.transform.RotateAround(tower.transform.position, Vector3.up, 40 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            tower.transform.RotateAround(tower.transform.position, Vector3.up, -40 * Time.deltaTime);
            //towerRatation.y -= 0.01f;
           // tower.transform.Rotate(towerRatation);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            CannonRatation.x += 0.5f;
            Cannon.transform.Rotate(CannonRatation);
            CannonRatation.x -= 0.5f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            CannonRatation.x -= 0.5f;
            Cannon.transform.Rotate(CannonRatation);
            CannonRatation.x += 0.5f;
        }

        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            handleMove();
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
            {
            transform.RotateAround(tower.transform.position, Vector3.up, -40 * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(tower.transform.position, Vector3.up, 40 * Time.deltaTime);
        }
    }
    void handleMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);

        transform.Translate(direction.normalized * Time.deltaTime * speed);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(tower.transform.position, Vector3.up, -5 * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(tower.transform.position, Vector3.up, 5 * Time.deltaTime * speed);
        }


    }
}
