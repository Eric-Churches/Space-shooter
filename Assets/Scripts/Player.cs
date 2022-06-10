using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private float fireRate = 0.15f;
    private float _canFire = -1.0f;
    [SerializeField] private float speed = 3.8f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3.8f, 0);
    }

//finish code  of limited the cube of where to go.
    // Update is called once per frame
    private void Update()
    {
        CalculateMovement();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire) FireLaser();
    }

    private void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        var direction = new Vector3(horizontalInput, verticalInput, 0);

        //clamping the position
        transform.Translate(direction * (speed * Time.deltaTime));

        transform.position =
            new Vector3(gameObject.transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        //going to the other side
        if (transform.position.x >= 11.3f)
        {
            gameObject.transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.43f)
        {
            gameObject.transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }

    private void FireLaser()
    {
        _canFire = fireRate;
        Instantiate(laserPrefab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);
            
    }

    
}