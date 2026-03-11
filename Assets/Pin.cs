using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isKnockedDown;
    public Vector3 originalPosition;

    void Start()
    {
        
        originalPosition = transform.position;
    }

    void Update()
    {

        if( Vector3.Angle(Vector3.up, transform.up) > 10f )
        {
            isKnockedDown = true;
        }
        
    }
}
