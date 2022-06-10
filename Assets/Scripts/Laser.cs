
using UnityEngine;
using UnityEngine.Serialization;

public class Laser : MonoBehaviour
{
    // make the speed of the missile 8.0f
   [SerializeField]
    private float speed = 7.5f;

    // Update is called once per frame
   void Update()
    {
        //translate laser up by 8
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        
        // is laser position is greater than 8 on the y
        if (transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
