using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        Vector3 moveDirection = new Vector3(xDirection,0.0f, yDirection);

        transform.position += moveDirection;
    }
}
