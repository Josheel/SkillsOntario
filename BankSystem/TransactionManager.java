import java.util.Scanner;

public class TransactionManager {
   
     public void addAccount(AccountHolder accHolder, Scanner sc){
          boolean exit = false;

          do{
               System.out.print("1. Add Savings\n2. Add Chequing\n3. Exit\nEnter Option:");
               int option = sc.nextInt();

               switch(option){
                    case 1:
                         accHolder.addSavings();
                         break;
                    case 2:
                         accHolder.addChequing();
                         break;
                    case 3:
                         exit = true;
                         break;
                    default:
                         System.out.println("Enter a valid option \n");
               }
          }while(!exit);

     }

     public boolean withdraw(AccountHolder accHolder, Scanner sc){
          boolean exit = false;

          do{
               System.out.println("1. Withdraw from Savings\n2. Withdraw from Chequing\n3. Exit");
               int option = sc.nextInt();

               switch(option){
                    case 1:
                         if(!accHolder.savings)
                              return false;
                         else
                              return withdrawMenu(1, accHolder, sc);
                    case 2:
                         if(!accHolder.chequing)
                              return false;
                         else
                              return withdrawMenu(1, accHolder, sc);
                    case 3:
                    exit = true;
                    break;
                    default:
                         System.out.println("Enter a valid option \n");
               }
          }while(!exit);

          return false;
     }

     public boolean withdrawMenu(int accountType, AccountHolder accHolder, Scanner sc){
         
          System.out.println("Current Balance: " + accHolder.accounts[accountType].getBalance());
          System.out.print("Enter Amount: ");
          double amount = sc.nextDouble();

          return accHolder.accounts[accountType].postWithdraw(amount);
     }

     public boolean deposit(AccountHolder accHolder, Scanner sc){
          boolean exit = false;

          do{
               System.out.println("1. Deposit to Savings\n2. Deposit to Chequing\n3. Exit");
               int option = sc.nextInt();

               switch(option){
                    case 1:
                         return depositMenu(option, accHolder, sc);
                    case 2:
                         return depositMenu(option, accHolder, sc);
                    case 3:
                    exit = true;
                    break;
                    default:
                    System.out.println("Enter a valid option\n");
               }
          }while(!exit);

          return false;
     }

     public boolean depositMenu(int accountType, AccountHolder accHolder, Scanner sc){
         
          System.out.println("Current Balance: " + accHolder.accounts[accountType].getBalance());
          System.out.print("Enter Amount: ");
          double amount = sc.nextDouble();

          return accHolder.accounts[accountType].postDeposit(amount);
     }

     public String getWithdrawHistory(AccountHolder accHolder){
          Scanner sc = new Scanner(System.in);
          boolean exit = false;

          do{
               System.out.println("1. Savings\n2. Chequing\n3. Exit");
               int option = sc.nextInt();

              if(option > 0 && option < 3){
                    return accHolder.accounts[option].getWithdrawList();
              }
              else if(option == 3)
                    exit = true;
          }while(!exit);

          return "Returning to Previous Menu...";
     }

     public String getDepositHistory(AccountHolder accHolder){
          Scanner sc = new Scanner(System.in);
          boolean exit = false;

          do{
               System.out.println("1. Savings\n2. Chequing\n3. Exit");
               int option = sc.nextInt();

              if(option > 0 && option < 3){
                    return accHolder.accounts[option].getDepositList();
              }
              else if(option == 3)
                    exit = true;
          }while(!exit);

          return "Returning to Previous Menu...";
     }

     public void getTransactionList(AccountHolder accHolder, Scanner sc){
          boolean exit = false;

          do{
               System.out.println("1. Withdraw\n2. Deposit\n3. Withdraw History\n4. Deposit History\n5. Add Account\n6. Exit\n");
               int option = sc.nextInt();

               switch(option){
                    case 1:
                         if(withdraw(accHolder, sc))
                              System.out.println("Withdraw Successful");
                         else
                              System.out.println("Withdraw Unsuccessful");
                         break;
                    case 2:
                         if(deposit(accHolder, sc))
                              System.out.println("Withdraw Successful");
                         else
                              System.out.println("Withdraw Unsuccessful");
               break;
                    case 3:
                         System.out.println(getWithdrawHistory(accHolder));
                         break;
                    case 4:
                         System.out.println(getDepositHistory(accHolder));
                         break;
                    case 5:
                         addAccount(accHolder, sc);
                         break;
                    case 6:
                    exit = true;
                    break;
                    default:
                    System.out.println("Enter a valid option\n");
               }
          }while(!exit);
     }

}
