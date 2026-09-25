using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rigidbody.AddForce(0, 0, 1000f * Time.deltaTime);
    }
}
