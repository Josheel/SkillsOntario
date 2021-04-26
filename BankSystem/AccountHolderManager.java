public class AccountHolderManager {
    AccountHolder head, tail;
    int maxAccountHolders;
    int currAccountNumber;
    int numAccounts;

    public AccountHolderManager(int max){
        maxAccountHolders = max;
        currAccountNumber = 5015000;
        numAccounts = 0;
        head = tail = null;
    }

    public boolean addAccountHolder(String fname, String lname){
        AccountHolder newAccountHolder = new AccountHolder(fname, lname, currAccountNumber);
        
        if(head == null){
            tail = head = newAccountHolder;
            numAccounts++;
            currAccountNumber++;
            return true;
        }

        else if(numAccounts < maxAccountHolders){
            tail.next = newAccountHolder;
            tail.next.prev = tail;
            tail = tail.next;
            numAccounts++;
            currAccountNumber++;
            return true;
        }
        return false;
    }

    public int findAccountHolder(int accHolderNumber){
        AccountHolder curr = head;

        while(curr != null){
            if(curr.accountNumber == accHolderNumber)
                return curr.accountNumber;
            else{
                curr = curr.next;
            }
        }

        return -1;
    }

    public boolean accountHolderExists(int accHolderNumber){
        return findAccountHolder(accHolderNumber) > 0;
    }

    public AccountHolder getAccountHolder(int accHolderNumber){
        AccountHolder curr = head;

        while(curr != null){
            if(curr.accountNumber == accHolderNumber)
                return curr;
            else{
                curr = curr.next;
            }
        }

        return null;
    }

    public String getAccountHolderList(){
        AccountHolder curr = head;
        StringBuilder str = new StringBuilder("FirstName      LastName       \t\t Account Number\n");

        while(curr != null){
            str.append(curr.toString());
            curr = curr.next;
        }
        return str.toString();
    }

    public String getAccountHolderData(int accHolderNumber){

        return "data";
    }
}
