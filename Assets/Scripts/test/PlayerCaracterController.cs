using UnityEngine;

namespace TP1_Encapsulation.Correction
{
    [RequireComponent(typeof(PlayerCharacter))]
    public class PlayerCharacterController : MonoBehaviour
    {
        private PlayerCharacter playerCharacter;
        private Rigidbody rb;

        [SerializeField] private float jumpForce = 10f;
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private Transform groundCheck;
        [SerializeField] private float groundCheckRadius = 0.2f;

        private bool isGrounded;
        private float horizontalInput;
        private float verticalInput;

        // R�f�rences aux animations (si besoin)
        private Animator animator;

        // Effet sp�cial pour le dash (particules, tra�n�e, etc.)
        [SerializeField] private ParticleSystem dashEffect;
        [SerializeField] private float dashCost = 25f; // Co�t en mana pour le dash
        [SerializeField] private float dashMultiplier = 2.5f; // Multiplicateur de vitesse pour le dash
        [SerializeField] private float dashDuration = 0.5f; // Dur�e du dash
        private bool isDashing = false;

        private void Awake()
        {
            playerCharacter = GetComponent<PlayerCharacter>();
            animator = GetComponent<Animator>();

            // Configurer le rigidbody pour un jeu 3D
            rb = GetComponent<Rigidbody>();

            if (rb == null)
            {
                Debug.LogError("Rigidbody component is missing on this GameObject.");
            }

            if (groundCheck == null)
            {
                // Cr�er un point de v�rification du sol s'il n'est pas d�fini
                groundCheck = new GameObject("GroundCheck").transform;
                groundCheck.SetParent(transform);
                groundCheck.localPosition = new Vector3(0, -1f, 0);
            }
        }

        private void Update()
        {
            // R�cup�rer les entr�es du joueur
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");

            // V�rifier si le joueur est au sol
            CheckGrounded();

            // Gestion du saut
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                Jump();
            }

            // Mise � jour des animations (si besoin)
            UpdateAnimations();
        }

        private void FixedUpdate()
        {
            // Ne pas permettre de mouvement si le personnage est mort
            if (playerCharacter.Health <= 0) return;

            // Appliquer le mouvement
            if (!isDashing)
            {
                Move();
            }
        }

        private void Move()
        {
            // Utiliser la vitesse de d�placement du PlayerCharacter
            float currentSpeed = playerCharacter.MoveSpeed;

            // Mouvement pour un jeu 3D
            Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized * currentSpeed;
            rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

            // Rotation du personnage dans la direction du mouvement (pour 3D)
            if (movement.x != 0 || movement.z != 0)
            {
                transform.rotation = Quaternion.LookRotation(new Vector3(movement.x, 0, movement.z));
            }
        }

        private void Jump()
        {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        private void CheckGrounded()
        {

            isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        }

        private void UpdateAnimations()
        {
            if (animator != null)
            {
                // Mettre � jour les param�tres d'animation
                float movementMagnitude = new Vector2(horizontalInput, verticalInput).magnitude;
                animator.SetFloat("Speed", movementMagnitude);
                animator.SetBool("IsGrounded", isGrounded);
                animator.SetBool("IsDashing", isDashing);
            }
        }

        // Dessiner les gizmos pour le debug
        private void OnDrawGizmos()
        {
            if (groundCheck != null)
            {
                Gizmos.color = isGrounded ? Color.green : Color.red;
                Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
            }
        }

        private void AutoPickup()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, 5);

            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.tag == "bow")
                {
                    //collider.gameObject.transform ==
                }
                else if (collider.gameObject.tag == "diamondsword")
                {

                }
            }
        }
    }
}