using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Daniel";
            string middleName = "Ivanov";
            string lastName = "Kondov";
            object holderName = firstName + " "+ middleName+" "+ lastName;
            decimal balance = 10999;
            string bankName = "Bank";
            string iban = "BH67BMAG00001299123456";
            long card1 = 123456789111;
            long card2 = 123456789112;
            long card3 = 123456789113;
            Console.WriteLine("Account holder: " + holderName
            + "\nBalance: " + balance
            + " BGN\nBank: " + bankName
            + "\nIBAN: " + iban
            + "\nCredit Card 1: " + card1
            + "\nCredit Card 2: " + card2
            + "\nCredit Card 3: " + card3);


        }
    }

