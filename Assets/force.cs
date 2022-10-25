using UnityEngine;

public class force : MonoBehaviour{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 400, 700);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
