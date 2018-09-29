using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (CharacterController))]
public class PlayerController : MonoBehaviour {

    public float rotationSpeed = 450;
    public float walkSpeed = 4;
    //public float runSpeed = 8;

    private Quaternion targetRotation;

    //private Animator animator;
    private CharacterController controller;
    private Camera cam;
    public Gun gun;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        //animator = GetComponent<Animator>();
        cam = Camera.main;

        if (transform.Find("EquippedWeapon").childCount >= 1)
            gun = transform.Find("EquippedWeapon").GetChild(0).GetComponent<Gun>();
        else
            gun = null;
    }
	

	// Update is called once per frame
	void Update () {
        MovementControl();
        AimingControl();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.Find("EquippedWeapon").GetChild(0).gameObject.SetActive(true);
            transform.Find("EquippedWeapon").GetChild(1).gameObject.SetActive(false);
            gun = transform.Find("EquippedWeapon").GetChild(0).GetComponent<Gun>();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.Find("EquippedWeapon").GetChild(0).gameObject.SetActive(false);
            transform.Find("EquippedWeapon").GetChild(1).gameObject.SetActive(true);
            gun = transform.Find("EquippedWeapon").GetChild(1).GetComponent<Gun>();
        }
    }

    void AimingControl()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.transform.position.y - transform.position.y));
        targetRotation = Quaternion.LookRotation(mousePos - new Vector3(transform.position.x, 0, transform.position.z));
        transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);
    }

    void MovementControl()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));


        Vector3 motion = input.normalized;
        motion *= walkSpeed;
        //if (Input.GetButton("Run"))
        //{
        //    motion *= runSpeed;
        //    animator.SetBool("IsRunning", true);
        //    animator.SetBool("IsWalking", false);
        //}
        //else if (input != Vector3.zero)
        //{
        //    motion *= walkSpeed;
        //    animator.SetBool("IsRunning", false);
        //    animator.SetBool("IsWalking", true);
        //}
        //else
        //{
        //    animator.SetBool("IsRunning", false);
        //    animator.SetBool("IsWalking", false);
        //}

        //motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;

        controller.Move(motion * Time.deltaTime);
    }
}
