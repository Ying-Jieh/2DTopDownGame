using UnityEngine;

public class TriEnemy : GameActor, IEnemy
{
    [SerializeField] private string enemyName;
    [SerializeField] private float damage = 2f;
    public string EnemyName { get => name; set => name = value; }
    public float Damage { get => damage; set => damage = value; }

    public void Initialize()
    {
        Debug.Log("Initialize Enemy: " + EnemyName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
		}
    }

    public override void Attack(Transform aTarget)
    {
        Debug.Log(enemyName + "::Attack()");
	}
}