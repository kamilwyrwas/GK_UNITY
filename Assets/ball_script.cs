using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_script : MonoBehaviour
{
    private Rigidbody CannonBall;
    // Start is called before the first frame update
    private Quaternion rotation;
    void Start()
    {
        CannonBall = GetComponent<Rigidbody>();
        CannonBall.mass = (float)(1.0);
        CannonBall.useGravity = true;
     
        CannonBall.AddRelativeForce(Vector3.forward*1000 );
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void OnCollisionEnter(Collision c) {

        
            Destroy (CannonBall.gameObject);
            EffectCtrl.instance.CreateExplosionEffect(CannonBall.position);
        
    }

}









