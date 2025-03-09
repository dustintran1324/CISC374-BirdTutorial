using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vector3 = UnityEngine.Vector3;
public class PipeMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 1;
    public float deadzone2 = -2;
    public float deadzone3 = -20;
    void Start()
    {
    Debug.Log("Pipe spawned at: " + transform.position.x);
    Debug.Log("DeadZone value: " + deadzone2);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        Debug.Log("Pipe Position: " + transform.position.x);
        if (transform.position.x < deadzone3){
            Debug.Log("Pipe deleted at position" + transform.position.x);
            Destroy(gameObject);
        }
    }
}
