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

  public TextMeshProUGUI countText; //Puntaje
  public GameObject WinText; //Texto "ganaste"




  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    count = 0; //inicializado a cero
    SetCountText();
    WinText.SetActive(false); //Texto desactivado

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
      SetCountText();
    }

  }

  void SetCountText()
  {
    countText.text = "Score: " + count.ToString();
    if (count >= 10)
    {
      WinText.SetActive(true); //Si el puntaje es igual o mayor al numero de items se mostrara el mensaje
    }
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Enemy"))
    {
             // Destroy the current object
       Destroy(gameObject); 
       // Update the winText to display "You Lose!"
       WinText.gameObject.SetActive(true);
      WinText.GetComponent<TextMeshProUGUI>().text = "You Lose!";
    }
   }
   


}
