using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //f para que tome como float
            //transform.position += new Vector3(0, 0, 0.1f);
            //usa sistema de coordenadas de objeto
            transform.Translate(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0,-MovementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {   
            //translate para rotar
            transform.Rotate(0, RotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            //gameObject sin mayus hace referencia al mismo objeto
            Destroy(gameObject);
        }
    }
}
