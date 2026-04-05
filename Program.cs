class Grading
{
       static void Main(string[] args)
    {

        // The main function regarding to the "Student Grade Calculator" question .


        Console.WriteLine("Enter the number of subjects : ");
        int n = Convert.ToInt32(Console.ReadLine());
        String[] subject = new string[n];
        int[] marks = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            Console.WriteLine("Enter the subject "+i+" name :");
            subject[i] = Console.ReadLine();
            Console.WriteLine("Enter the subject "+i+" marks :");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        bool isokey = true;
        foreach (int i in marks)
        {
            if(i<0 || i > 100)
            {
                Console.WriteLine("You entered invalid inputs ");
                isokey = false;
            }
        }
        if (isokey)
        {
            Student_Grade(n , marks , subject);
        }

        // This main function regarding to the "Basic Calculator" question .

        Calculator.calc(args);

        // This main function regarding to the "Simple Banking System" question .

        Banking b1 = new Banking("velan" , 500);

        Console.WriteLine(b1.account_holder_name);
        b1.deposit(5023);
        b1.withdrawal(1098);
        b1.balance();
    }
    static void Student_Grade(int n , int[] mark , String[] subject)
    {
        int total =0 ;
        for(int i = 0 ; i < mark.Length ; i++)
            {
            int single_mark = mark[i];
            String single_subject = subject[i];
            if(single_mark > 90){ Console.WriteLine(single_subject + ": A ");}
            else if (single_mark > 80){ Console.WriteLine(single_subject + ": B ");}
            else if (single_mark > 70){ Console.WriteLine(single_subject + ": C ");}
            else if (single_mark > 60){ Console.WriteLine(single_subject + ":D ");}
            else{Console.WriteLine(single_subject + ": E ");}
            total += single_mark;
        }
        Console.WriteLine("Average mark is : " + total/n);
    }
}

class Calculator
{
    public static void calc(string[] args)
    {
        Console.WriteLine("Enter the first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operator : ");
        String op = Console.ReadLine();
        try
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine("Result : " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result : " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result : " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Result : " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class Banking
{
    public String account_holder_name;
    public double amount_balance;
    public Banking( String account_holder_name , double amount_balance)
    {
        this.account_holder_name = account_holder_name;
        this.amount_balance = amount_balance;
    }
    public void deposit (int amount)
    {
        if(amount <0)
        {
            Console.WriteLine("Invalid amount");
        }
        else
        {
            amount_balance+=amount;
            Console.WriteLine("Amount added to the "+ account_holder_name +"'s account");
        }
    }
    public void withdrawal(int amount)
    {
        if(amount < 0 || amount > amount_balance)
        {
            Console.WriteLine("Invalid amount");
        }
        else
        {
            amount_balance-=amount;
            Console.WriteLine("Amount withrew to the "+ account_holder_name +"'s account");
        }
    }
    public void balance()
    {
        Console.WriteLine("The balance amount is :" + amount_balance);
    }
}