import java.util.Scanner;

public class BankAccountCoordinator {

    private AccountHolderManager accountMan;
    private TransactionManager transactionMan;

    public BankAccountCoordinator(int max){
        accountMan = new AccountHolderManager(max);
        transactionMan = new TransactionManager();
    }

    public void addAccountHolder(String fname, String lname){
        if(accountMan.addAccountHolder(fname, lname))
            System.out.println("Account Holder added...");
        else   
            System.out.println("Could not add Account Holder...");
    }

    public AccountHolder getAccountHolder(int accHolderNumber){
        return accountMan.getAccountHolder(accHolderNumber);
    }

    public boolean accountHolderExists(int accHolderNumber){
        return accountMan.accountHolderExists(accHolderNumber);
    }

    public String getAccountHolderData(int accHolderNumber){
        return accountMan.getAccountHolderData(accHolderNumber);
    }

    public String getAccoutHolderList(){
        return accountMan.getAccountHolderList();
    }

    public boolean closeAccount(){
        return false;
    }

    public void getTransactionsList(int accHolderNo, Scanner sc){
        if(accountHolderExists(accHolderNo)){
            AccountHolder accHolder = getAccountHolder(accHolderNo);
            transactionMan.getTransactionList(accHolder, sc);
        }
        else{
            System.out.println("Account Holder does not exist...");
        } 
    }
    
}