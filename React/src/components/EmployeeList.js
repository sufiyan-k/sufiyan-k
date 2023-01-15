import { useEffect, useState } from "react"
import axios from 'axios';

const EmployeeList=()=>{

let [emparr,setemparr]=useState([]);

useEffect(()=>{
    axios.get("http://localhost:5012/employees")
    .then((response)=>{
        setemparr(response.data);
    })
})

const renderlist=()=>{
    return emparr.map(emp=>{
        return <tr>
        <td>{emp.empid}</td>
        <td>{emp.ename}</td>
        <td>{emp.sal}</td>
        </tr>
    })
}

return(
    <>
    <table border="2">
        <tr>
            <td>Empid</td>
            <td>Ename</td>
            <td>Sal</td>
        </tr>
        {renderlist()}
    </table>
    
    
    
    </>
)
}
export default EmployeeList;