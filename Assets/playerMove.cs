using UnityEngine;

public class playerMove : MonoBehaviour
{
    public CharacterController Cc;
    public Transform cameraTransform;
    public float Gravity;
    public float WalkSpeed;
    private float yspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) );
        cameraTransform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0));
        Vector3 move = Vector3.zero;
        //Apply walk vector
        move += Input.GetAxis("Vertical") * transform.forward;
        move += Input.GetAxis("Horizontal") * transform.right;
        move = move.normalized * WalkSpeed;
        //Apply gravity
        move += new Vector3(0, yspeed, 0);

        Cc.Move(move * Time.deltaTime);
    }
}
