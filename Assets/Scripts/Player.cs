using System.Collections.Generic;
using UnityEngine;

namespace YuCheng
{

    public class Player : Character
    {
        public enum StatType { Strength, Constitution, Dexterity, Power, Intelligence, Luck }

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

        public void Attack(Enemy target, int damage, StatType stat)
        {
            int success_line = Random.Range(1, 101);
            int statValue = GetStatValue(stat);

            if (statValue <= success_line)
            {
                if (target != null)
                {
                    target.Hurt(damage);
                    Debug.Log($"使用 {stat} 對 {target.gameObject.name} 造成 {damage} 點傷害");
                }
                else
                {
                    Debug.Log("攻擊目標無效!");
                }
            }
            else
            {
                Debug.Log("攻擊失敗！");
            }
        }
        private int GetStatValue(StatType stat) => new Dictionary<StatType, int>
        {
            { StatType.Strength, str },
            { StatType.Constitution, con },
            { StatType.Dexterity, dex },
            { StatType.Power, pow },
            { StatType.Intelligence, intelligence },
            { StatType.Luck, luck }
        }[stat];
    }
}
