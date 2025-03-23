using UnityEngine;

namespace YuCheng
{

    public class Enemy : Character
    {
        

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
    }
}
