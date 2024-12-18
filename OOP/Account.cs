public class Account
{
    public string name;
    public int accountNum;
    private int pin;

    public void SetPin(int newPassword)
    {
        pin = newPassword;
    }

    public int GetPin()
    {
        return pin;
    }
}