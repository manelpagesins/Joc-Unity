using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CharacterController followTo;
    public float attackDistance;
    private Animator animator;
    int isAttackingHash;
    int isWalkingHash;

    private NavMeshAgent pathfinder;
    private Transform target;

    void Awake() 
    {
        // initially set reference variables
        animator = GetComponent<Animator>();
        pathfinder = GetComponent<NavMeshAgent>();

        // set the parameter hash references
        isAttackingHash = Animator.StringToHash("isAttacking");
        isWalkingHash = Animator.StringToHash("isWalking");
    }
    
    void Start()
    {   target = GameObject.Find(followTo.name).transform;
        animator.SetBool(isAttackingHash, false);
        animator.SetBool(isWalkingHash, false);
    }

    void Update()
    { // go for player
        pathfinder.SetDestination(target.position);
        handleAnimation();
    }

    void handleAnimation()
    {    
            if (pathfinder.remainingDistance>attackDistance) {
                // No atack when player is far away
                 animator.SetBool(isWalkingHash, true);
                 animator.SetBool(isAttackingHash, false);
            }
            else {
                //Atack when player is below distance)
                    animator.SetBool(isAttackingHash, true);
                    animator.SetBool(isWalkingHash, false);
                    }
       
    }

}