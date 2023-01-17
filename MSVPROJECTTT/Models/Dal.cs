namespace dal;
using MySql.Data.MySqlClient;
using emp;
public class DbManager{

public static String str=@"server=localhost;port=3306;user=root;password=root@123;database=test";

public static List<Employee> getallemp(){
    List<Employee> emplist = new List<Employee>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from employee";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                Employee emp = new Employee{
                    eid=int.Parse(reader["eid"].ToString()),
                    ename=reader["ename"].ToString(),
                    edept = reader["edept"].ToString()
                };
                Console.WriteLine(emp);
                emplist.Add(emp);
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return emplist;
}

public static void delemp( int eid){
    List<Employee> emplist = new List<Employee>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "delete from employee where eid="+eid;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
   
}
public static Employee findemp(int eid){
    Employee emp=new Employee();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from employee where eid="+eid;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                 emp = new Employee{
                    eid=int.Parse(reader["eid"].ToString()),
                    ename=reader["ename"].ToString(),
                    edept = reader["edept"].ToString()
                };
                Console.WriteLine(emp);
               
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return emp;
}

public static void insertemp(Employee emp){
    List<Employee> emplist = new List<Employee>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= $"insert into employee  (eid,ename,edept) values ('{emp.eid}','{emp.ename}','{emp.edept}')";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            cmd.ExecuteNonQuery();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    
}

public static void updateemp(Employee emp){
    List<Employee> emplist = new List<Employee>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            Console.WriteLine(emp.eid);
            String q1= $"update employee set eid='{emp.eid}',ename='{emp.ename}',edept='{emp.edept}' where eid="+emp.eid;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }

}}