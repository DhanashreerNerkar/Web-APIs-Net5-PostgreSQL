using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DepatmentApi.Data;
using DepatmentApi.Models;
using DepatmentApi.Repositoies;

namespace DepatmentApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController: ControllerBase
    {
        private readonly IDepartmentRepository IDR;
        public DepartmentController(IDepartmentRepository _idr)
        {
            IDR=_idr;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            var dept=await IDR.GetAll();
            return Ok(dept);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var dept=await IDR.Get(id);
            return Ok(dept);
        }


[HttpPost]
 public async Task<ActionResult<Department>> AddDepartment(Department d)
        {
            Department dpt=new(){
                DepartmentName=d.DepartmentName
            };
             await IDR.Add(dpt);
             return Ok();
        }


[HttpDelete("{id}")]
 public async Task<ActionResult> DeleteDepartment(int id)
        {
             await IDR.Delete(id);
             return Ok();
        }


[HttpPut("{id}")]
 public async Task<ActionResult<Department>> UpdateDepartment(int id,Department dept)
        {
            Department d=new()
            {DepartmentName=dept.DepartmentName};
            await IDR.Update(d);
            return Ok();
        }
    }
}