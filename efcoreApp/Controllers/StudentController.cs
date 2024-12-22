using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace efcoreApp.Controllers{
    public class StudentController:Controller{

        // private olarak tanımladık çünkü _context'e sadece StudentController classı erişebilir.
        // readonly olarak tanımladık çünkü _context, constructor (kurucu) içinde atanır ve daha sonra değiştirilmesi engellenir.
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }

        // Student Form
        public IActionResult Create(){
            return View();  
        }

        // Student Create
        [HttpPost]
        public async Task<IActionResult> Create(Student model){
            _context.Students.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("List","Student");
        }

        // Student List
        public async Task<IActionResult> List() {
            var studentModel = await _context.Students.ToListAsync();
            return View(studentModel);
        }

        // Student Details
        public async Task<IActionResult> Update (int? id) {
            if (id == null) {
                return NotFound();
            }
            var student = await _context.Students.FindAsync(id);

            if(student == null) {
                return NotFound();
            }
            return View(student);
        }

        // Student Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Student model){

            if (id != model.StudentId){
                return NotFound();
            }

            if (ModelState.IsValid){
                try{
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!_context.Students.Any(student => student.StudentId == model.StudentId)){
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction("List");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete (int? id){
            if (id == null) {
               return NotFound();
            }

            var student = await _context.Students.FindAsync(id);

            if (student == null) {
                return NotFound();
            }

            return View(student);
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete ([FromForm]int id) {
          var student = await _context.Students.FindAsync(id);
          if(student == null) {
            return NotFound();
          }
          _context.Students.Remove(student);
          await _context.SaveChangesAsync();
          return RedirectToAction("List");
        }
    }
}