using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;

    private NavMeshAgent m_navMeshEnemy;

    private void Start()
    {
        m_navMeshEnemy = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        m_navMeshEnemy.SetDestination(player.position);
    }
}
