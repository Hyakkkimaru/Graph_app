using System;

// This class represents an exception that is thrown when there is an issue with the quantity in the system.
public class QuantityException : Exception
{
   // This constructor initializes a new instance of the QuantityException class with a specified error message.
   public QuantityException(string message) : base(message) {}
}

// This class represents an exception that is thrown when there is an issue with a deposit in the system.
public class DepositException : Exception
{
   // This constructor initializes a new instance of the DepositException class with a specified error message.
   public DepositException(string message) : base(message) {}
}

// This class represents a bank in the system.
public class Bank
{
   // This property gets or sets the name of the bank.
   public string Name
   {
       get { return name;}</code> // This property returns the name of the bank.
       set { name = value;}</code> // This property sets the name of the bank.
   }
}

// This class represents a branch of a bank in the system.
public class Branch
{
   // This property gets or sets the name of the branch.
   public string Name
  {
       get { return name;}</code> // This property returns the name of the branch.
       set { name = value;}</code> // This property sets the name of the branch.
   }

   // This property gets or sets the sum of money in the branch.
   public double All_Sum_Branch
  {
       get { return sum;}</code> // This property returns the sum of money in the branch.
       set { sum = value;}</code> // This property sets the sum of money in the branch.
   }
}

// This class represents a deposit in the system.
public class Deposit
{
   // This property gets or sets the full name of the person who owns the deposit.
   public string FullName
  {
       get { return fullName;}</code> // This property returns the full name of the person who owns the deposit.
       set { fullName = value;}</code> // This property sets the full name of the person who owns the deposit.
   }

   // This property gets or sets the sum of money in the deposit.
   public double All_Sum_Deposit
  {
       get { return sum;}</code> // This property returns the sum of money in the deposit.
       set { sum = value;}</code> // This property sets the sum of money in the deposit.
   }

   // This method calculates the deposit amount based on the number of months.
   public double Sum_Deposit(int amount_month)
  {
       try
      {
           if (sum < 0)
           {
               throw new DepositException($"It is impossible to create a deposit - a negative deposit amount is indicated: {sum}");
           }
           return sum;
       }

       catch (DepositException ex)
      {
           Console.WriteLine(ex.Message);
           return 0;
       }
   }
}

// This class represents a long-term deposit in the system.
public class LongTermDeposit : Deposit
{
   // This method calculates the long-term deposit amount based on the number of months.
   public new double Sum_Deposit(int months)
  {
       try
      {
           if (months < 0)
           {
               throw new QuantityException("The number of months cannot be negative.");
           }

           return base.Sum_Deposit(months) * months;
       }

       catch (QuantityException ex)
      {
           Console.WriteLine(ex.Message);
           return 0;
       }
   }
}

// This class represents a deposit that can be withdrawn on demand in the system.
public class DepositUntilDemand : Deposit
{
   // This method calculates the deposit amount based on the number of months.
   public double CalculateDepositAmount(int months)
  {
       try
      {
           if (months < 0)
          {
               throw new QuantityException("The number of months cannot be negative.");
           }

           return base.Sum_Deposit(months) * months;
       }

       catch (QuantityException ex)
      {
           Console.WriteLine(ex.Message);
           return 0;
       }
   }
}

// This class represents the main program.
public class Program
{
   // This is the entry point of the program.
   public static void Main()
  {
       // Create a new bank object with the name "MyBank".
       Bank bank = new Bank { Name = "MyBank"}
       Branch branch = new Branch { Name = "Main Branch", All_Sum_Branch = 0}

       // Create a new deposit object with the full name "John Doe" and the sum of money 1000.
       Deposit deposit = new Deposit { FullName = "John Doe", All_Sum_Deposit = 1000}

       try
       {
           // Calculate the deposit amount for John Doe for 12 months.
           Console.WriteLine($"Deposit amount for {deposit.FullName}: {deposit.Sum_Deposit(12)}")
       }
       catch (Exception ex)
      {
           // Print the error message if there is an exception.
           Console.WriteLine($"Error: {ex.Message}")
       }

       // Create a new long-term deposit object with the full name "Jane Doe" and the sum of money 5000.
       LongTermDeposit longTermDeposit = new LongTermDeposit { FullName = "Jane Doe", All_Sum_Deposit = 5000}

       try
      {
           // Calculate the long-term deposit amount for Jane Doe for 60 months.
           Console.WriteLine($"Long-term deposit amount for {longTermDeposit.FullName}: {longTermDeposit.Sum_Deposit(60)}")
       }
       catch (Exception ex)
      {
           // Print the error message if there is an exception.
           Console.WriteLine($"Error: {ex.Message}")
       }

       // Create a new deposit on demand object with the full name "Jim Brown" and the sum of money 2000.
       DepositUntilDemand depositUntilDemand = new DepositUntilDemand { FullName = "Jim Brown", All_Sum_Deposit = 2000}

       try
      {
           // Calculate the deposit amount for Jim Brown for 48 months.
           Console.WriteLine($"Deposit amount for {depositUntilDemand.FullName}: {depositUntilDemand.CalculateDepositAmount(48)}")
       }
       catch (Exception ex)
      {
           // Print the error message if there is an exception.
           Console.WriteLine($"Error: {ex.Message}")
       }
   }
}
