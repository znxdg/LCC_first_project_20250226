using Unity.Burst.CompilerServices;
using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 創建角色(玩家及敵人)類別
    /// </summary>
    public class Character : MonoBehaviour
    {
        protected int str;                 // 力量：用於物理攻擊
        protected int con;                 // 體質：用於抵抗物理攻擊
        protected int dex;                 // 敏捷：用於閃避及戰鬥先後順序
        protected int pow;                 // 意志：用於抵抗魔法攻擊
        protected int intelligence;        // 智力：用於魔法攻擊
        protected int luck;                // 幸運：用於探索寶箱
        protected bool playerType = false; // 是否為玩家角色 
        protected int hpMax;               // 最大血量
        protected int hp;                  // 當前血量：用於判斷死亡於否
        protected Animator ani;

        public virtual void Awake()
        {
            hpMax = (con + pow) / 10;   // 最大血量設置使用防禦屬性的體質及意志來做計算
            ani = GetComponent<Animator>();
        }

        public void Hurt(int damage)
        {
            if (hp <= 0) return;

            hp -= damage;
            if (hp <= 0) Dead();
            Debug.Log($"<color=#f93>受傷，剩餘血量：{hp}</color>");

            if (!playerType) ani.SetTrigger("hurt");
        }

        public virtual void Dead()
        {
            if (playerType)
            { 
                Debug.Log("<color=#f33>玩家死亡，遊戲結束</color>");
            }
            else
            {
                Debug.Log("<color=#f33>敵人死亡，前往下一輪</color>");
                ani.SetTrigger("die");
            } 
        }
    }
}
