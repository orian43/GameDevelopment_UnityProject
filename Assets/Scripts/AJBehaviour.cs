using UnityEngine;
using UnityEngine.AI;

public class AJBehaviour : MonoBehaviour
{
    Animator animator;
    NavMeshAgent NMeshAgent;
    public GameObject target;
    public GameObject target2;

    LineRenderer path;
    bool isTargt1 = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        NMeshAgent = GetComponent<NavMeshAgent>();
        path = GetComponent<LineRenderer>();
        path.positionCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        // each frame the agent can move, which changes the path.
     //   if (path.positionCount > 0)
        {
            path.positionCount = NMeshAgent.path.corners.Length;
            path.SetPositions(NMeshAgent.path.corners);
        }
        if(!NMeshAgent.isStopped)
        {
            float distance;

            if (isTargt1)
                distance = Vector3.Distance(transform.position, target.transform.position);
            else
                distance = Vector3.Distance(transform.position, target2.transform.position);


            if (distance < 4)
            {
                //  NMeshAgent.isStopped = true;
                //  animator.SetInteger("State", 0);
                if (isTargt1)
                {
                    NMeshAgent.SetDestination(target2.transform.position);
                    isTargt1 = false;

                }
                else
                {
                    NMeshAgent.SetDestination(target.transform.position);
                    isTargt1 = true;

                }



            }
        }
      if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetInteger("State", 1);

            //starts computing the path
            NMeshAgent.SetDestination(target.transform.position);


            // create line renderer
            path.positionCount= NMeshAgent.path.corners.Length;
            path.SetPositions(NMeshAgent.path.corners);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("State", 0);
        }
    }
}
