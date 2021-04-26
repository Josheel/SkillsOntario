import java.text.SimpleDateFormat;
import java.util.Date;
import java.io.File;  // Import the File class
import java.io.IOException;  // Import the IOException class to handle errors

public class SavingsAccount implements Accounts {
    
    private double balance;
    private String creationDate;
    
    public SavingsAccount(){
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
        return balance;
    }

    @Override
    public boolean postWithdraw(double amount){
        if(balance - amount < 0)
            return false;
        else{
            balance = balance - amount;
            File file = new File("witdraw.txt");
            
        }
        return true;
    }

    @Override
    public boolean postDeposit(double amount){
        balance += amount;
        return true;
    }
}
