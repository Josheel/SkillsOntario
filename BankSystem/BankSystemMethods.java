import java.util.Scanner;

public class BankSystemMethods {
    private static final int LNAMELENGTH = 14;
    private static final int FNAMELENGTH = 14;
    private static final int ACCNUMBERLEN = 5016000;

    // Used to get string inputs from the user, taken from Andrew Rudder's
    // GameShop demo
    protected static String getString(int length, String message, Scanner scanner){
        String str;
        do{
            System.out.print(message);

            while (!scanner.hasNextLine())
            {
                scanner.nextLine(); // clear the invalid input ...
                System.out.print(message);
            }

            str = scanner.nextLine();

            if(str.length() > length)
                System.out.println("Too many characters");

        }while(str.length() > length);

        return str;
    }

    // Same as getString(), except for integers
    protected static int getInteger(String message, Scanner scanner){
        int length;
        do{
            System.out.print(message);
            while (!scanner.hasNextInt())
            {
                scanner.nextLine(); // clear the invalid input ...
                System.out.print(message);
            }
            length = Integer.parseInt(scanner.nextLine());
        }while(((float)length / (float)ACCNUMBERLEN) > 1.0);
        return length;
    }

    protected static void menu(){
        System.out.print("1. Add Account\n2. Get Account\n3. Account Holder List\n4. Exit\nEnter an option: ");
    }
    protected static void addAccountHolder(Scanner scanner, BankAccountCoordinator bac){
        System.out.println("----------Add Customer----------");

        String fname = getString(FNAMELENGTH, "Enter First Name: ", scanner);
        String lname = getString(LNAMELENGTH, "Enter Last Name: ", scanner);
        bac.addAccountHolder(fname, lname);
    }

    protected static void getAccountHolder(Scanner scanner, BankAccountCoordinator bac){
        int accHolderNo = getInteger("Enter Account Holder's Number: ", scanner);
        bac.getTransactionsList(accHolderNo, scanner);     
    }

    protected static void getAccountHolderList(BankAccountCoordinator bac){
        System.out.println(bac.getAccoutHolderList());
    }

}
