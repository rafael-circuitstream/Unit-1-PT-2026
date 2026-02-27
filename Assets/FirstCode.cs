using UnityEngine;

class FirstCode : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public Transform ballTransform;
    public GameObject arrow;
    public int throwForce;

    void Start()
    {
        
    }


    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            arrow.SetActive(false);
            
            ballRigidbody.AddForce( arrow.transform.forward * throwForce );
        }


        if ( ballTransform.position.x > -0.45f)
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                ballTransform.Translate(-Time.deltaTime, 0, 0);
            }

        }

        if (ballTransform.position.x < 0.45f)
        {

            if (Input.GetKey(KeyCode.RightArrow))
            {
                ballTransform.Translate(Time.deltaTime, 0, 0);
            }

        }
    }

}
