using UnityEngine;

namespace YuCheng
{

    public class Enemy : Character
    {
        private SpawnEnemySystem spawnEnemySystem;

        public override void Awake()
        {
            base.Awake();
            spawnEnemySystem = FindFirstObjectByType<SpawnEnemySystem>();
        }

        public void Attack(Player target, int damage)
        {
            if (target != null)
            {
                target.Hurt(damage);
                Debug.Log($"對 {target.gameObject.name} 造成 {damage} 點傷害");
            }
            else
            {
                Debug.Log("攻擊目標無效!");
            }
        }

        public override void Dead()
        {
            if (playerType)
            {
                Debug.Log("<color=#f33>玩家死亡，遊戲結束</color>");
            }
            else
            {
                Debug.Log("<color=#f33>敵人死亡，前往下一輪</color>");
                ani.SetTrigger("die");
                Invoke("SpawnNextEnemy", 1);
                Destroy(gameObject, 1.1f);
            }
        }

        private void SpawnNextEnemy()
        {
            spawnEnemySystem.SpwanNextEnemy();
        }
    }
}
