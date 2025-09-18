using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{
  private Rigidbody rb;
  private float movementX; //movimiento en x
  private float movementY; //movimiento en y 

  public float speed = 0; //velocidad

  private int count;//contador


  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    count = 0; //inicializado a cero
  }

  void OnMove(InputValue movementValue)
  {
    Vector2 movementVector = movementValue.Get<Vector2>();
    movementX = movementVector.x;
    movementY = movementVector.y;
  }

  private void FixedUpdate()
  {
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    rb.AddForce(movement * speed); //velocidad de movimiento

  }
   
    void OnTriggerEnter(Collider other) 
   {
    if (other.gameObject.CompareTag("PickUp")) //Comprueba que el objeto chocado es el llamaod pickup
    {
      other.gameObject.SetActive(false); //Desactiava el objeto
      count += 1;
       }
     
   }


}
