using UnityEngine;

namespace YuCheng
{

    public class Player:Character
    {
        public override void Awake()
        {
            playerType = true;
            str = 55;                 
            con = 50;                 
            dex = 60;                 
            pow = 60;                 
            intelligence = 75;        
            luck = 60;
        }

        private void Update()
        {
            base.Awake();
            hp = hpMax;
        }

        public void Attack(Enemy target, int damage)
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
