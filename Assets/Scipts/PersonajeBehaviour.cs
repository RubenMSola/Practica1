using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PersonajeBehaviour : MonoBehaviour
{
    //Variables para el movimiento del personaje
    public float personajeSpeed = 10f;
    public float rotateSpeed = 75f;
    private float vInput;
    private float hInput;

    //Variables para el salto del persoanje
    public float jumpPower = 5f;
    private bool isJumping;

    //Variables para detectar el suelo
    public float DistanceToGround = 0.1f;
    public LayerMask CapaSuelo;
    private CapsuleCollider col;

    //Variables Fisicas del personaje
    private Rigidbody rb;

    //Variablees para el Proyectil
    public GameObject Bala;
    public float BalaSpeed = 100f;
    private bool isShooting;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = rb.GetComponent<CapsuleCollider>();
    }
 
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * personajeSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);

        isShooting |= Input.GetKeyDown(KeyCode.Q);

        
        isJumping |= Input.GetKeyDown(KeyCode.Space);
        
    }

    private bool IsGrounded() //No funciona Preguntar
    {
        Vector3 capsuleBottom = new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.max.z);

        bool grounded = Physics.CheckCapsule(col.bounds.center, capsuleBottom,DistanceToGround, CapaSuelo, QueryTriggerInteraction.Ignore);
        print("suelo");
        return grounded;
    }

    private void FixedUpdate() //Preguntar a Asier que hace
    {
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angelRot = Quaternion.Euler(rotation * Time.deltaTime);
        rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * angelRot);
        if (isJumping && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
        isJumping = false;

        if (isShooting)
        {
            GameObject newBala = Instantiate(Bala, this.transform.position + new Vector3(0, 0, 1), this.transform.rotation);
            Rigidbody BalaRB = newBala.GetComponent<Rigidbody>();
            BalaRB.velocity = this.transform.forward * BalaSpeed;
        }
        isShooting = false; 
    }
    
}
