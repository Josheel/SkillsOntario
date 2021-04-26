import java.text.SimpleDateFormat;
import java.util.Date;

public class ChequingAccount implements Accounts {
        
    private double balance;
    private String creationDate;
    
    public ChequingAccount(){
        balance = 0.0;
        creationDate = new SimpleDateFormat("dd-MM-yyyy").format(new Date());
    }

    @Override
    public String getWithdrawList() {
        return null;
    }

    @Override
    public String getDepositList() {
        return null;
    }

    @Override
    public double getBalance() {
        return 0;
    }

    @Override
    public boolean postWithdraw(double amount){
        if(balance - amount < 0)
            return false;
        else
            balance = balance - amount;

        return true;
    }

    @Override
    public boolean postDeposit(double amount){
        balance += amount;
        return true;
    }
}
