// プレイヤーが敵の攻撃を被弾した際に発生する処理

public interface IDamagable
{
    //被弾ダメージの計算
    void AddDamage(int damage);
    //ダメージ分のエネルギー加算
    void AddEnergy(int damage);
    //ダメージ分のプレイヤースコア加算
    void AddScore(int damage);
}