using UnityEngine;

public class Moviento_rotatorio_helice : MonoBehaviour
{
    public float velocidad = 500f; // grados por segundo

    void Update()
    {
        // Rota alrededor del eje y (como un reloj)
        transform.Rotate(0,velocidad * Time.deltaTime,0);
    }
}
