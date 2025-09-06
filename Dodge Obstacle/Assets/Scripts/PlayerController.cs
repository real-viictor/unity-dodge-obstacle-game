using System.Xml.Schema;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float xInput, zInput;
    
    [SerializeField] protected float playerSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        xInput = Input.GetAxis("Horizontal") * playerSpeed;
        zInput = Input.GetAxis("Vertical") * playerSpeed;
        transform.Translate(xInput, 0, zInput);
    }
}
