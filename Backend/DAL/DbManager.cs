// namespace DAL;
// using BOL;

// public class DbManager{

//     public static List<Employee> GetAllEmps(){

//         using(var context=new CollectionContext()){
//             var employees=from emp in context.Empset select emp;
//             return employees.ToList<Employee>();
//         }
//     }
// }