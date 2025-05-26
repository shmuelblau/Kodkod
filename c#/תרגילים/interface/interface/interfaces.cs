public interface IPowerable {

    bool IsOn { get; set; }
    void TurnOn();
    void TurnOff();

}
public interface IMovable {
    void MoveTo(string location);

}
public interface IAttackable {
    int Health { get; set; }
    void TakeDamage(int amount);
    void Heal(int amount);
}
public interface IHealer{
    void healer(int amount);
}
public interface IController {
    void Controll(int x);
}