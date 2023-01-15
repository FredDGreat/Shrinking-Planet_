using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10f;

	private float rotation;
	private float touchRotation;
	private Rigidbody rb;

	Vector3 yRotation;
	Quaternion deltaRotation;
	Quaternion targetRotation;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		rotation = Input.GetAxisRaw("Horizontal");
	}

	public void RightControlDown()
    {
		touchRotation = 1;

	}

	public void RightControlUp()
	{
		touchRotation = 0;
	}

	public void LeftControlDown()
    {
		touchRotation = -1;
	}

	public void LeftControlUp()
	{
		touchRotation = 0;
	}

	void FixedUpdate ()
	{
		if (!GameManager.pause)
		{
			rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
			/*Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
			//rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.deltaTime);
			//Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.deltaTime;
			Quaternion deltaRotation = Quaternion.Euler(yRotation);
			Quaternion targetRotation = rb.rotation * deltaRotation;
			rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));*/
			//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);

			yRotation = Vector3.up * touchRotation * rotationSpeed * Time.fixedDeltaTime;
			//rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.deltaTime);
			//Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.deltaTime;
			deltaRotation = Quaternion.Euler(yRotation);
			targetRotation = rb.rotation * deltaRotation;
			rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));

		}
	}

}
