import java.util.Scanner;

public class AccountHolder {
    int NUMACCTYPES = 2;

    AccountHolder next, prev;
    Accounts[] accounts = new Accounts[NUMACCTYPES];

    String firstname;
    String lastname;
    String creationDate;
    int accountNumber;
    double totalBalance;
    boolean savings;
    boolean chequing;

    public AccountHolder(String fname, String lname, int accNo){
        firstname = fname;
        lastname = lname;
        accountNumber = accNo;
        creationDate = "today";
        next = prev = null;
        savings = false;
        chequing = false;
        
        for(int i = 0; i < accounts.length; i++)
            accounts[i] = null;
    }  

    public boolean addAccount(){
        Scanner sc = new Scanner(System.in);
        boolean exit = false;

        do{
            System.out.println("1. Add Savings\n2. Add Chequing\n3. Exit");
            int option = sc.nextInt();

            switch(option){
                case 1:
                    return addSavings();
                case 2:
                    return addChequing();
                case 3:
                    exit = true;
                    break;
                default:
                    System.out.println("Enter a valid option\n");
            }
        }while(!exit);

        sc.close();
        return false;
    }

    public boolean addSavings(){
        if(!savings){
            accounts[1] = new SavingsAccount();
            savings = true;
            return true;
        }
        else{
            return false;
        }
    }

    public boolean addChequing(){
        if(!chequing){
            accounts[2] = new ChequingAccount();
            chequing = true;
            return true;
        }
        else{
            return false;
        }
    }

    public String toString(){
        return rightPadding(firstname, 15) +
                rightPadding(lastname, 15) +
                rightPadding(String.valueOf(accountNumber), 10) + "\n";
    }

    public static String rightPadding(String str, int num) {
        return String.format("%1$-" + num + "s", str);
    }

}
