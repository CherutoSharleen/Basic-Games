using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //obstacle slowly moves towards player
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    //Can't be seen by Camera
    private void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
