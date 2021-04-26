public interface Accounts {

    public String getWithdrawList();

    public String getDepositList();

    public double getBalance();

    public boolean postWithdraw(double amount);

    public boolean postDeposit(double amount);

}
