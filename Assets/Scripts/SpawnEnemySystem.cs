using UnityEngine;

namespace YuCheng
{
    /// <summary>
    /// 生成敵人系統
    /// </summary>
    public class SpawnEnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人物件")]
        private GameObject[] enemys;

        private int index;

        private void Awake()
        {
            SpawnEnemy();
        }
        private void SpawnEnemy()
        {
            // Quaternion.identity 零角度
            // 生成(物件, 座標, 角度)
            Instantiate(enemys[index], new Vector2(0.0651f, -1.966f), Quaternion.identity);
        }
        private void SpawnEnemy(int _index)
        {
            // Quaternion.identity 零角度
            // 生成(物件, 座標, 角度)
            if (_index == 3)
            {
                Instantiate(enemys[index], new Vector2(0, -1.83f), Quaternion.identity);
            }
            else
            {
                Instantiate(enemys[index], new Vector2(0, 0), Quaternion.identity);
            }
        }

        public void SpwanNextEnemy()
        {
            if (index == enemys.Length - 1) return; // 如果編號等於敵人數量 -1 就跳出

            index++;            // 編號加一
            SpawnEnemy(index);       // 生成敵人
        }
    }
}
