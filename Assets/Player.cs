using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;

    void Start()
    {

    }

    void Update()
    {
        var derection = new Vector2(Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed, Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed);
        gameObject.transform.position += (Vector3)derection;
    }
}
