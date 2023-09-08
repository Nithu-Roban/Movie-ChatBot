using System.Data;
using MySqlConnector;
using System.IO;
using System.Linq;

public class TableCreate
{
    public void creation()
    {
        string Connstr = "server=localhost;user=root;database=movie;port=3306;password=''";
        MySqlConnection conn = new MySqlConnection(Connstr);
        string sql = "create table newMovie(movieid int primary key,moviename varchar(500) , language varchar(100),type varchar(200))";
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("table created");
            conn.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }
    }
}

public class Malayalam
{
   
    public  void Show()
    {
        Console.WriteLine("Bot:\tGreat choice! You selected malayalam movies.");
        Console.WriteLine("\tPlease enter the movie genre you prefer (e.g., Action, Comedy, Thriller):");
        Console.Write("user:\t");
        string input = Console.ReadLine();
        string lang = "malayalam";

        string Connstr = "server=localhost;user=root;database=movie;port=3306;password=''";
        MySqlConnection conn = new MySqlConnection(Connstr);
        string sql = "select moviename from newMovie where type = @input and language = @lang ";
        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@lang", MySqlDbType.VarChar).Value = lang;
            cmd.Parameters.Add("@input", MySqlDbType.VarChar).Value = input;

            Console.WriteLine("Bot:\tLooking for the perfect movie? Take a look at these fantastic recommendations:\"\n\n");
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                Console.WriteLine(rdr[0].ToString());
            }
            rdr.Close();
            if (rdr.FieldCount < 0)
            {
                Console.WriteLine($"Bot:\tSorry, no recommendations available for movies in the {input} genre");
            }
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }
        //conn.Close ();
        try
        {

            Console.WriteLine("Bot:\tMovie time! Let me know which film caught your eye.\"\n");
            Console.Write("user:\t");
            string response = Console.ReadLine();
            string str = "select description, platform from newMovie where moviename = @response";
            MySqlCommand mycmd = new MySqlCommand(str, conn);
            mycmd.Parameters.Add("@response", MySqlDbType.VarChar).Value = response;

            Console.WriteLine("Bot:\tBehold, a cinematic gem awaits you!\n\n");
            MySqlDataReader rd = mycmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine("  Short Description:  \n");
                Console.WriteLine(rd[0].ToString() + "\n\n  Available on:\t " + rd[1].ToString());
            }
            rd.Close();
            conn.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }



    }
}


public class English
{

    public void Show()
    {
        Console.WriteLine("Bot:\tGreat choice! You selected English movies.");
        Console.WriteLine("\tPlease enter the movie genre you prefer (e.g., Action, Comedy, Thriller):");
        Console.Write("user:\t");
        string input = Console.ReadLine();
        string lang = "english";
        

        string Connstr = "server=localhost;user=root;database=movie;port=3306;password=''";
        MySqlConnection conn = new MySqlConnection(Connstr);
        string sql = "select moviename from newMovie where type = @input and language = @lang ";
        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@lang", MySqlDbType.VarChar).Value = lang;
            cmd.Parameters.Add("@input", MySqlDbType.VarChar).Value = input;

             Console.WriteLine("Bot:\tLooking for the perfect movie? Take a look at these fantastic recommendations:\"\n\n");
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0].ToString());
            }
            if (rdr.FieldCount < 0)
            {
                Console.WriteLine($"Bot:\tSorry, no recommendations available for movies in the {input} genre");
            }
            rdr.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }
        //conn.Close ();
        try
        {

            Console.WriteLine("Bot:\tMovie time! Let me know which film caught your eye.\"\n");
            Console.Write("user:\t");
            string response = Console.ReadLine();
            string str = "select description, platform from newMovie where moviename = @response";
            MySqlCommand mycmd = new MySqlCommand(str, conn);
            mycmd.Parameters.Add("@response", MySqlDbType.VarChar).Value = response;

            Console.WriteLine("Bot:\tBehold, a cinematic gem awaits you! \n\n");
            MySqlDataReader rd = mycmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine("  Short Description:  \n");
                Console.WriteLine(rd[0].ToString() + "\n\n  Available on:\t " + rd[1].ToString());
            }
            rd.Close();
            conn.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }



    }
}

public class Hindi
{

    public void Show()
    {
        Console.WriteLine("Bot:\tGreat choice! You selected malayalam movies.");
        Console.WriteLine(" \tPlease enter the movie genre you prefer (e.g., Action, Comedy, Thriller):");
        Console.Write("user:\t");
        string input = Console.ReadLine();
        string lang = "hindi";

        string Connstr = "server=localhost;user=root;database=movie;port=3306;password=''";
        MySqlConnection conn = new MySqlConnection(Connstr);
        string sql = "select moviename from newMovie where language = @lang and type = @input ";
        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@lang", MySqlDbType.VarChar).Value = lang;
            cmd.Parameters.Add("@input", MySqlDbType.VarChar).Value = input;

            Console.WriteLine("Bot:\tLooking for the perfect movie? Take a look at these fantastic recommendations:\"\n\n");
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0].ToString());
            }
            if (rdr.FieldCount < 0)
            {
                Console.WriteLine($"Bot:\tSorry, no recommendations available for movies in the {input} genre");
            }
            rdr.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }
        //conn.Close ();
        try
        {

            Console.WriteLine("Bot:\tMovie time! Let me know which film caught your eye.\"\n");
            Console.Write("user:\t");
            string response = Console.ReadLine();
            string str = "select description, platform from newMovie where moviename = @response";
            MySqlCommand mycmd = new MySqlCommand(str, conn);
            mycmd.Parameters.Add("@response", MySqlDbType.VarChar).Value = response;

            Console.WriteLine("Bot:\tBehold, a cinematic gem awaits you! \n\n");
            MySqlDataReader rd = mycmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine(" Short Description:  \n");
                Console.WriteLine(rd[0].ToString() + "\n\n  Available on:\t " + rd[1].ToString());
            }
            rd.Close();
            conn.Close();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }



    }
}
public class Language
{
    public static void display()
    {
        Console.WriteLine("Bot:\tPlease choose your preferred language (Malayalam, English, Hindi).\n");
        Console.Write("user:\t");
        string lang = Console.ReadLine();
        lang = lang.ToLower();
        if( lang == "malayalam")
        {
            Malayalam m = new Malayalam();
            m.Show();
        }
        if (lang == "english")
        {
            English E = new English();
            E.Show();
        }
        if (lang == "hindi")
        {
            Hindi H = new Hindi();
            H.Show();
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        string username, input= null;
        Console.WriteLine("Bot:\tHey and Welcome ");
        Console.Write("user: \t");
        username = Console.ReadLine();
        username.ToLower();
        if(username.Contains("Hii")|| username.Contains("Hey")|| username.Contains("Hello"))
            Console.WriteLine($"Bot:\tWelcome to MovieBot!  Ready to explore some awesome movies? \n");

        do
        {
            //Console.WriteLine("I can help you with MOVIE RECOMMENDATION \n ");

            Language.display();
            Console.WriteLine("\nBot:\tReady for more recommendations?");
            Console.Write("user:\t");
            input = Console.ReadLine();
        } while (input == "yes" || input == "Yes" || input == "YES");
        Console.WriteLine("\"If you have any more movie-related questions or need further recommendations in the future, don't hesitate to reach out. Enjoy your movie time, and have a fantastic day!");
    }
}


